
namespace TextFileToUi {
    public class Student : User {

        public static string FavoriteCourseKeyName = "Najdraži kolegij";

        public string FavoriteCourse { get; set; }

        public Student() : base(UserRole.Student) {}

        public override string ToString() {
            return $"{base.ToString()}, {FavoriteCourse}";
        }

    }
}
