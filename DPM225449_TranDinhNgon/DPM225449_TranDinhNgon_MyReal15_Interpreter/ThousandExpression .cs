using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_MyReal15_Interpreter
{
    public class ThousandExpression : Expression
    {
        public override string Symbol() => "K";
        public override double Multiplier() => 1_000;
    }
}
