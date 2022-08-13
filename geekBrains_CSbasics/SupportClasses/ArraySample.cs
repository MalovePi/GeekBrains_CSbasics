using System;
using System.Linq;

namespace SupportClasses
{
    public class ArraySample
    {
        Random random = new Random();
        private int[] _arrayInteger;

        public int this[int index]
        {
            get => _arrayInteger[index];
            set => _arrayInteger[index] = value;
        }

        /// <summary>Cвойство возвращает сумму элементов массива.</summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _arrayInteger.Length; i++)
                {
                    sum += _arrayInteger[i];
                }
                return sum;
            }
        }

        /// <summary>Cвойство возвращает количество максимальных одинаковых элементов массива.</summary>
        public int MaxCount
        {
            get
            {
                int max = _arrayInteger[0];
                int countMax = 0;
                for (int i = 0; i < _arrayInteger.Length; i++)
                {
                    if (max < _arrayInteger[i])
                    {
                        max = _arrayInteger[i];
                        countMax = 0;
                    }                        
                    if(max == _arrayInteger[i])
                        countMax++;                 
                }
                return countMax;
            }
        }

        public int Length
        {
            get => _arrayInteger.Length;
        }

        public ArraySample(int[] array)
        {
            _arrayInteger = array;
        }

        /// <summary>
        /// Конструктор, создающий массив заполненный случайными числами от 10 до 100.
        /// </summary>
        /// <param name="sizeArray">Размер массива</param>
        public ArraySample(int sizeArray)
        {
            _arrayInteger = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                _arrayInteger[i] = random.Next(10, 100);
            }
        }

        /// <summary>
        /// Конструктор, создающий массив заданной размерности и 
        /// заполняющий числами от начального значения, с заданным шагом. </summary>
        /// <param name="sizeArray">Размер массива</param>
        /// <param name="startValue">Начальное значение</param>
        /// <param name="step">Шаг</param>
        public ArraySample(int sizeArray,int startValue, int step)
        {
            _arrayInteger = new int[sizeArray];
            _arrayInteger[0] = startValue;
            int firstStep = step;
            for (int i = 1; i < sizeArray; i++)
            {
                _arrayInteger[i] = startValue + step;
                step += firstStep;
            }
        }

        public void ShowArrayInteger()
        {
            foreach (var array in _arrayInteger)
            {
                Console.Write($"{array}\t");
            }
            Console.WriteLine();
        }

        public ArraySample ReverseSignOfElements(ref ArraySample sourceArray, out ArraySample destinationArray)
        {
            int[] copyArray = new int[_arrayInteger.Length];
            for (int i = 0; i < _arrayInteger.Length; i++)
            {
                //_arrayInteger[i] *= -1;
                copyArray[i] = _arrayInteger[i] * -1;  
            }
            destinationArray = new ArraySample(copyArray);
            return destinationArray;
        }

        //Variant_01
        //public ArraySample ReverseSignOfElements()
        //{
        //    int[] destinationArray = new int[_arrayInteger.Length];
        //    for (int i = 0; i < _arrayInteger.Length; i++)
        //    {
        //        destinationArray[i] = _arrayInteger[i] * -1;
        //    }
        //    return new ArraySample(destinationArray);
        //}
    }
}
