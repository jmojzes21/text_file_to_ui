
namespace TextFileToUi {
    public abstract class User {

        public string Name;
        public string Surname;
        public int BirthYear;
        public string BirthCity;
        public string Faculty;

        private UserRole role;

        public User(UserRole role) {
            this.role = role;
        }

        UserRole GetRole() {
            return role;
        }

        string FullName() {
            return $"${Name} ${Surname}";
        }
        
    }

}
