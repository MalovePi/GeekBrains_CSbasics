using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class OutputHelpers
    {
        /// <summary>
        /// Метод завершения программы.
        /// </summary>
        public static void Delay()
        {
            Console.WriteLine("\nДля завершения программы нажмите любую клавишу...");
            Console.ReadKey();
        }
        /// <summary>
        /// Вывод информации о номере домашней работы, студенте.
        /// </summary>
        /// <param name="homeworkNumber">Номер домашней работы</param>
        /// <param name="fullName">ФИО Студента</param>
        public static void PrintOutStartInformation(int homeworkNumber, string fullName)
        {
            Console.WriteLine($"Домашняя работа: {homeworkNumber}");
            Console.WriteLine($"Студент: {fullName}");
            Console.WriteLine("====================\n");
        }
    }
}
