using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        private int Value = 0;
        public int MyProperty { get; set; }
        public int MyValue { get { return Value; } set { Value = value; } }
    }
}
