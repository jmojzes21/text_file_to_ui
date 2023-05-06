
namespace TextFileToUi {
    public class Student : User {

        public string FavoriteCourse = "";

        public Student() : base(UserRole.Student) {}

        public override string ToString() {
            return $"{base.ToString()}, {FavoriteCourse}";
        }

    }
}
