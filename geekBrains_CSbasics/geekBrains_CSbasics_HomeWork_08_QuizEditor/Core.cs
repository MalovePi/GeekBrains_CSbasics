using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace geekBrains_CSbasics_HomeWork_08_QuizEditor
{
    internal class Core
    {
        private string _fileName;
        private List<Question> _list;

        public string FileName
        {
            set => _fileName = value;
        }

        public Question this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public int Count => _list.Count;

        public Core(string fileName)
        {
            FileName = fileName;
            _list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (FileStream stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, _list);
            }
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileInfo fileInfo = new FileInfo(_fileName);
            using (FileStream stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
            {
                _list = xmlSerializer.Deserialize(stream) as List<Question>;
            }
        }

        public void Remove(int index)
        {
            if (_list != null && index <= _list.Count - 1 && index >= 0)
                _list.RemoveAt(index);
        }
    }
}
