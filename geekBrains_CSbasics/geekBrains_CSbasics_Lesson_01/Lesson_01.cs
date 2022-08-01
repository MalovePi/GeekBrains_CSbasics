using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekBrains_CSbasics_Lesson_01
{
    class Lesson_01
    {
        static void Main()
        {
            Console.WriteLine("Hello, GeekBrains!");
            Console.WriteLine("Програма рассчета суммы:");

            Console.Write("Введите первое число: ");
            int augend = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int addend = int.Parse(Console.ReadLine());

            Console.WriteLine($"{augend} + {addend} = {CalculatorSum(augend, addend)}");
            Console.ReadKey();
        }

        private static int CalculatorSum(int augend, int addend)
        {
            int result = augend + addend;
            return result;
        }
    }
}
