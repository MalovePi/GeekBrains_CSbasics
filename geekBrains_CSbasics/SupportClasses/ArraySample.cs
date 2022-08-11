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

        public ArraySample(int[] array)
        {
            _arrayInteger = array;
        }

        public ArraySample(int sizeArray)
        {
            _arrayInteger = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                _arrayInteger[i] = random.Next(0, 100);
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
            for (int i = 0; i < _arrayInteger.Length; i++)
            {
                Console.Write($"{_arrayInteger[i]}\t");                
            }
            Console.WriteLine();
        }
    }
}
