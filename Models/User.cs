
using System.Text;

namespace TextFileToUi {
    public abstract class User {

        public string Name = "";
        public string Surname = "";
        public int BirthYear = 0;
        public string BirthCity = "";
        public string Faculty = "";

        private readonly UserRole role;

        public User(UserRole role) {
            this.role = role;
        }

        public UserRole GetRole() {
            return role;
        }

        public string FullName() {
            return $"{Name} {Surname}";
        }

        public override string ToString() {
            return $"{Name}, {Surname}, {BirthYear}, {BirthCity}, {Faculty}";
        }

        public static Student asStudent(User user) {
            return (Student)user;
        }

        public static Assistant asAssistant(User user) {
            return (Assistant)user;
        }

    }

}
