using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportStructs
{
    public struct ComplexStruct
    {
        /// <summary>
        /// Вещественная часть комплексного числа
        /// </summary>
        private double _re;
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double _im;

        public ComplexStruct(double re, double im)
        {
            _re = re;
            _im = im;            
        }

        /// <summary>
        /// Вычисление суммы комплексных чисел
        /// </summary>
        private ComplexStruct Plus(ComplexStruct secondZ)
        {
            ComplexStruct firstZ;
            firstZ._re = _re + secondZ._re;
            firstZ._im = _im + secondZ._im;
            return firstZ; 
        }

        /// <summary>
        /// Вычисление разности комплексных чисел
        /// </summary>
        private ComplexStruct Minus(ComplexStruct secondZ)
        {
            ComplexStruct firstZ;
            firstZ._re = _re - secondZ._re;
            firstZ._im = _im - secondZ._im;
            return firstZ;
        }

        public static ComplexStruct operator +(ComplexStruct firstZ, ComplexStruct secondZ) => firstZ.Plus(secondZ);
        public static ComplexStruct operator -(ComplexStruct firstZ, ComplexStruct secondZ) => firstZ.Minus(secondZ);

        public override string ToString()
        {
            return $"{_re} + {_im}i";
        }
    }
}
