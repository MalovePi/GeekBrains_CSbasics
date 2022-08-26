using FunctionExtremum;
using SupportClasses;

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

                InputHelpers.UserInputConverter(out int userInput, "\nВаша команда: ");

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
                        isContinue = false;
                        break;
                    case 3:
                        Console.Clear();
                        Task03();
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
                Console.WriteLine($"| {a,8:F2} | {x,8:F2} | {function(a, x),8:F2} |");
                x++;
            }
            Console.WriteLine("----------------------------------");
        }
        #endregion

        #region Task 02
        /*
         * Task 02:
         * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
         *  - а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке
         *    находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
         *  - б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум 
         *    через параметр (с использованием модификатора out).
         */
        static void Task02()
        {
            ConsoleView.UI();
        }
        #endregion

        #region Task 03
        /*
         * Task 03:
         * 3. ** Переделать программу Пример использования коллекций для решения следующих задач:
         *  - а) Подсчитать количество студентов учащихся на 5 и 6 курсах; 
         *  - б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
         *  - в) отсортировать список по возрасту студента;
         *  - г) *отсортировать список по курсу и возрасту студента;
         */

        static List<Student> _students = new List<Student>();

        static int CompareBySecondName(Student st1, Student st2) => string.Compare(st1.SecondName, st2.SecondName);

        static int CompareByAge(Student st1, Student st2) => st1.Age.CompareTo(st2.Age);

        static Dictionary<int, int> GetCourseForAge(int ageFrom, int ageTo)
        {
            Dictionary<int, int> course = new Dictionary<int, int>();

            foreach (Student item in _students)
            {
                if (item.Age >= ageFrom && item.Age <= ageTo)
                {
                    if (course.ContainsKey(item.Course))
                        course[item.Course]++;
                    else
                        course.Add(item.Course, 1);
                }
            }
            return course;
        }

        static void Task03()
        {
            int sumBakalavrAndMagistr = 0;

            using StreamReader streamReader = new StreamReader("students.csv");
            while (!streamReader.EndOfStream)
            {
                try
                {
                    string[] info = streamReader.ReadLine()
                                                .Split(";");
                    _students.Add(new Student(info[0], info[1], info[2], info[3], info[4],
                                             int.Parse(info[5]), int.Parse(info[6]), int.Parse(info[7]),
                                             info[8]));
                    if (int.Parse(info[6]) >= 5)
                        sumBakalavrAndMagistr++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Ошибка! ESC - пректарить выполнения программы.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }

            _students.Sort(new Comparison<Student>(CompareBySecondName));
            OutputHelpers.TextColor("Список студентов: ");
            foreach (var item in _students)
                Console.WriteLine(item);

            Console.WriteLine();
            OutputHelpers.TextColorWrite("Всего стундентов: ");
            Console.WriteLine(_students.Count);

            Console.WriteLine();
            OutputHelpers.TextColorWrite("Студентов на 5 и 6-х курсах: ");
            Console.WriteLine(sumBakalavrAndMagistr);

            Console.WriteLine();
            _students.Sort(new Comparison<Student>(CompareByAge));
            OutputHelpers.TextColor("Cортировка список по возрасту студента: ");
            foreach (var item in _students)
                Console.WriteLine(item);

            Console.WriteLine();
            _students.Sort((st1, st2) =>
            {
                if (st1.Course == st2.Course)
                    return st1.Age - st2.Age;
                else
                    return st1.Course - st2.Course;
            });
            OutputHelpers.TextColor("Cортировка список по курсу и возрасту студента: ");
            foreach (var item in _students) 
                Console.WriteLine(item);

            Console.WriteLine();
            OutputHelpers.TextColor("Список студентов в возрасте от 18 до 20 лет: ");
            Dictionary<int, int> courseForAge = GetCourseForAge(18, 20);
            foreach (var item in courseForAge)
                Console.WriteLine($"Курс: {item.Key} - {item.Value} студентов.");

            Console.ReadKey();
        }
        #endregion
    }
}
