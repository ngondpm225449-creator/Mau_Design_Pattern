﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_Pattern15_Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
