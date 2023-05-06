namespace TextFileToUi {
    public class Assistant : User {

        public static string DepartmentKeyName = "Katedra";

        public string Department { get; set; }

        public Assistant() : base(UserRole.Assistant) {}

        public override string ToString() {
            return $"{base.ToString()}, {Department}";
        }

    }
}
