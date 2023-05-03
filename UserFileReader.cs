
using System.IO;

namespace TextFileToUi {
    internal class UserFileReader {

        private string path;

        public UserFileReader(string path) {
            this.path = path;
        }

        public string[] ReadUser() {
            return File.ReadAllLines(path);
        }

    }
}
