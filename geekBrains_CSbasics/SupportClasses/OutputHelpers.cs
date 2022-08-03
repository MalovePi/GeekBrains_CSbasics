using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class OutputHelpers
    {
        public static void Delay()
        {
            Console.WriteLine("\nДля завершения программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
