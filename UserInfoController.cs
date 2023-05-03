
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
