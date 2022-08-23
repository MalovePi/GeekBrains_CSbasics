using SupportClasses;
using System;
using System.Threading;

namespace geekBrains_CSbasics_HomeWork_06
{
    class HomeWork_06
    {
        static void Main()
        {
            OutputHelpers.PrintOutStartInformation(6, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.TasksMenu(3);

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
         * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции 
         *    типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
         */
        static void Task01()
        {
            OutputHelpers.TextColor("Таблица функции A*X^2");
            Table(FunctionTables.Squaring, 2, -5, 5);

            OutputHelpers.TextColor("Таблица функции A*SIN(X)");
            Table(FunctionTables.Sin, 2, -5, 5);
        }

        static void Table(FunctionTables.Function function, double a, double x, double end)
        {
            Console.WriteLine("-----A----------X--------RESULT---");
            while (x <= end)
            {
                Console.WriteLine($"| {a,8:F3} | {x,8:F3} | {function(a, x),8:F3} |");
                x++;
            }
            Console.WriteLine("----------------------------------");
        }
        #endregion

        #region Task 02
        /*
         * Task 02:
         * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
         *    а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке
         *    находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
         *    б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум 
         *    через параметр (с использованием модификатора out).
         */

        #endregion

        #region Task 03
        /*
         * Task 03:
         * 3. ** Переделать программу Пример использования коллекций для решения следующих задач:
         *    а) Подсчитать количество студентов учащихся на 5 и 6 курсах; 
         *    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
         *    в) отсортировать список по возрасту студента;
         *    г) *отсортировать список по курсу и возрасту студента;
         */

        #endregion
    }
}
