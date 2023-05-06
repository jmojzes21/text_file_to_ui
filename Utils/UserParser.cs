
using System;
using System.Collections.Generic;

namespace TextFileToUi {
    public class UserParser {

        public UserParser() {}

        public User Parse(Dictionary<string, string> source) {

            string firstName = GetValueFromMap(source, User.FirstNameKeyName);
            string lastName = GetValueFromMap(source, User.LastNameKeyName);
            int birthYear = int.Parse(GetValueFromMap(source, User.BirthYearKeyName));
            string birthCity = GetValueFromMap(source, User.BirthCityKeyName);
            string faculty = GetValueFromMap(source, User.FacultyKeyName);

            string roleAsString = GetValueFromMap(source, User.RoleKeyName);
            UserRole role = ParseRole(roleAsString);

            User user = null;

            switch (role) {
                case UserRole.Student:

                    user = new Student();

                    string course = GetValueFromMap(source, Student.FavoriteCourseKeyName);
                    User.AsStudent(user).FavoriteCourse = course;

                    break;

                case UserRole.Assistant:

                    user = new Assistant();

                    string dep = GetValueFromMap(source, Assistant.DepartmentKeyName);
                    User.AsAssistant(user).Department = dep;

                    break;
            }

            user.FirstName = firstName;
            user.LastName = lastName;
            user.BirthYear = birthYear;
            user.BirthCity = birthCity;
            user.Faculty = faculty;

            return user;
            
        }

        private string GetValueFromMap(Dictionary<string, string> map, string key) {
            if(map.ContainsKey(key) == false) {
                throw new Exception($"Invalid file format, can't find value for key {key}");
            }
            return map[key];
        }

        private UserRole ParseRole(string role) {
            switch(role.ToLower()) {
                case "student":
                    return UserRole.Student;
                case "asistent":
                    return UserRole.Assistant;
                default:
                    throw new Exception($"Invalid file format, unknown role {role}");
            }
            
        }

    }
}
