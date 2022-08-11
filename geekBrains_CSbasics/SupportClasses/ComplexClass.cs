using System;

namespace SupportClasses
{
    public class ComplexClass
    {
        /// <summary>
        /// Вещественная часть комплексного числа
        /// </summary>
        public double Re { get; private set; }
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double Im { get; private set; }

        public ComplexClass() { }
        public ComplexClass(double re, double im)
        {
            Re = re;
            Im = im;
        }

        /// <summary>
        /// Вычисление суммы комплексных чисел
        /// </summary>
        private static ComplexClass Sum(ComplexClass augent, ComplexClass addend)
        {
            ComplexClass sum = new ComplexClass
            {
                Re = augent.Re + addend.Re,
                Im = augent.Im + addend.Im
            };
            return sum;
        }

        /// <summary>
        /// Вычисление разности комплексных чисел
        /// </summary>
        private static ComplexClass Difference(ComplexClass minuend, ComplexClass subtrahend)
        {
            ComplexClass difference = new ComplexClass
            {
                Re = minuend.Re - subtrahend.Re,
                Im = minuend.Im - subtrahend.Im
            };
            return difference;
        }

        /// <summary>
        /// Вычисление произведения комплексных чисел
        /// </summary>
        private static ComplexClass Product(ComplexClass multiplicand, ComplexClass multipler)
        {
            ComplexClass product = new ComplexClass()
            {
                Re = multiplicand.Re * multipler.Re - multiplicand.Im * multipler.Im,
                Im = multiplicand.Im * multipler.Re + multiplicand.Re * multipler.Im
            };
            return product;
        }

        /// <summary>
        /// Вычисление частного комплексных чисел
        /// </summary>
        private static ComplexClass Quotient(ComplexClass dividend, ComplexClass divisor)
        {
            ComplexClass quotient = new ComplexClass()
            {
                Re = (dividend.Re * divisor.Re + dividend.Im * divisor.Im) / (Math.Pow(divisor.Re, 2) + Math.Pow(divisor.Im, 2)),
                Im = (dividend.Im * divisor.Re - dividend.Re * divisor.Im) / (Math.Pow(divisor.Re, 2) + Math.Pow(divisor.Im, 2))
            };
            return quotient;
        }

        public static ComplexClass operator +(ComplexClass firstZ, ComplexClass secondZ) => Sum(firstZ, secondZ);
        public static ComplexClass operator -(ComplexClass firstZ, ComplexClass secondZ) => Difference(firstZ, secondZ);
        public static ComplexClass operator *(ComplexClass firstZ, ComplexClass secondZ) => Product(firstZ, secondZ);
        public static ComplexClass operator /(ComplexClass firstZ, ComplexClass secondZ) => Quotient(firstZ, secondZ);

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }
    }
}
