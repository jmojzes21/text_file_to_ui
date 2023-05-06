
using System;

namespace TextFileToUi {
    public class UserParser {

        public UserParser() {}

        public User Parse(string[] source) {

            string name = ParseLine(source[0], "Ime");
            string surname = ParseLine(source[1], "Prezime");
            int birthYear = int.Parse(ParseLine(source[2], "Godina rođenja"));
            string birthCity = ParseLine(source[3], "Grad rođenja");
            string faculty = ParseLine(source[4], "Fakultet");

            string roleAsString = ParseLine(source[5], "Uloga");
            UserRole role = ParseRole(roleAsString);

            User user = null;

            switch(role) {
                case UserRole.Student:

                    user = new Student();

                    string course = ParseLine(source[6], "Najdraži kolegij");
                    User.asStudent(user).FavoriteCourse = course;

                    break;

                case UserRole.Assistant:

                    user = new Assistant();

                    string dep = ParseLine(source[6], "Katedra");
                    User.asAssistant(user).Department = dep;

                    break;
            }

            user.Name = name;
            user.Surname = surname;
            user.BirthYear = birthYear;
            user.BirthCity = birthCity;
            user.Faculty = faculty;

            return user;

        }

        private string ParseLine(string source, string prefix) {

            if(source.StartsWith(prefix) == false) {
                throw new Exception("Invalid file format");
            }

            string[] temp = source.Split('=');
            if(temp.Length != 2 ) {
                throw new Exception("Invalid file format");
            }

            return temp[1];

        }

        private UserRole ParseRole(string source) {
            switch(source.ToLower()) {
                case "student":
                    return UserRole.Student;
                case "asistent":
                    return UserRole.Assistant;
                default:
                    throw new Exception("Invalid file format");
            }
            
        }

    }
}
