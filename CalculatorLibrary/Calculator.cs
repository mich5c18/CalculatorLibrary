using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            double add = 0;
            add = v1 + v2;

            return add;
        }

        public static double Subtract(double v1, double v2)
        {
            double subtract = 0;
            subtract = v1 - v2;

            return subtract;
        }

        public static double Multiply(double v1, double v2)
        {
            double multiply = 0;
            multiply = v1 * v2;

            return multiply;
        }

        public static double Divide(double v1, double v2)
        {
            double divide = 0;
            divide = v1 / v2;

            return divide;
        }

        public static double Sum(double[] numbers)
        {
                double sum = 0;

                for (int i = 0; i < numbers.Length; i = i + 1)
                {
                    sum = sum + numbers[i];
                }

                return sum;
        }

        public static double Minimum(double[] numbers)
        {
            double min = numbers[0];

            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static double Maximum(double[] numbers)
        {
            double max = numbers[0];

            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public static double Average(double[] numbers)
        {
            double average = 0;

            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                average = average + numbers[i];
            }

            return average / numbers.Length;
        }
    }
}
