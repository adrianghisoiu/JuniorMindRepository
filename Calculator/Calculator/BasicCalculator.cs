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

            return BasicOperations(firstString, ref param, first);
        }

        private double BasicOperations(string firstString, ref int param, string first)
        {
            if (first == "+")
                return Calculate(firstString, ref param) + Calculate(firstString, ref param);
            if (first == "-")
                return Calculate(firstString, ref param) - Calculate(firstString, ref param);
            if (first == "*")
                return Calculate(firstString, ref param) * Calculate(firstString, ref param);
            if (first == "/")
                return Calculate(firstString, ref param) / Calculate(firstString, ref param);
            else
                return 0;
        }
    }
}
