using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
