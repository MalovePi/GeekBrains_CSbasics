using System;
using System.Threading;

namespace SupportClasses
{
    public class ComplexСalculator
    {
        public static void UserInterface()
        {
            do
            {
                OutputHelpers.TextColor("Калькулятор комплексных чисел:\n");
                GetComlex(out ComplexClass z1, 1, "первого");
                GetComlex(out ComplexClass z2, 2, "второго");
                Console.Clear();
                ComplexMenu(z1, z2);
                int userInput = InputHelpers.UserInputConverterOutInt("\nВаша команда: ");
                ComplexClass result = GetResult(z1, z2, userInput);
                OutputHelpers.TextColor($"\nРезультат вычисления: {result}.\n ", ConsoleColor.Green);
            } while (IsContinue());
        }

        private static ComplexClass GetComlex(out ComplexClass complex, int index, string numberIndex)
        {
            OutputHelpers.TextColor($"Комплексное число номер {index}: ", ConsoleColor.Green);
            InputHelpers.UserInputConverter(out double re, $"Введите вещественную часть {numberIndex} числа: ");
            InputHelpers.UserInputConverter(out double im, $"Введите мнимую часть {numberIndex} числа: ");
            complex = new ComplexClass(re, im);
            return complex;
        }

        private static ComplexClass GetResult(ComplexClass firstZ, ComplexClass secondZ, int cmd)
        {
            bool isContinue = true;
            ComplexClass result = new ComplexClass();
            while (isContinue)
            {
                switch (cmd)
                {
                    case 0:
                        Console.Clear();
                        OutputHelpers.TextColor("Работа программы завершена.", ConsoleColor.Blue);
                        Thread.Sleep(2000);
                        isContinue = false;
                        break;
                    case 1:
                        result = firstZ + secondZ;
                        Console.WriteLine("Суммы комплексных чисел");
                        isContinue = false;
                        break;
                    case 2:
                        result = firstZ - secondZ;
                        Console.WriteLine("Разности комплексных чисел");
                        isContinue = false;
                        break;
                    case 3:
                        result = firstZ * secondZ;
                        Console.WriteLine("Произведения комплексных чисел");
                        isContinue = false;
                        break;
                    case 4:
                        result = firstZ / secondZ;
                        Console.WriteLine("Частное комплексных чисел");
                        isContinue = false;
                        break;
                    default:
                        OutputHelpers.TextColor("Некорректный номер меню!", ConsoleColor.DarkRed);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            return result;
        }

        private static void ComplexMenu(ComplexClass z1, ComplexClass z2)
        {
            OutputHelpers.TextColor("Калькулятор комплексных чисел:\n");
            OutputHelpers.TextColor($"Комплексные числа: {z1} и {z2}.\n ", ConsoleColor.Green);
            OutputHelpers.TextColor("Пожайлуста, выберите команду:");
            Console.WriteLine("[1].....Вычисление суммы комплексных чисел.");
            Console.WriteLine("[2].....Вычисление разности комплексных чисел.");
            Console.WriteLine("[3].....Вычисление произведения комплексных чисел");
            Console.WriteLine("[4].....Вычисление частного комплексных чисел");
            OutputHelpers.TextColor("[0].....Exit", ConsoleColor.Red);
        }

        private static bool IsContinue()
        {
            while (true)
            {
                Console.Write("Продолжить вычисления?: Y/N > ");
                string ask = Console.ReadLine();
                if (ask.ToUpper() == "Y")
                {
                    Console.Clear();
                    return true;
                }
                else if (ask.ToUpper() == "N")
                {
                    OutputHelpers.TextColor("Работа программы завершена.", ConsoleColor.Blue);
                    return false;
                }
                else
                    OutputHelpers.TextColor("Операция не распознана. Введите Y или N!", ConsoleColor.DarkRed);
            }
        }
    }
}
