namespace FunctionExtremum
{
    public class Functions
    {
        public delegate double Function(double x);

        public static double Sine(double x) => Math.Sin(x);

        public static double Cubic(double x) => Math.Pow(x, 3);

        public static double Square(double x) => Math.Pow(x, 2);

        public static double SquareTrinomials(double x) => Math.Pow(x, 2) - 30 * x + 5;
    }
}