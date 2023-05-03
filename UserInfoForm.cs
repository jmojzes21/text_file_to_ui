using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileToUi
{
    public partial class UserInfoForm : Form
    {

        private UserInfoController controller;
        public UserInfoForm()
        {
            InitializeComponent();
            controller = new UserInfoController(this);
        }

        private void btnOpen_Click(object sender, EventArgs e) {

            DialogResult result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK) return;

            string path = openFileDialog.FileName;
            try {
                controller.LoadUser(path);
            } catch (Exception) {
                MessageBox.Show($"Can't load user from ${path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
