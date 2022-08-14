using System;
using System.IO;
using SupportStructs;

namespace SupportClasses
{
    public class Authentication
    {
        private Account[] _accounts;

        /// <summary>
        /// Чтение базы данных из файла и запись в массив.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public Authentication(string fileName)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                _accounts = new Account[0];
                while (!streamReader.EndOfStream)
                {
                    string data = streamReader.ReadLine();
                    string[] dataBase = data.Split(',');
                    Array.Resize(ref _accounts, _accounts.Length + 1);
                    _accounts[_accounts.Length - 1] = new Account(dataBase[0], dataBase[1]);
                }
            }
        }
        
        /// <summary>
        /// Проверка в базе данных логина
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        public bool VerifyLogin(string login)
        {
            foreach (Account user in _accounts)
            {
                if (user.Login == login)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка в базе данных пароля
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool VerifyLoginPassword(string login, string password)
        {
            foreach (Account user in _accounts)
            {
                if (user.Verify(login, password))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Механизм аутентификации в пользовательском интерфейсе
        /// </summary>
        /// <param name="dataBase"></param>
        /// <returns></returns>
        public static bool AuthenticationUser(Authentication dataBase)
        {
            int numberAttempts = 3;
            string login;

            do
            {
                Console.WriteLine("===========");
                OutputHelpers.TextColor("Авторизация");
                Console.WriteLine("===========");
                
                OutputHelpers.TextColorWrite("\nЛогин: ");
                login = Console.ReadLine();

                if (dataBase.VerifyLogin(login))
                    break;
                else
                {
                    OutputHelpers.TextColor("Указанный логин не существует.", ConsoleColor.DarkRed);
                    numberAttempts--;
                    Console.WriteLine("У вас осталось {0} {1}", numberAttempts, numberAttempts == 1 ? "попытка" : "попытки");
                    if (numberAttempts == 0)
                        break;

                    Console.Write("Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (numberAttempts != 0);

            if (numberAttempts > 0)
            {
                numberAttempts = 3;
                do
                {
                    OutputHelpers.TextColorWrite("Пароль: ");
                    string password = Console.ReadLine();

                    if (dataBase.VerifyLoginPassword(login, password))
                        return true;
                    else
                    {
                        OutputHelpers.TextColor("Не верный пароль.", ConsoleColor.DarkRed);
                        numberAttempts--;
                        Console.WriteLine("У вас осталось {0} {1}", numberAttempts, numberAttempts == 1 ? "попытка" : "попытки");
                        if (numberAttempts == 0)
                            break;
                    }
                }
                while (numberAttempts != 0);
            }

            if (numberAttempts == 0)
            {
                Console.Clear();
                OutputHelpers.TextColor("В доступе отказано! Превышено количество попыток.", ConsoleColor.DarkRed);
            }

            return false;
        }
    }
}
