using System;
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
            } catch (Exception ex) {
                MessageBox.Show($"Can't load user from \"{path}\"\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
