using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class InputHelpers
    {
        public static double UserInputConverter(string text)
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
    }
}
