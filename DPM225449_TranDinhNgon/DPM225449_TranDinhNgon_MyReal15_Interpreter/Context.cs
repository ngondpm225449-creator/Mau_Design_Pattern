using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_MyReal15_Interpreter
{
    public class Context
    {
        public string Input { get; set; }
        public double Output { get; set; }

        public Context(string input)
        {
            Input = input;
            Output = 0;
        }
    }
}
