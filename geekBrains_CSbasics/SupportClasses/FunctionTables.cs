using System;

namespace SupportClasses
{
    public class FunctionTables
    {
        public delegate double Function(double a, double x);

        public static double Squaring(double a, double x) => a * Math.Pow(x, 2);

        public static double Sin(double a, double x) => a * Math.Sin(x);
    }
}
