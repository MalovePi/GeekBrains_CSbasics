using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace geekBrains_CSbasics_HomeWork_01
{
    class HomeWork_01
    {

        // Malov Pavel

        static void Main()
        {
            //Task01();
            //Task02();
            //Task03();
            //Task04();
            Task05();
            Console.ReadKey();
        }
        /*
         * Task 01:
         * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация
         * выводится в одну строчку:
         * а) используя склеивание;
         * б) используя форматированный вывод;
         * в) используя вывод со знаком $.
         */
        static void Task01()
        {
            Console.WriteLine("Анкета клиента:");

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фимилию: ");
            string surname = Console.ReadLine();

            int age = Convert.ToInt32(UserInputConverter("Введите возраст: "));

            double growth = UserInputConverter("Введите рост, м: ");

            double mass = UserInputConverter("Введите вес, кг: ");

            Console.WriteLine("Вариант ввывода №1: " + name + " " + surname + " Возраст: " + age + " Рост: " + growth + "м. Вес: " + mass + "кг." + "!");
            Console.WriteLine("Вариант ввывода №2: {0} {1} Возраст: {2} Рост: {3}м. Вес: {4}кг.!", name, surname, age, growth, mass);
            Console.WriteLine($"Вариант ввывода №3: {name} {surname} Возраст: {age} Рост: {growth}м. Вес: {mass}кг.!");
        }
        private static double UserInputConverter(string text)
        {
            while (true)
            {
                Console.Write(text);
                string str = Console.ReadLine();
                double result;

                if (double.TryParse(str, out result))
                    return result;
                else
                    Console.WriteLine("Неправильный фармат числа. Попробуй еще раз!");
            }
        }
        /*
         * Task 02:
         * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
         * где m — масса тела в килограммах, h — рост в метрах.
         */
        static void Task02()
        {
            Console.WriteLine("Рассчeт индекса массы тела");

            double growth = UserInputConverter("Введите рост, м: ");
            double mass = UserInputConverter("Введите вес, кг: ");

            double result = mass / Math.Pow(growth, 2);

            Console.WriteLine($"ИМТ: {Math.Round(result, 2)} кг/м2");
        }
        /*
         * Task 03:
         * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,y1 
         * и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
         * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
         * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
         */
        static void Task03()
        {
            Console.WriteLine("Расчет расстояния между точками с координатами x1,y1 и x2,y2");

            double pointX1 = UserInputConverter("Введите число, x1: ");
            double pointY1 = UserInputConverter("Введите число, y1: ");
            double pointX2 = UserInputConverter("Введите число, x2: ");
            double pointY2 = UserInputConverter("Введите число, y2: ");

            double pointSpacing = Math.Sqrt(Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2));

            Console.WriteLine("Вариант ввывода №1 - Расстояние между точками: {0:F2}", pointSpacing);
            Console.WriteLine("Вариант ввывода №2 - Расстояние между точками: {0:F2}", CalculatingTheDistance(pointX1, pointY1, pointX2, pointY2));
        }
        private static double CalculatingTheDistance(double x1, double y1, double x2, double y2)
        {
            double pointSpacing = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return pointSpacing;
        }
        /*
         * Task 04:
         * Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
         * а) с использованием третьей переменной;
         * б) *без использования третьей переменной.
         */
        static void Task04()
        {
            Console.WriteLine("Программа обмена значениями двух переменных типа int:");

            int firstNumber = 25;
            int secondNumber = 31;

            Console.WriteLine($"\nЗначение переменных до обмена: Первое число - {firstNumber}, Второе число - {secondNumber}.");

            Console.WriteLine("\nC использованием третьей переменной:");
            int thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            Console.WriteLine($"Значение переменных после обмена: Первое число - {firstNumber}, Второе число - {secondNumber}.");

            Console.WriteLine("\nБез использования третьей переменной:");
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
            Console.WriteLine($"Значение переменных после обратного обмена: Первое число - {firstNumber}, Второе число - {secondNumber}.");
        }
        /*
         * Task 05:
         * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         * б) Сделать задание, только вывод организовать в центре экрана.
         * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
         */
        static void Task05()
        {
            Console.WriteLine("Информация о студенте:");
            Console.Write("Имя: Павел");
            Console.Write("\nФамилия: Малов");
            Console.Write("\nГород: Невинномысск");
            Console.Write("\n\nНажми любую клавишу, чтобы организовать вывод в центре экрана:");
            Console.ReadKey();
            Console.Clear();

            string studentInfo = "Информация о студенте: \nИмя: Павел \nФамилия: Малов \nГород: Невинномысск";
            string[] lines = Regex.Split(studentInfo, "\n");
            int left;
            int top = (Console.WindowHeight / 2) - (lines.Length / 2) - 1;
            int center = Console.WindowWidth / 2;
            for (int i = 0; i < lines.Length; i++)
            {
                left = center - (lines[i].Length / 2);
                Console.SetCursorPosition(left, top);
                Console.WriteLine(lines[i]);
                top = Console.CursorTop;
            }
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("\n\nНажми любую клавишу, чтобы организовать вывод с использованием методa:");
            Console.ReadKey();
            Console.Clear();

            StudentInfoPrint("Alex", "Petrov", "Ijevsk", 10, 3);
        }
        private static void StudentInfoPrint(string name, string surname, string sity, int inputAxisX, int inputAxisY)
        {
            string studentInfo = $"Информация о студенте: \nИмя: {name} \nФамилия: {surname} \nГород: {sity}";
            string[] lines = Regex.Split(studentInfo, "\n");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(inputAxisX, inputAxisY);
                Console.WriteLine(lines[i]);
                inputAxisY = Console.CursorTop;
            }
        }
    }
}

