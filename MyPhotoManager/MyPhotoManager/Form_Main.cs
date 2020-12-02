using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoManager {
    public partial class Form_Main:Form {
        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender,EventArgs e) {
            init_Disk();
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
            tvw_DirectoryTree.Nodes.Clear();
            string diskPath = cbx_Disk.Text;
            if(Directory.Exists(diskPath) == false) {
                return;
            }
            string[] directories = Directory.GetDirectories(diskPath);
            foreach(string dirPath in directories) {
                DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                bool isHidden = false;
                bool isDirectory = false;

                //判断是否隐藏文件夹
                if((dirInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) {
                    isHidden = true;
                }
                if(isHidden == true) {
                    continue;
                }

                // 判断类型是文件或文件夹
                if((dirInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory) {
                    isDirectory = true;
                }

                TreeNode treeNode = new TreeNode();

                treeNode.Name = dirInfo.FullName;
                treeNode.Text = dirInfo.Name;
                treeNode.ImageIndex = isDirectory ? 1 : 0;
                treeNode.SelectedImageIndex = treeNode.ImageIndex;

                tvw_DirectoryTree.Nodes.Add(treeNode);
            }
        }

        private void tvw_DirectoryTree_AfterSelect(object sender,TreeViewEventArgs e) {
            loadPhotoByDirectory(e.Node.Name);
        }

        private void loadPhotoByDirectory(string dirPath) {
            
        }
    }
}
