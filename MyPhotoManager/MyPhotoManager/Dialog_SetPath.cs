using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoManager {
    public partial class Dialog_SetPath:Form {
        public Dialog_SetPath() {
            InitializeComponent();
        }

        private void Dialog_SetPath_Load(object sender,EventArgs e) {

        }

        private void btn_ChooseSavePath_Click(object sender,EventArgs e) {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                tbx_SavaPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
