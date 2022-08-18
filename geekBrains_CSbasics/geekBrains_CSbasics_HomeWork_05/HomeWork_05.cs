using System;
using System.Text.RegularExpressions;
using System.Threading;
using SupportClasses;


namespace geekBrains_CSbasics_HomeWork_05
{
    class HomeWork_05
    {
        static void Main()
        {
            OutputHelpers.PrintOutStartInformation(5, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.TasksMenu(4);

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
         * Создать программу, которая будет проверять корректность ввода логина.
         *  Корректным логином будет строка от 2 до 10 символов, 
         *  содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.
         */
        static void Task01()
        {
            int minLoginLength = 2;
            int maxLoginLength = 10;
            Console.WriteLine("=======================");
            OutputHelpers.TextColor("Регистрация GeekBrains.");
            Console.WriteLine("=======================\n");

            while (true)
            {
                OutputHelpers.TextColorWrite("Пожалуйста, укажите ваше имя пользователя: ", ConsoleColor.DarkBlue);
                string userInput = Console.ReadLine();
                if (minLoginLength < userInput.Length && userInput.Length < maxLoginLength)
                {
                    if (CheckCorrect.ValidationLogin(userInput))
                    {
                        OutputHelpers.TextColor("Имя пользователя корректно.", ConsoleColor.DarkGreen);
                        break;
                    }
                    else if (char.IsDigit(userInput[0]))
                    {
                        Console.WriteLine("Цифра не может быть использована в качестве первого символа.");
                    }
                    else
                        Console.WriteLine("Имя пользователя должено содержать только буквы латинского алфавита или цифры.");
                }
                else
                    Console.WriteLine("Имя пользователя должно быть от 2 до 10 символов.");
            }
        }
        #endregion

        #region Task 02
        /*
         * Task 02:
         * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
         * -  а) Вывести только те слова сообщения, которые содержат не более n букв.
         * -  б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
         * -  в) Найти самое длинное слово сообщения.
         * -  г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
         *    д) **Создать метод, который производит частотный анализ текста. 
         *         В качестве параметра в него передается массив слов и текст, 
         *         в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
         *         Здесь требуется использовать класс Dictionary.
         */
        static void Task02()
        {
            OutputHelpers.PrintOutStartInformation(5, "Malov Pavel");

            OutputHelpers.TextColor("Демонстрация работы статического класса Message.", ConsoleColor.Cyan);

            OutputHelpers.TextColorWrite("\nВедите сообщение: ", ConsoleColor.White);
            string userInput = Console.ReadLine();

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.MassegeMenu();
                int command = InputHelpers.UserInputConverterOutInt("\nВаша команда: ");
                switch (command)
                {
                    case 0:
                        Console.Clear();
                        OutputHelpers.TextColor("Досвидание!", ConsoleColor.DarkGreen);
                        Thread.Sleep(2000);
                        isContinue = false;
                        break;
                    case 1:
                        Console.Clear();
                        Task02A(userInput);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 2:
                        Console.Clear();
                        Task02B(userInput);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 3:
                        Console.Clear();
                        Task02C(userInput);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 4:
                        Console.Clear();
                        Task02D(userInput);
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                }
            }
        }

        static void Task02A(string userInput)
        {
            OutputHelpers.TextColor("Пункт задания А. Вывод только тех слов сообщения, которые содержат не больше количества заданых букв.");

            Console.WriteLine("\nСообщение: " + userInput + "\n");
            InputHelpers.UserInputConverter(out int letterCount, "Ведите количество букв: ");
            Message.GetWordsOfSpecificLength(userInput, letterCount);
        }

        static void Task02B(string userInput)
        {
            OutputHelpers.TextColor("Пункт задания Б. Удалить из сообщения все слова, которые заканчиваются на заданный символ.");

            Console.WriteLine("\nСообщение: " + userInput + "\n");
            InputHelpers.UserInputConverter(out char character, "Ведите символ: ");
            Console.WriteLine(Message.RemovingWordsByCharacter(userInput, character));
        }

        static void Task02C(string userInput)
        {
            OutputHelpers.TextColor("Пункт задания В. Найти самое длинное слово сообщения.");

            Console.WriteLine("\nСообщение: " + userInput + "\n");
            Console.WriteLine($"Самое длиное слово: {Message.FindLongestWord(userInput)}");
        }

        static void Task02D(string userInput)
        {
            int minWordLenght = 5;

            OutputHelpers.TextColor("Пункт задания Г. Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");

            Console.WriteLine("\nСообщение: " + userInput + "\n");
            Console.WriteLine(Message.FindLongestWords(userInput, minWordLenght));
        }
        #endregion

        #region Task 03
        /*
         * Task 03:
         * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
         *     Например: badc являются перестановкой abcd.
         */
        #endregion

        #region Task 04
        /*
         * Task 04:
         * *Задача ЕГЭ.
         *  На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
         *  В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
         *  каждая из следующих N строк имеет следующий формат:
         *  <Фамилия> <Имя> <оценки>,
         *  где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
         *  <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
         *  <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. 
         *  Пример входной строки:
         *  Иванов Петр 4 5 3
         *  Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии 
         *  и имена трёх худших по среднему баллу учеников. 
         *  Если среди остальных есть ученики, набравшие тот же средний балл,
         *  что и один из трёх худших, следует вывести и их фамилии и имена.
         */
        #endregion
    }
}
