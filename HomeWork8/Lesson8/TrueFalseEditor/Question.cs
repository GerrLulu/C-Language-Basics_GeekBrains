namespace TrueFalseEditor
{
    public class Question
    { 
        private string _text; //текст вопроса
        private bool _trueFalse; //да или нет

        public string Text
        {
            get => _text;
            set
            {
                if (value.GetType() == typeof(string))
                    _text = value;
            }
        }
        public bool TrueFalse
        {
            get => _trueFalse;
            set
            {
                if (value.GetType() == typeof(bool))
                    _trueFalse = value;
            }
        }


        public Question(string text, bool trueFalse)
        {
            _text = text;
            _trueFalse = trueFalse;
        }

        public Question() { }
    }
}