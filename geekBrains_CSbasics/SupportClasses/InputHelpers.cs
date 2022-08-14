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
                    OutputHelpers.TextColor("Ошибка! Неправильный фармат числа. Попробуй еще раз!", ConsoleColor.DarkRed);
                    Console.Write("\a");
                }
            }
        }

        public static double UserInputConverter(out double number, string text)
        {
            while (true)
            {
                Console.Write(text);
                string str = Console.ReadLine();

                if (double.TryParse(str, out number))
                    return number;
                else
                {
                    OutputHelpers.TextColor("Ошибка! Неправильный фармат числа. Попробуй еще раз!", ConsoleColor.DarkRed);
                    Console.Write("\a");
                }
            }
        }

        public static int UserInputConverter(out int number, string text)
        {
            while (true)
            {
                Console.Write(text);
                string str = Console.ReadLine();

                if (int.TryParse(str, out number))
                    return number;
                else
                {
                    OutputHelpers.TextColor("Ошибка! Неправильный фармат числа. Попробуй еще раз!", ConsoleColor.DarkRed);
                    Console.Write("\a");
                }
            }
        }

        /// <summary>
        /// Конвертор вводимого значения пользователем. Из string в int.
        /// </summary>
        /// <param name="text">Текст вывода в консоль</param>
        /// <returns></returns>
        public static int UserInputConverterOutInt(string text = "Пожалуйста введите число: ")
        {
            while (true)
            {
                Console.Write(text);
                string str = Console.ReadLine();
                int result;

                if (int.TryParse(str, out result))
                    return result;
                else
                {
                    OutputHelpers.TextColor("Ошибка! Неправильный фармат числа. Попробуй еще раз!", ConsoleColor.DarkRed);
                    Console.Write("\a");
                }
            }
        }
    }
}

