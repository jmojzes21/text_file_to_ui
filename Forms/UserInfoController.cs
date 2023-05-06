
using System;
using System.Collections.Generic;
using TextFileToUi.Utils;

namespace TextFileToUi {
    public class UserInfoController {

        private static string FileAccessCounterKeyName = "Datoteci pristupljeno puta";

        private readonly UserInfoForm form;

        public UserInfoController(UserInfoForm form) {
            this.form = form;
        }

        public void LoadUser(string path) {

            UserFileReader reader = new UserFileReader(path);
            var map = reader.ReadUser();

            UserParser parser = new UserParser();
            User user = parser.Parse(map);

            IncrementFileAccessCounter(map, user, path);

            UserDisplayer displayer = new UserDisplayer(form);
            displayer.DisplayUser(user);

        }

        private void IncrementFileAccessCounter(Dictionary<string, string> map, User user, string path) {

            if(map.ContainsKey(FileAccessCounterKeyName) == false) {
                throw new Exception($"Invalid file format, can't find value for key {FileAccessCounterKeyName}");
            }

            int counter = int.Parse(map[FileAccessCounterKeyName]);
            counter++;

            UserSerializer userSerializer = new UserSerializer();
            var lines = userSerializer.SerializeUser(user);

            lines.Add($"{FileAccessCounterKeyName}={counter}");

            UserFileWriter writer = new UserFileWriter(path);
            writer.WriteUser(lines.ToArray());

        }

    }
}
