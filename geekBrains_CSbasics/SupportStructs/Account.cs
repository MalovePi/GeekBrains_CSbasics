using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportStructs
{
    public struct Account
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
        }

        public Account(string login, string password)
        {
            _login = login;
            _password = password;
        }

        /// <summary>
        /// Проверка логина и пароля.
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public bool Verify(string login, string password)
        {
            return login == _login && password == _password;
        }
    }
}