using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace MyPhotoManager {
    public partial class Form_Main:Form {
        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender,EventArgs e) {
            init_Disk();
            load_Config();
        }

        private void load_Config() {
            string pk_DefaultDisk = ConfigurationManager.AppSettings["DefaultDisk"];
            string pk_SearchAllDirectories = ConfigurationManager.AppSettings["SearchAllDirectories"];
            string pk_PhotoFileType = ConfigurationManager.AppSettings["PhotoFileType"];

            if(string.IsNullOrEmpty(pk_DefaultDisk) == false) {
                cbx_Disk.Text = pk_DefaultDisk;
            }
            cbx_SearchAllDirectory.Checked = Boolean.Parse(pk_SearchAllDirectories);
            tbx_searchPattern.Text = pk_PhotoFileType;
        }

        private void init_Disk() {
            cbx_Disk.Items.Clear();
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach(DriveInfo driveInfo in driveInfos) {
                switch(driveInfo.DriveType) {
                    case DriveType.CDRom:
                    case DriveType.Network:
                    case DriveType.NoRootDirectory:
                    case DriveType.Ram:
                    case DriveType.Unknown:
                        continue;
                }

                cbx_Disk.Items.Add(driveInfo.Name);
            }

            if(cbx_Disk.Items.Count > 0) {
                cbx_Disk.SelectedIndex = 0;
            }
        }

        private void cbx_Disk_SelectedIndexChanged(object sender,EventArgs e) {
            load_SubDirectory(null,cbx_Disk.Text);
            load_SubPhoto(cbx_Disk.Text);
            save_Config("DefaultDisk",cbx_Disk.Text);
        }

        private void save_Config(string key,string value) {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
        }

        private void load_SubDirectory(TreeNode treeNode,string targetPath = null) {            
            tsl_CountTip.Text = "";
            tsl_ErrorLog.Text = "";            

            if(treeNode == null) {
                tvw_DirectoryTree.Nodes.Clear();
                if(Directory.Exists(targetPath) == false) {
                    return;
                }
            } else {
                targetPath = treeNode.Name;
                treeNode.Nodes.Clear();
            }

            // 加载下级文件夹
            string[] subDirectories = Directory.GetDirectories(targetPath);
            foreach(string subDirPath in subDirectories) {
                DirectoryInfo dirInfo = new DirectoryInfo(subDirPath);
                bool isDirectory = false;

                //判断是否隐藏文件夹
                if((dirInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) {
                    continue;
                }
                if((dirInfo.Attributes & FileAttributes.System) == FileAttributes.System) {
                    continue;
                }
                // 判断类型是文件或文件夹
                if((dirInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory) {
                    isDirectory = true;
                }

                TreeNode newNode = new TreeNode();

                newNode.Name = dirInfo.FullName;
                newNode.Text = dirInfo.Name;
                newNode.ImageIndex = isDirectory ? 1 : 0;
                newNode.SelectedImageIndex = newNode.ImageIndex;

                if(treeNode == null) {
                    tvw_DirectoryTree.Nodes.Add(newNode);
                } else {
                    treeNode.Nodes.Add(newNode);
                }
            }
            if(treeNode != null) {
                treeNode.Expand();
                tsl_CountTip.Text = "文件夹：" + treeNode.Nodes.Count;
            }
        }

        private void toolMenu_OpenDirectory_Click(object sender,EventArgs e) {
            if(tvw_DirectoryTree.SelectedNode == null) {
                return;
            }
            Process.Start(tvw_DirectoryTree.SelectedNode.Name);
        }

        private void tvw_DirectoryTree_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e) {
            load_SubPhoto(e.Node.Name);
        }

        private void tvw_DirectoryTree_NodeMouseDoubleClick(object sender,TreeNodeMouseClickEventArgs e) {
            if(e.Node.Nodes.Count > 0) {
                return;
            }
            load_SubDirectory(e.Node);
        }

        private void load_SubPhoto(string directoryPath) {
            SearchOption searchOption = cbx_SearchAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            string searchPattern = tbx_searchPattern.Text;

            dgv_Main.Rows.Clear();
            // 加载文件夹中的照片
            try {
                string[] files = Directory.GetFiles(directoryPath,"*.bmp",searchOption)
                    .Union(Directory.GetFiles(directoryPath,"*.gif",searchOption))
                    .Union(Directory.GetFiles(directoryPath,"*.png",searchOption))
                    .Union(Directory.GetFiles(directoryPath,"*.jpg",searchOption))
                    .Union(Directory.GetFiles(directoryPath,"*.jpeg",searchOption))
                    .ToArray();
                foreach(string filePath in files) {
                    FileInfo fileInfo = new FileInfo(filePath);
                    dgv_Main.Rows.Add();
                    dgv_Main.Rows[dgv_Main.Rows.Count - 1].Cells["name_Column"].Value = fileInfo.Name;
                    dgv_Main.Rows[dgv_Main.Rows.Count - 1].Cells["size_Column"].Value = fileInfo.Length;
                    dgv_Main.Rows[dgv_Main.Rows.Count - 1].Cells["type_Column"].Value = fileInfo.Extension;
                    dgv_Main.Rows[dgv_Main.Rows.Count - 1].Cells["modifyTime_Column"].Value = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
                    dgv_Main.Rows[dgv_Main.Rows.Count - 1].Cells["path_Column"].Value = fileInfo.DirectoryName;
                }
            } catch(Exception exc) {
                tsl_ErrorLog.Text = exc.Message;
            }
            tsl_CountTip.Text += "，照片文件：" + dgv_Main.Rows.Count;
        }

        private void cbx_SearchAllDirectory_CheckedChanged(object sender,EventArgs e) {
            save_Config("SearchAllDirectories",cbx_SearchAllDirectory.Checked.ToString());
        }

        private void tbx_searchPattern_TextChanged(object sender,EventArgs e) {
            save_Config("PhotoFileType",tbx_searchPattern.Text);
        }

        private void btn_ReadFile_Click(object sender,EventArgs e) {
            foreach(DataGridViewRow row in dgv_Main.Rows) {
                string fileName = row.Cells["name_Column"].Value.ToString();
                string filePath = row.Cells["path_Column"].Value.ToString();

                ShellObject shellObject = ShellObject.FromParsingName(filePath + "\\" + fileName);
                DateTime dateTime = shellObject.Properties.System.ItemDate.Value.Value;

                row.Cells["createTime_Column"].Value = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                string createTime = row.Cells["createTime_Column"].Value.ToString();
                string modifyTime = row.Cells["modifyTime_Column"].Value.ToString();
                if(createTime.Equals(modifyTime)==false) {
                    row.Cells["createTime_Column"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void dgv_Main_CellClick(object sender,DataGridViewCellEventArgs e) {
            if(e.RowIndex < 0) {
                return;
            }

            directory_ContextMenuStrip.Show(dgv_Main,dgv_Main.PointToClient(MousePosition));
            toolMenu_ImageName.Text = dgv_Main.Rows[e.RowIndex].Cells["name_Column"].Value.ToString();
        }
    }
}
