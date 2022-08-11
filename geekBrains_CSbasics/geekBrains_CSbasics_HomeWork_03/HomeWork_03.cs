using System;
using System.Threading;
using SupportClasses;
using SupportStructs;

namespace geekBrains_CSbasics_HomeWork_03
{
    class HomeWork_03
    {
        static void Main()
        {
            OutputHelpers.PrintOutStartInformation(3, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.TasksMenu(2);

                int userInput = Convert.ToInt32(InputHelpers.UserInputConverter("\nВаша команда: "));

                switch (userInput)
                {
                    case 0:
                        Console.Clear();
                        OutputHelpers.TextColor("Досвидание!", ConsoleColor.DarkGreen);
                        Thread.Sleep(2000);
                        isContinue = false;
                        break;
                    case 1:
                        Console.Clear();
                        Task01();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 2:
                        Console.Clear();
                        Task02();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    default:
                        OutputHelpers.TextColor("Некорректный номер меню!", ConsoleColor.DarkRed);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        #region Task 01
        /*
         * Task 01:
         * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
         * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
         * в) Добавить диалог с использованием switch демонстрирующий работу класса.
         */
        static void Task01()
        {
            OutputHelpers.PrintOutStartInformation(3, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.ComplexMenu();
                int userInput = InputHelpers.UserInputConverterOutInt("\nВаша команда: ");
                switch (userInput)
                {
                    case 0:
                        Console.Clear();
                        OutputHelpers.TextColor("Досвидание!", ConsoleColor.DarkGreen);
                        Thread.Sleep(2000);
                        isContinue = false;
                        break;
                    case 1:
                        Console.Clear();
                        Task01A();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 2:
                        Console.Clear();
                        Task01B();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 3:
                        Console.Clear();
                        Task01C();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    default:
                        OutputHelpers.TextColor("Некорректный номер меню!", ConsoleColor.DarkRed);                        
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void Task01A()
        {
            OutputHelpers.TextColor("Пункт задания А. Дописать структуру Complex, добавив метод вычитания комплексных чисел.\n");
            ComplexStruct z1 = new ComplexStruct(1, 2);
            ComplexStruct z2 = new ComplexStruct(3, 4);
            Console.WriteLine($"Комплексные числа: {z1} и {z2}.");
            Console.WriteLine($"Сложение комплексных чисел: {z1 + z2}");
            Console.WriteLine($"Вычитание комплексных чисел: {z1 - z2}");            
        }

        static void Task01B()
        {
            OutputHelpers.TextColor("Пункт задания Б. Дописать класс Complex, добавив методы вычитания и произведения чисел.\n");
            ComplexClass z1 = new ComplexClass(1, 2);
            ComplexClass z2 = new ComplexClass(3, 4);
            Console.WriteLine($"Комплексные числа: {z1} и {z2}.");
            Console.WriteLine($"Сложение комплексных чисел: {z1 + z2}");
            Console.WriteLine($"Вычитание комплексных чисел: {z1 - z2}");
            Console.WriteLine($"Произведение комплексных чисел: {z1 * z2}");
        }

        static void Task01C()
        {
            ComplexСalculator.UserInterface();
        }
        #endregion
        #region Task 02
        /*
         * Task 02:
         * а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
         * Требуется подсчитать сумму всех нечётных положительных чисел. 
         * Сами числа и сумму вывести на экран, используя tryParse.
         */
        static void Task02()
        {
            OutputHelpers.TextColor("Программа подсчета суммы введеных нечетных положительных чисел.");
            Console.WriteLine("\nДля прекращения подсчета введи число 0.\n");
            int number;
            int sum = 0;

            do
            {
                number = InputHelpers.UserInputConverterOutInt();
                if (number > 0 && number % 2 != 0)
                    sum += number;
            } while (number != 0);

            Console.WriteLine($"Сумму всех нечетных положительных чисел: {sum}");
        }
        #endregion
    }
}
