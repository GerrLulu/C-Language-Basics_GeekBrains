using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TrueFalseEditor
{
    class TrueFalse
    {
        private string _fileName;
        private List<Question> _list;

        public string FileName
        {
            set { _fileName = value; }
        }
        public int Count
        {
            get { return _list.Count; }
        }
        public Question this[int index]
        {
            get { return _list[index]; }
        }


        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            _list = new List<Question>();
        }


        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_list != null && index < _list.Count && index >= 0)
                _list.RemoveAt(index);
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            var stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _list = (List<Question>)xmlSerializer.Deserialize(stream);
            stream.Close();
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            var stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(stream, _list);
            stream.Close();
        }
    }
}