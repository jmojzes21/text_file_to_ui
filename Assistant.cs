namespace TextFileToUi {
    public class Assistant : User {

        public string Department = "";

        public Assistant() : base(UserRole.Assistant) {}

        public override string ToString() {
            return $"{base.ToString()}, {Department}";
        }

    }
}
