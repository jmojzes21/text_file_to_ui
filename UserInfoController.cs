
using System;
using System.Windows.Forms;

namespace TextFileToUi {
    public class UserInfoController {

        private UserInfoForm form;

        public UserInfoController(UserInfoForm form) {
            this.form = form;
        }

        public void LoadUser(string path) {

            UserFileReader reader = new UserFileReader(path);
            string[] lines = reader.ReadUser();

            if(lines.Length < 8) {
                throw new Exception("Invalid file format");
            }

            IncrementFileAccessCounter(lines, path);

            UserParser parser = new UserParser();
            User user = parser.Parse(lines);

            UserDisplayer displayer = new UserDisplayer(form);
            displayer.DisplayUser(user);

        }

        private void IncrementFileAccessCounter(string[] lines, string path) {

            const int lineIndex = 7;
            string line = lines[lineIndex];

            if(line.StartsWith("Datoteci pristupljeno puta") == false) {
                throw new Exception("Can't increment file access counter");
            }

            string[] temp = line.Split('=');
            int counter = int.Parse(temp[1]);
            counter++;

            lines[lineIndex] = $"Datoteci pristupljeno puta={counter}";

            UserFileWriter writer = new UserFileWriter(path);
            writer.WriteUser(lines);

        }

    }
}
