using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BasicCalculator
    {
        public double Calculate(string firstString, ref int param)
        {
            string[] elements = firstString.Split(' ');
            double result;
            string first = elements[param++];

            if (double.TryParse(first, out result))
            {
                return result;
            }

            return BasicOperations(first, Calculate(firstString, ref param), Calculate(firstString, ref param));
        }

        private double BasicOperations(string expression, double first, double second)
        {
            switch(expression)
            {
                case "+": return first + second;
                case "-": return first - second;
                case "*": return first * second;
                case "/": return first / second;
                default: return 0;
            }
        }
    }
}
