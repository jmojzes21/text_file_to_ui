using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileToUi {
    internal class UserInfoController {

        private UserInfoForm form;

        public UserInfoController(UserInfoForm form) {
            this.form = form;
        }

        public void LoadUser(string path) {

            UserFileReader reader = new UserFileReader(path);
            string[] lines = reader.ReadUser();



        }

    }
}
