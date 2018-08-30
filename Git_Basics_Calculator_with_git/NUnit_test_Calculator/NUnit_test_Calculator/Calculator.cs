using System;

namespace NUnit_test_Calculator
{
    public class Calculator
    {
        public double Add(double A, double B)
        {
            return A + B;
        }

        public double Subtract(double A, double B)
        {
            return A - B;
        }

        public double Multiply(double A, double B)
        {
            return A * B;
        }

        public double Power(double A, double B)
        {
            return Math.Pow(A,B);
        }
    }
}
