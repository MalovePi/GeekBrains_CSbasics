using System;
using System.Collections.Generic;

namespace SupportClasses
{
    public class OutputHelpers
    {
        /// <summary>
        /// Метод завершения программы.
        /// </summary>
        public static void Delay()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Для завершения программы нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод информации о номере домашней работы, студенте.
        /// </summary>
        /// <param name="homeworkNumber">Номер домашней работы</param>
        /// <param name="fullName">ФИО Студента</param>
        public static void PrintOutStartInformation(int homeworkNumber, string fullName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==========================");
            Console.WriteLine($"Домашняя работа. Лекция №{homeworkNumber}");
            Console.WriteLine($"Студент: {fullName}");
            Console.WriteLine("==========================\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Меню задач
        /// </summary>
        /// <param name="count">количество задач</param>
        public static void TasksMenu(int count)
        {
            var task = new List<string>() { "Задача 1", "Задача 2", "Задача 3", "Задача 4",
                "Задача 5", "Задача 6", "Задача 7", "Задача 8", "Задача 9", "Задача 10" };

            if (count <= 10)
            {
                var range = task.GetRange(0, count);
                TextColor("Menu:");

                for (int i = 0; i < range.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}].....{task[i]}");
                }

                TextColor("[0].....Exit", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine("Ошибка! Неверное количество задач.");
                Console.ReadKey();
            }
        }

        public static void TextColor(string text, ConsoleColor consoleColor = ConsoleColor.DarkYellow)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void TextColor(string text, string varieble, ConsoleColor consoleColor = ConsoleColor.DarkYellow)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(text);
            Console.ResetColor();
            Console.WriteLine(varieble);
        }

        public static void TextColorWrite(string text, ConsoleColor consoleColor = ConsoleColor.DarkYellow)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void ComplexMenu()
        {
            TextColor("Menu: Комплексные числа\n");
            Console.WriteLine("[1].....Пункт задания А.");
            Console.WriteLine("[2].....Пункт задания Б.");
            Console.WriteLine("[3].....Пункт задания В.");
            TextColor("[0].....Exit", ConsoleColor.Red);
        }

        public static void ArraySampleMenu()
        {
            TextColor("Menu: Работа с прототипом массива\n");
            Console.WriteLine("[1].....Cоздать массив, заданной размерности и заполненный случайными числами от 10 до 100.");
            Console.WriteLine("[2].....Создать массив, заданной размерности и заполненный от начального значения, с заданным шагом.");
            Console.WriteLine("[3].....Создать массив, загруженный из файла.");
            TextColor("[0].....Exit", ConsoleColor.Red);
        }

        public static void ShowCaseArraySample(int sizeArray)
        {
            ArraySample array = new ArraySample(sizeArray);
            OutputHelpers.TextColorWrite("Созданый массив: ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Сумма элементов массива: ", $"{array.Sum}");
            OutputHelpers.TextColor("Количество максимальных элементов: ", $"{array.MaxCount}");
            OutputHelpers.TextColorWrite("Массив с измененными знаками у всех элементов: ");
            array.ReverseSignOfElements(out ArraySample arrayNegative);
            arrayNegative.ShowArrayInteger();
            OutputHelpers.TextColorWrite("Демонстрация старого массива, без изменений:    ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Умножение каждого элемента массива на определённое число: ");
            InputHelpers.UserInputConverter(out int multoplier, "Пожалуйста ведите число: ");
            array.ElementMultiplier(multoplier);
            OutputHelpers.TextColorWrite("Результат: ");
            array.ShowArrayInteger();
        }

        public static void ShowCaseArraySample(int sizeArray, int startValue, int step)
        {
            ArraySample array = new ArraySample(sizeArray, startValue, step);
            OutputHelpers.TextColorWrite("Созданый массив: ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Сумма элементов массива: ", $"{array.Sum}");
            OutputHelpers.TextColor("Количество максимальных элементов: ", $"{array.MaxCount}");
            OutputHelpers.TextColorWrite("Массив с измененными знаками у всех элементов: ");
            array.ReverseSignOfElements(out ArraySample arrayNegative);
            arrayNegative.ShowArrayInteger();
            OutputHelpers.TextColorWrite("Демонстрация старого массива, без изменений:    ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Умножение каждого элемента массива на определённое число: ");
            InputHelpers.UserInputConverter(out int multoplier, "Пожалуйста ведите число: ");
            array.ElementMultiplier(multoplier);
            OutputHelpers.TextColorWrite("Результат: ");
            array.ShowArrayInteger();
        }

        public static void ShowCaseArraySample(string fileName)
        {
            ArraySample array = new ArraySample(fileName);
            OutputHelpers.TextColorWrite("Созданый массив: ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Сумма элементов массива: ", $"{array.Sum}");
            OutputHelpers.TextColor("Количество максимальных элементов: ", $"{array.MaxCount}");
            OutputHelpers.TextColorWrite("Массив с измененными знаками у всех элементов: ");
            array.ReverseSignOfElements(out ArraySample arrayNegative);
            arrayNegative.ShowArrayInteger();
            OutputHelpers.TextColorWrite("Демонстрация старого массива, без изменений:    ");
            array.ShowArrayInteger();
            OutputHelpers.TextColor("Умножение каждого элемента массива на определённое число: ");
            InputHelpers.UserInputConverter(out int multoplier, "Пожалуйста ведите число: ");
            array.ElementMultiplier(multoplier);
            OutputHelpers.TextColorWrite("Результат: ");
            array.ShowArrayInteger();
        }

        public static void MassegeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("[1].....Пункт задания А.");
            Console.WriteLine("[2].....Пункт задания Б.");
            Console.WriteLine("[3].....Пункт задания В.");
            Console.WriteLine("[4].....Пункт задания Г.");
            Console.WriteLine("[5].....Пункт задания Д.");
            TextColor("[0].....Exit", ConsoleColor.Red);
        }

        public static bool IsContinue(string text = "Продолжить вычисления?")
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write($"{text}: Y/N > ");
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
