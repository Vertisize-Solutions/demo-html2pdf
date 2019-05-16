using System;
using System.Collections.Generic;
using System.Text;

namespace Constant.Lib
{
    public class LibraryModel
    {
        public LibraryModel(string name, string version, string site, string license)
        {
            Name = name;
            Version = version;
            Website = site;
            License = license;
        }

        public string Name { get; set; }
        public string Version { get; set; }
        public string Website { get; set; }
        public string License { get; set; }
    }
}
