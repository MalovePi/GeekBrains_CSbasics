using SupportClasses;

namespace FunctionExtremum
{
    public class ConsoleView
    {
        public static void UI()
        {
            Functions.Function[] functions = new Functions.Function[]
            {
            Functions.Sine, Functions.Cubic , Functions.Square, Functions.SquareTrinomials
            };

            OutputHelpers.TextColor("Экстремумы функции.\n");

            Console.WriteLine("Искать экстремум функции на интервале: ");
            InputHelpers.UserInputConverter(out double start, "От: ");
            InputHelpers.UserInputConverter(out double end, "До: ");
            InputHelpers.UserInputConverter(out double step, "Шаг: ");

            Console.WriteLine("\nВыберите функцию:");
            Console.WriteLine("[1].....f(x) = sin(x)");
            Console.WriteLine("[2].....f(x) = x^3");
            Console.WriteLine("[3].....f(x) = x^2");
            Console.WriteLine("[4].....f(x) = x^2 - 30x + 5");
            OutputHelpers.TextColor("[v].....Загрузить последние значения функции из файла.");

            while (UserCommand(out int index, 4))
            {
                File.Create(@"..\..\data.bin", start, end, step, functions[index - 1]);
                double min = File.Load(@"..\..\data.bin");

                OutputHelpers.TextColorWrite($"Значение минимума на интервале ({start} , {end}): ", ConsoleColor.Green);
                Console.WriteLine($"{min:F2}");
                OutputHelpers.TextColorWrite("Результаты загружены в файл: data.bin\n", ConsoleColor.Green);
            }

            Console.WriteLine("\nТаблица значений из последнего файла:");

            TableValues(start, end, step, File.LoadValues(@"..\..\data.bin", out double min2));
            OutputHelpers.TextColorWrite("Значение глобального минимума: ", ConsoleColor.Green);
            Console.WriteLine($"{min2:F2}");

            Console.ReadKey();
        }

        private static bool UserCommand(out int number, int max)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ваша команда: ");
                string? str = Console.ReadLine();

                if (int.TryParse(str, out int num))
                {
                    if (0 < num && num <= max)
                    {
                        number = num;
                        return true;
                    }
                    OutputHelpers.TextColor($"Ошибка! Введите числовое значение от 1 до {max}", ConsoleColor.DarkRed);
                }
                else if (str?.ToLower() == "v")
                {
                    number = default;
                    return false;
                }
                else
                    OutputHelpers.TextColor($"Ошибка! Неправильный фармат.", ConsoleColor.DarkRed);
            }
        }

        private static void TableValues(double start, double end, double step, double[] values)
        {
            int index = 0;

            Console.WriteLine(" -----x---- ----f(x)--- ");
            while (start <= end)
            {
                Console.WriteLine($"| {start,8:F2} |  {values[index],8:F2} |");
                start += step;
                index++;
            }
            Console.WriteLine(" ---------- ----------- ");
        }
    }
}

