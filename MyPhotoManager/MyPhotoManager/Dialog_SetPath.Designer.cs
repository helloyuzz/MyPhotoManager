namespace MyPhotoManager {
    partial class Dialog_SetPath {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_SavaPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_ChooseSavePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_PreFix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_SearchAllDirectory = new System.Windows.Forms.CheckBox();
            this.tbx_searchPattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标文件夹：";
            // 
            // tbx_SavaPath
            // 
            this.tbx_SavaPath.Location = new System.Drawing.Point(164, 46);
            this.tbx_SavaPath.Name = "tbx_SavaPath";
            this.tbx_SavaPath.ReadOnly = true;
            this.tbx_SavaPath.Size = new System.Drawing.Size(512, 25);
            this.tbx_SavaPath.TabIndex = 0;
            // 
            // btn_ChooseSavePath
            // 
            this.btn_ChooseSavePath.Location = new System.Drawing.Point(682, 44);
            this.btn_ChooseSavePath.Name = "btn_ChooseSavePath";
            this.btn_ChooseSavePath.Size = new System.Drawing.Size(94, 28);
            this.btn_ChooseSavePath.TabIndex = 1;
            this.btn_ChooseSavePath.Text = "浏览...";
            this.btn_ChooseSavePath.UseVisualStyleBackColor = true;
            this.btn_ChooseSavePath.Click += new System.EventHandler(this.btn_ChooseSavePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件名前缀：";
            // 
            // tbx_PreFix
            // 
            this.tbx_PreFix.Location = new System.Drawing.Point(164, 90);
            this.tbx_PreFix.Name = "tbx_PreFix";
            this.tbx_PreFix.Size = new System.Drawing.Size(288, 25);
            this.tbx_PreFix.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "检索类型：";
            // 
            // cbx_SearchAllDirectory
            // 
            this.cbx_SearchAllDirectory.AutoSize = true;
            this.cbx_SearchAllDirectory.Location = new System.Drawing.Point(164, 181);
            this.cbx_SearchAllDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_SearchAllDirectory.Name = "cbx_SearchAllDirectory";
            this.cbx_SearchAllDirectory.Size = new System.Drawing.Size(134, 19);
            this.cbx_SearchAllDirectory.TabIndex = 4;
            this.cbx_SearchAllDirectory.Text = "检索下级文件夹";
            this.cbx_SearchAllDirectory.UseVisualStyleBackColor = true;
            // 
            // tbx_searchPattern
            // 
            this.tbx_searchPattern.Location = new System.Drawing.Point(164, 134);
            this.tbx_searchPattern.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_searchPattern.Name = "tbx_searchPattern";
            this.tbx_searchPattern.Size = new System.Drawing.Size(288, 25);
            this.tbx_searchPattern.TabIndex = 3;
            this.tbx_searchPattern.Text = "*.bmp|*.gif|*.png|*.jpg|*.jpeg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "检索选项：";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(254, 373);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 39);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "保存设置(&S)";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(373, 373);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "取消(&C)";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Dialog_SetPath
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(788, 453);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_searchPattern);
            this.Controls.Add(this.cbx_SearchAllDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_PreFix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ChooseSavePath);
            this.Controls.Add(this.tbx_SavaPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_SetPath";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置目标文件夹";
            this.Load += new System.EventHandler(this.Dialog_SetPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_SavaPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_ChooseSavePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_PreFix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_SearchAllDirectory;
        private System.Windows.Forms.TextBox tbx_searchPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}