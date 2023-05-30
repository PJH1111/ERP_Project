using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace F_Final_Project
{
    public class User
    {
        public int id { get; set; } // 0
        public string name { get; set; } //1
        public string pw { get; set; } // 2
        public int authority { get; set; } // 3
        public string team { get; set; }
        public string JG { get; set; }
        public int birth { get; set; }
        public string addr { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int DoE { get; set; }
        public byte[] img { get; set; }
    }
}
