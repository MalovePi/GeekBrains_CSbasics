using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SupportClasses
{
    public static class Message
    {
        private static char[] _separators = { ' ', '.', ',', '!','?', '@', '#', '$',
                                  '%', '^', ':', ';', '\t', '\r', '\n' };

        public static void GetWordsOfSpecificLength(string message, int letterCount)
        {
            string pattern = @"\S{" + letterCount + @",}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(message);
            
            if (matches.Count > 0)
            {
                Console.Write($"Список слов содержащий не более {letterCount} букв: ");
                foreach (Match match in matches)
                    Console.Write(match.Value + ", ");
            }
            else
                Console.WriteLine("Совпадений не найдено.");
        }

        public static string RemovingWordsByCharacter(string message, char character)
        {
            string pattern = $@"\w+{character}\b";
            string target = "";
           
            Regex regex = new Regex(pattern);
            return regex.Replace(message, target);
        }

        public static string FindLongestWord(string massege)
        {
            string[] words = massege.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            return words.Last();
        }

        public static string FindLongestWords(string message, int minWordLenght)
        {
            if (string.IsNullOrEmpty(message))
                return null;
           
            StringBuilder stringBuilder = new StringBuilder();
            
            string[] words = message.Split(_separators, StringSplitOptions.RemoveEmptyEntries);            
            foreach (string word in words)
            {
                if (word.Length >= minWordLenght)
                    stringBuilder.Append($"{word} ");
            }

            return stringBuilder.ToString();
        }
    }
}
