

namespace TextFileToUi {
    public class UserDisplayer {

        private UserInfoForm form;

        public UserDisplayer(UserInfoForm form) {
            this.form = form;
        }

        public void DisplayUser(User user) {

            form.txtFullName.Text = user.FullName();
            form.txtBirthYear.Text = user.BirthYear.ToString();
            form.txtBirthCity.Text = user.BirthCity.ToString();
            form.txtFaculty.Text = user.Faculty.ToString();
            form.txtRole.Text = user.RoleAsString();
            
            switch(user.Role) {
                case UserRole.Student:
                    form.lblRoleSpecificAttr.Text = "Favorite course";
                    form.txtRoleSpecificAttr.Text = User.AsStudent(user).FavoriteCourse;
                    break;
                case UserRole.Assistant:
                    form.lblRoleSpecificAttr.Text = "Department";
                    form.txtRoleSpecificAttr.Text = User.AsAssistant(user).Department;
                    break;
            }

        }

    }
}
