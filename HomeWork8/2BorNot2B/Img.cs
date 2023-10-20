namespace _2BorNot2B
{
    public class Img
    {
        private string _fileNameImg;// имя файла изображения
        private string _tag;//текст тэга
        private bool _trueFalse;//да или нет

        public string FileNameImg
        {
            get => _fileNameImg;
            set
            {
                if (value.GetType() == typeof(string))
                    _fileNameImg = value;
            }
        }
        public string Tag
        {
            get => _tag;
            set
            {
                if (value.GetType() == typeof(string))
                    _tag = value;
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


        public Img(string fileNameImg, string tag, bool trueFalse)
        {
            _fileNameImg = fileNameImg;
            _tag = tag;
            _trueFalse = trueFalse;
        }

        public Img() { }
    }
}