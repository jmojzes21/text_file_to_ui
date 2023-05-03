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
            
        }
    }
}
