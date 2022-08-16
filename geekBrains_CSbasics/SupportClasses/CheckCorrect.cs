using System.Text.RegularExpressions;

//1. Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры,
//при этом цифра не может быть первой.

namespace SupportClasses
{
    public static class CheckCorrect
    {
        public static bool ValidationLogin(string login)
        {
            string pattern = @"^[a-z][a-z\d]{1,9}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(login);
        }
    }
}
