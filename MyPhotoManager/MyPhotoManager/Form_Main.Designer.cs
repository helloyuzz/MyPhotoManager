namespace MyPhotoManager
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Disk = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvw_DirectoryTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_searchPattern = new System.Windows.Forms.TextBox();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.cbx_SearchAllDirectory = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu_SetPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsl_CountTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_ErrorLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.directory_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenu_ImageName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenu_OpenDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.image_Column = new System.Windows.Forms.DataGridViewImageColumn();
            this.name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyTime_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.directory_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_Disk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 60);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "磁盘：";
            // 
            // cbx_Disk
            // 
            this.cbx_Disk.FormattingEnabled = true;
            this.cbx_Disk.Location = new System.Drawing.Point(73, 19);
            this.cbx_Disk.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Disk.Name = "cbx_Disk";
            this.cbx_Disk.Size = new System.Drawing.Size(248, 23);
            this.cbx_Disk.TabIndex = 0;
            this.cbx_Disk.SelectedIndexChanged += new System.EventHandler(this.cbx_Disk_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvw_DirectoryTree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel2.Size = new System.Drawing.Size(373, 650);
            this.panel2.TabIndex = 1;
            // 
            // tvw_DirectoryTree
            // 
            this.tvw_DirectoryTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_DirectoryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw_DirectoryTree.ImageIndex = 0;
            this.tvw_DirectoryTree.ImageList = this.imageList1;
            this.tvw_DirectoryTree.Location = new System.Drawing.Point(4, 4);
            this.tvw_DirectoryTree.Margin = new System.Windows.Forms.Padding(4);
            this.tvw_DirectoryTree.Name = "tvw_DirectoryTree";
            this.tvw_DirectoryTree.SelectedImageIndex = 0;
            this.tvw_DirectoryTree.Size = new System.Drawing.Size(369, 642);
            this.tvw_DirectoryTree.TabIndex = 0;
            this.tvw_DirectoryTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_DirectoryTree_NodeMouseClick);
            this.tvw_DirectoryTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_DirectoryTree_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "html.ico");
            this.imageList1.Images.SetKeyName(1, "folder.ico");
            this.imageList1.Images.SetKeyName(2, "ai.ico");
            this.imageList1.Images.SetKeyName(3, "avi.ico");
            this.imageList1.Images.SetKeyName(4, "doc.ico");
            this.imageList1.Images.SetKeyName(5, "fla.ico");
            this.imageList1.Images.SetKeyName(6, "jpg.ico");
            this.imageList1.Images.SetKeyName(7, "mov.ico");
            this.imageList1.Images.SetKeyName(8, "pdf.ico");
            this.imageList1.Images.SetKeyName(9, "png.ico");
            this.imageList1.Images.SetKeyName(10, "psd.ico");
            this.imageList1.Images.SetKeyName(11, "xls.ico");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1424, 710);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 710);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_Main);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1045, 650);
            this.panel5.TabIndex = 1;
            // 
            // dgv_Main
            // 
            this.dgv_Main.AllowUserToAddRows = false;
            this.dgv_Main.AllowUserToDeleteRows = false;
            this.dgv_Main.AllowUserToResizeRows = false;
            this.dgv_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Main.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image_Column,
            this.name_Column,
            this.size_Column,
            this.type_Column,
            this.createTime_Column,
            this.modifyTime_Column,
            this.path_Column,
            this.prevName_Column});
            this.dgv_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Main.Location = new System.Drawing.Point(0, 0);
            this.dgv_Main.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Main.MultiSelect = false;
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.RowHeadersVisible = false;
            this.dgv_Main.RowTemplate.Height = 23;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(1045, 650);
            this.dgv_Main.TabIndex = 0;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Main_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_ReadFile);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbx_searchPattern);
            this.panel4.Controls.Add(this.btn_Rename);
            this.panel4.Controls.Add(this.cbx_SearchAllDirectory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 60);
            this.panel4.TabIndex = 0;
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReadFile.Location = new System.Drawing.Point(814, 11);
            this.btn_ReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(100, 38);
            this.btn_ReadFile.TabIndex = 4;
            this.btn_ReadFile.Text = "读取文件";
            this.btn_ReadFile.UseVisualStyleBackColor = true;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "文件类型：";
            // 
            // tbx_searchPattern
            // 
            this.tbx_searchPattern.Location = new System.Drawing.Point(281, 18);
            this.tbx_searchPattern.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_searchPattern.Name = "tbx_searchPattern";
            this.tbx_searchPattern.Size = new System.Drawing.Size(288, 25);
            this.tbx_searchPattern.TabIndex = 2;
            this.tbx_searchPattern.Text = "*.bmp|*.gif|*.png|*.jpg|*.jpeg";
            this.tbx_searchPattern.TextChanged += new System.EventHandler(this.tbx_searchPattern_TextChanged);
            // 
            // btn_Rename
            // 
            this.btn_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Rename.Location = new System.Drawing.Point(929, 11);
            this.btn_Rename.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(100, 38);
            this.btn_Rename.TabIndex = 1;
            this.btn_Rename.Text = "批量转换";
            this.btn_Rename.UseVisualStyleBackColor = true;
            // 
            // cbx_SearchAllDirectory
            // 
            this.cbx_SearchAllDirectory.AutoSize = true;
            this.cbx_SearchAllDirectory.Location = new System.Drawing.Point(20, 21);
            this.cbx_SearchAllDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_SearchAllDirectory.Name = "cbx_SearchAllDirectory";
            this.cbx_SearchAllDirectory.Size = new System.Drawing.Size(134, 19);
            this.cbx_SearchAllDirectory.TabIndex = 0;
            this.cbx_SearchAllDirectory.Text = "检索下级文件夹";
            this.cbx_SearchAllDirectory.UseVisualStyleBackColor = true;
            this.cbx_SearchAllDirectory.CheckedChanged += new System.EventHandler(this.cbx_SearchAllDirectory_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 710);
            this.label3.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_SetPath});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem1.Text = "文件(&A)";
            // 
            // toolMenu_SetPath
            // 
            this.toolMenu_SetPath.Name = "toolMenu_SetPath";
            this.toolMenu_SetPath.Size = new System.Drawing.Size(216, 26);
            this.toolMenu_SetPath.Text = "设置目标文件夹(&E)";
            this.toolMenu_SetPath.Click += new System.EventHandler(this.toolMenu_SetPath_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem3.Text = "帮助(&B)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 26);
            this.toolStripMenuItem4.Text = "源代码(&P)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 26);
            this.toolStripMenuItem5.Text = "关于(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_CountTip,
            this.tsl_ErrorLog});
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1424, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsl_CountTip
            // 
            this.tsl_CountTip.Name = "tsl_CountTip";
            this.tsl_CountTip.Size = new System.Drawing.Size(0, 17);
            // 
            // tsl_ErrorLog
            // 
            this.tsl_ErrorLog.ForeColor = System.Drawing.Color.Red;
            this.tsl_ErrorLog.Name = "tsl_ErrorLog";
            this.tsl_ErrorLog.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1424, 1);
            this.label1.TabIndex = 5;
            // 
            // directory_ContextMenuStrip
            // 
            this.directory_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.directory_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_ImageName,
            this.toolStripSeparator1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripSeparator2,
            this.toolMenu_OpenDirectory});
            this.directory_ContextMenuStrip.Name = "directory_ContextMenuStrip";
            this.directory_ContextMenuStrip.Size = new System.Drawing.Size(238, 120);
            // 
            // toolMenu_ImageName
            // 
            this.toolMenu_ImageName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolMenu_ImageName.ForeColor = System.Drawing.Color.Green;
            this.toolMenu_ImageName.Image = global::MyPhotoManager.Properties.Resources.pictures;
            this.toolMenu_ImageName.Name = "toolMenu_ImageName";
            this.toolMenu_ImageName.Size = new System.Drawing.Size(237, 26);
            this.toolMenu_ImageName.Text = "文件名称";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItem7.Text = "显示详细信息(&D)";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItem6.Text = "刷新(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // toolMenu_OpenDirectory
            // 
            this.toolMenu_OpenDirectory.Name = "toolMenu_OpenDirectory";
            this.toolMenu_OpenDirectory.Size = new System.Drawing.Size(237, 26);
            this.toolMenu_OpenDirectory.Text = "在资源管理器中打开(&X)";
            this.toolMenu_OpenDirectory.Click += new System.EventHandler(this.toolMenu_OpenDirectory_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MyPhotoManager.Properties.Resources.jpg;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // image_Column
            // 
            this.image_Column.HeaderText = "";
            this.image_Column.Image = global::MyPhotoManager.Properties.Resources.pictures;
            this.image_Column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image_Column.Name = "image_Column";
            this.image_Column.Width = 5;
            // 
            // name_Column
            // 
            this.name_Column.HeaderText = "名称";
            this.name_Column.Name = "name_Column";
            this.name_Column.Width = 66;
            // 
            // size_Column
            // 
            this.size_Column.HeaderText = "大小";
            this.size_Column.Name = "size_Column";
            this.size_Column.Width = 66;
            // 
            // type_Column
            // 
            this.type_Column.HeaderText = "类型";
            this.type_Column.Name = "type_Column";
            this.type_Column.Width = 66;
            // 
            // createTime_Column
            // 
            this.createTime_Column.HeaderText = "创建时间";
            this.createTime_Column.Name = "createTime_Column";
            this.createTime_Column.Width = 96;
            // 
            // modifyTime_Column
            // 
            this.modifyTime_Column.HeaderText = "修改时间";
            this.modifyTime_Column.Name = "modifyTime_Column";
            this.modifyTime_Column.Width = 96;
            // 
            // path_Column
            // 
            this.path_Column.HeaderText = "Path_Column";
            this.path_Column.Name = "path_Column";
            this.path_Column.Width = 124;
            // 
            // prevName_Column
            // 
            this.prevName_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prevName_Column.HeaderText = "实际文件";
            this.prevName_Column.Name = "prevName_Column";
            this.prevName_Column.Width = 96;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPhotoManager - Author:HELLOYUZZ";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.directory_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Disk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView tvw_DirectoryTree;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_SetPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripStatusLabel tsl_CountTip;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbx_SearchAllDirectory;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.TextBox tbx_searchPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip directory_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_OpenDirectory;
        private System.Windows.Forms.ToolStripStatusLabel tsl_ErrorLog;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_ImageName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewImageColumn image_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyTime_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn path_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevName_Column;
    }
}

