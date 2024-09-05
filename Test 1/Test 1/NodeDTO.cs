using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class NodeDTO
    {
        //this the type for basic tipe
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public string[] Defenses { get; set; }
    }
}
