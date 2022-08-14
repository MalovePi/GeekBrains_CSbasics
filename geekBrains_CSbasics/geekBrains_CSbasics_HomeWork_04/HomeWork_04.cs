using System;
using System.Threading;
using SupportClasses;

namespace geekBrains_CSbasics_HomeWork_04
{
    class HomeWork_04
    {
        static void Main()
        {
            OutputHelpers.PrintOutStartInformation(4, "Malov Pavel");

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
         * а) Дописать класс для работы с одномерным массивом. 
         *  - Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
         *  - Создать свойство Sum, которое возвращает сумму элементов массива,
         *  - метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
         *  - метод Multi, умножающий каждый элемент массива на определённое число,
         *  - свойство MaxCount, возвращающее количество максимальных элементов.
         * б) ** Создать библиотеку содержащую класс для работы с массивом. 
         *  - Продемонстрировать работу библиотеки.
         */
        static void Task01()
        {
            OutputHelpers.PrintOutStartInformation(4, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.ArraySampleMenu();

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
                        OutputHelpers.TextColor("Массив, заданной размерности и заполненный случайными числами от 10 до 100.\n");
                        InputHelpers.UserInputConverter(out int sizeArray, "Пожалуйста укажите размер массива: ");
                        OutputHelpers.ShowCaseArraySample(sizeArray);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 2:
                        Console.Clear();
                        OutputHelpers.TextColor("Массив, заданной размерности и заполненный случайными числами от 10 до 100.\n");
                        InputHelpers.UserInputConverter(out int size, "Пожалуйста укажите размер массива: ");
                        InputHelpers.UserInputConverter(out int startValue, "Пожалуйста укажите начальное значение: ");
                        InputHelpers.UserInputConverter(out int step, "Пожалуйста задайте шаг массива: ");
                        OutputHelpers.ShowCaseArraySample(size, startValue, step);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 3:
                        Console.Clear();
                        OutputHelpers.TextColor("Массив, загруженный из файла: \n");
                        OutputHelpers.ShowCaseArraySample(AppDomain.CurrentDomain.BaseDirectory + "Array.txt");
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                }
            }
        }
        #endregion

        #region Task 02
        /*
         * Task 02:
         * - Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
         * - Создайте структуру Account, содержащую Login и Password.
         */
        public static void Task02()
        {
            Authentication user = new Authentication(AppDomain.CurrentDomain.BaseDirectory + "DataBase.txt");

            if (Authentication.AuthenticationUser(user))
            {
                Console.Clear();
                OutputHelpers.TextColor("Успешная аутентификация. Добро пожаловать!", ConsoleColor.DarkGreen);
            }
            else
                OutputHelpers.TextColor("Ошибка аутентификации!");
        }
        #endregion
    }
}
