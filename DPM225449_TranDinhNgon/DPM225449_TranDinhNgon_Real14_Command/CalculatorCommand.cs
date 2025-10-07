using System;

namespace Command.RealWorld
{
    public class CalculatorCommand : Command
    {
        char @operator;
        int operand;
        Calculator calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public char Operator
        {
            set { @operator = value; }
        }

        public int Operand
        {
            set { operand = value; }
        }

        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        private char Undo(char @operator)
        {
            return @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("@operator"),
            };
        }
    }
}