using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportClasses;

namespace geekBrains_CSbasics_HomeWork_02
{
    class HomeWork_02
    {

        // Malov Pavel
        
        static void Main()
        {
            Task01();
            OutputHelpers.Delay();            
        }
        /*
         * Task 01:
         * Написать метод, возвращающий минимальное из трёх чисел.
         */
        static void Task01()
        {
            Console.WriteLine("Программа для поиска самого большого числа из трех чисел!\n");

            double firstNumber = InputHelpers.UserInputConverter("Введите первое число: ");
            double secondNumber = InputHelpers.UserInputConverter("Введите второе число: ");
            double thirdNumber = InputHelpers.UserInputConverter("Введите третье число: ");

            Console.WriteLine($"Максимально число: {GetMax(firstNumber, secondNumber, thirdNumber)}");             
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
    }
}
