
using System;
using System.Collections.Generic;
using System.IO;

namespace TextFileToUi {
    public class UserFileReader {

        private string path;

        public UserFileReader(string path) {
            this.path = path;
        }

        public Dictionary<string, string> ReadUser() {

            var map = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++) {
                
                string line = lines[i];
                string[] parts = line.Split('=');

                if(parts.Length != 2) {
                    throw new Exception("Invalid file format");
                }

                string key = parts[0];
                string value = parts[1];

                map.Add(key, value);

            }

            return map;

        }

    }
}
