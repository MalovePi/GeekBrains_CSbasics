using System;
using SupportClasses;
using System.Threading;

namespace geekBrains_CSbasics_HomeWork_02
{
    class HomeWork_02
    {
        static void Main()
        {
            OutputHelpers.PrintOutStartInformation(2, "Malov Pavel");

            bool isContinue = true;
            while (isContinue)
            {
                OutputHelpers.TasksMenu(6);

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
                    case 3:
                        Console.Clear();
                        Task03();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 4:
                        Console.Clear();
                        Task04();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 5:
                        Console.Clear();
                        Task05();
                        OutputHelpers.Delay();
                        isContinue = false;
                        break;
                    case 6:
                        Console.Clear();
                        Task06();
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
         * Написать метод, возвращающий минимальное из трёх чисел.
         */
        static void Task01()
        {
            OutputHelpers.TextColor("Программа для поиска самого большого числа из трех чисел.\n", ConsoleColor.DarkYellow);

            double firstNumber = InputHelpers.UserInputConverter("Введите первое число: ");
            double secondNumber = InputHelpers.UserInputConverter("Введите второе число: ");
            double thirdNumber = InputHelpers.UserInputConverter("Введите третье число: ");

            string resultGetMax = $"\nМаксимально число: {GetMax(firstNumber, secondNumber, thirdNumber)}";
            Console.WriteLine(resultGetMax);
        }

        private static double GetMax(double firstNumber, double secondNumber, double thirdNumber)
        {
            double max = firstNumber;
            if (firstNumber < secondNumber && secondNumber > thirdNumber)
                max = secondNumber;
            else if (thirdNumber > firstNumber)
                max = thirdNumber;
            return max;
        }
        #endregion
        #region Task 02
        /*
         * Task 02:
         * Написать метод подсчета количества цифр числа.
         */
        static void Task02()
        {
            OutputHelpers.TextColor("Программа подсчета количества цифр числа.\n", ConsoleColor.DarkYellow);
            long number = Convert.ToInt64(InputHelpers.UserInputConverter("Введите число: "));

            string resultGetCounting = $"Количество цифр в числе: {GetCountingNumbers(number)}";
            Console.WriteLine(resultGetCounting);
        }

        private static long GetCountingNumbers(long number)
        {
            long count = 0;

            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
        #endregion
        #region Task 03
        /*
         * Task 03:
         * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
         */
        static void Task03()
        {
            OutputHelpers.TextColor("Программа подсчета суммы введеных нечетных положительных чисел.", ConsoleColor.DarkYellow);
            Console.WriteLine("\nДля прекращения подсчета введи число 0.\n");
            int number;
            int sum = 0;
            
            do
            {
                number = Convert.ToInt32(InputHelpers.UserInputConverter("Введите число: "));
                if (number > 0 && number % 2 != 0)
                    sum += number;
            } while (number != 0);

            Console.WriteLine($"Сумму всех нечетных положительных чисел: {sum}");
        }
        #endregion
        #region Task 04
        /*
         * Task 04:
         * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию,
         * ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
         * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
         * С помощью цикла do while ограничить ввод пароля тремя попытками. 
         */
        private static string _password = "GeekBrains";
        private static string _login = "root";
        private static int _numberAttempts = 3;
        static void Task04()
        {
            string login, password;

            do
            {
                OutputHelpers.TextColor($"Введите пароль, для доступа к сообщению. У вас есть {_numberAttempts} попытки:\n", ConsoleColor.DarkYellow);
                Console.Write("Логин: ");
                login = Console.ReadLine();
                Console.Write("Пароль: ");
                password = Console.ReadLine();
                if (VerifyUser(login, password))
                {
                    Console.WriteLine("\nПароль верный!");
                    OutputHelpers.TextColor("Я У МАМЫ ПРОГРАММИСТ!", ConsoleColor.DarkGreen);
                    break;
                }
                else
                {
                    OutputHelpers.TextColor("Не верно!", ConsoleColor.DarkRed);
                    --_numberAttempts;
                    Console.Write("Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (_numberAttempts != 0);

            if (_numberAttempts == 0)
            {
                Console.Clear();
                OutputHelpers.TextColor("В доступе отказано!", ConsoleColor.DarkRed);
            }
        }

        private static bool VerifyUser(string login, string password)
        {
            if (login == _login && password == _password)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Task 05
        /*
         * Task 05:
         * а) Написать программу, которая запрашивает массу и рост человека,
         * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
         * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
         */
        private static int _obesityIndex = 24;
        private static int _underweightIndex = 19;
        static void Task05()
        {
            OutputHelpers.TextColor("Программа рассчeта индекса массы тела.\n", ConsoleColor.DarkYellow);

            double growth = InputHelpers.UserInputConverter("Введите рост, м: ");
            double mass = InputHelpers.UserInputConverter("Введите вес, кг: ");

            double result = mass / Math.Pow(growth, 2);

            Console.WriteLine("\nИМТ: {0:F2} кг/м2", result);

            if (result < _underweightIndex)
            {
                OutputHelpers.TextColor("\nНедостаточный вес!", ConsoleColor.Red);
                Console.WriteLine("Для идеального веса нужно набрать:  {0:F2} кг.", (_underweightIndex - result) * Math.Pow(growth, 2));
            }
            else if (result > _obesityIndex)
            {
                OutputHelpers.TextColor("\nИзбыточный вес!", ConsoleColor.DarkRed);
                Console.WriteLine("Для идеального веса нужно сбросить:  {0:F2} кг.", (result - _obesityIndex) * Math.Pow(growth, 2));
            }
            else
            {
                OutputHelpers.TextColor("\nНормальный вес!", ConsoleColor.DarkGreen);
            }
        }
        #endregion
        #region Task 06
        /*
         * Task 06:
         * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * «Хорошим» называется число, которое делится на сумму своих цифр. 
         * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         */
        private static int _rangeStart = 1;
        private static int _rangeEnd = 1_000_000_000;
        static void Task06()
        {
            OutputHelpers.TextColor("Программа подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.\n", ConsoleColor.DarkYellow);
            DateTime timer = DateTime.Now;
            int countOfGoodNumbers = 0;

            for (int i = _rangeStart; i <= _rangeEnd; i++)
            {
                if (NumberCheck(i))
                    countOfGoodNumbers++;
            }

            Console.WriteLine("Количество «хороших» чисел в интервале от 1 до 1 000 000 000\n" +
                               $"составило: {countOfGoodNumbers}");
            Console.WriteLine("Время выполнения программы: {0:hh\\:mm\\:ss}", DateTime.Now - timer);
        }

        private static bool NumberCheck(int i)
        {
            int number = i;
            int sumDigitsNum = 0;
            while (number != 0)
            {
                sumDigitsNum += number % 10;
                number /= 10;
            }
            return i % sumDigitsNum == 0;
        }
        #endregion
    }
}
