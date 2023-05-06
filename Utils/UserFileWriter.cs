using System.IO;


namespace TextFileToUi {
    public class UserFileWriter {

        private string path;

        public UserFileWriter(string path) {
            this.path = path;
        }

        public void WriteUser(string[] lines) {
            File.WriteAllLines(path, lines);
        }

    }
}
