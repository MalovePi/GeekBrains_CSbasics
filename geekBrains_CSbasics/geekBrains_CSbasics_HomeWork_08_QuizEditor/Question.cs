using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekBrains_CSbasics_HomeWork_08_QuizEditor
{
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }

        public Question() { }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }
}
