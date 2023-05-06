
using System.Collections.Generic;

namespace TextFileToUi.Utils {
    public class UserSerializer {

        public List<string> SerializeUser(User user) {

            var list = new List<string> {
                $"{User.FirstNameKeyName}={user.FirstName}",
                $"{User.LastNameKeyName}={user.LastName}",
                $"{User.BirthYearKeyName}={user.BirthYear}",
                $"{User.BirthCityKeyName}={user.BirthCity}",
                $"{User.FacultyKeyName}={user.Faculty}",
                $"{User.RoleKeyName}={user.RoleAsString()}",
            };

            switch (user.Role) {
                case UserRole.Student:
                    list.Add($"{Student.FavoriteCourseKeyName}={User.AsStudent(user).FavoriteCourse}");
                    break;
                case UserRole.Assistant:
                    list.Add($"{Assistant.DepartmentKeyName}={User.AsAssistant(user).Department}");
                    break;
            }

            return list;
        }

    }
}
