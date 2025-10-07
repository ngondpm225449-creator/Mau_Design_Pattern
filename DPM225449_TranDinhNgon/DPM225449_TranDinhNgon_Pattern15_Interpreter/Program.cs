using System;
using System.Collections.Generic;
namespace DPM225449_TranDinhNgon_Pattern15_Interpreter;
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();
            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            // Wait for user
            Console.ReadKey();
        }
    }

