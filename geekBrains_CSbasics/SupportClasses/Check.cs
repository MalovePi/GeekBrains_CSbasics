using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SupportClasses
{
    public static class Check
    {
        public static bool ValidationLogin(string login)
        {
            string pattern = @"^[a-z][a-z\d]{1,9}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(login);
        }

        public static bool StringsAreAnagrams(string s, string t)
        {
            s = s.ToUpper();
            t = t.ToUpper();

            if (s.Length != t.Length)
                return false;
            else if (s.Equals(t))
            {
                Console.WriteLine("Одинаковые строки, не могут быть анаграммами.");
                return false;
            }     
            
            string sortedCopyS = string.Join("", s.OrderBy(c => c).ToArray());
            string sortedCopyT = string.Join("", t.OrderBy(c => c).ToArray());
            return sortedCopyS.Equals(sortedCopyT);
        }
    }    
}
