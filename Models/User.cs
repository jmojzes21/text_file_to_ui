
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Windows.Forms;

namespace TextFileToUi {
    public abstract class User {

        public static string FirstNameKeyName = "Ime";
        public static string LastNameKeyName = "Prezime";
        public static string BirthYearKeyName = "Godina rođenja";
        public static string BirthCityKeyName = "Grad rođenja";
        public static string FacultyKeyName = "Fakultet";
        public static string RoleKeyName = "Uloga";

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string BirthCity { get; set; }
        public string Faculty { get; set; }
        public UserRole Role { get; }

        public User(UserRole role) {
            Role = role;
        }

        public string FullName() {
            return $"{FirstName} {LastName}";
        }

        public override string ToString() {
            return $"{FirstName}, {LastName}, {BirthYear}, {BirthCity}, {Faculty}";
        }

        public string RoleAsString() {
            switch(Role) {
                case UserRole.Student:
                    return "student";
                case UserRole.Assistant:
                    return "asistent";
            }
            return null;
        }

        public static Student AsStudent(User user) {
            return (Student)user;
        }

        public static Assistant AsAssistant(User user) {
            return (Assistant)user;
        }

    }

}
