using System;

namespace SupportClasses
{
    public class InputHelpers
    {
        /// <summary>
        /// Конвертор вводимого значения пользователем. Из string в double.
        /// </summary>
        /// <param name="text">Текст вывода в консоль</param>
        /// <returns></returns>
        public static double UserInputConverter(string text)
        {
            while (true)
            {
                Console.Write(text);
                string str = Console.ReadLine();
                double result;

                if (double.TryParse(str, out result))
                    return result;
                else
                {
                    Console.WriteLine("Неправильный фармат числа. Попробуй еще раз!");
                    Console.WriteLine("\a");
                }                    
            }
        }
    }
}
