using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DPM225449_TranDinhNgon_MyReal15_Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "3M2K"; // 3 triệu + 2 ngàn = 3.002.000
            Context context = new Context(input);

            // Xây dựng parse tree
            List<Expression> tree = new List<Expression>
            {
                new BillionExpression(), // B
                new MillionExpression(), // M
                new ThousandExpression() // K
            };

            // Thực hiện interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{input} = {context.Output:N0} VND");
            Console.ReadKey();
        }
    }
}