using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMaster
{

    enum Lang  {
        GEORGIAN,
        ENGLISH
    }

    enum Message
    {
        LABEL_LOGIN,
        LABEL_REGISTER
    }

    class LanguagePack
    {
        Lang Language ;


        public Dictionary<Message, string> Text 
        {
            get { 
                if (Language == Lang.ENGLISH) { return TextENG; }
                else if (Language == Lang.GEORGIAN) { return TextGEO; }
                else throw new NotImplementedException($"No support for the requested language {Language}");
            }
            private set { }
        }

        private Dictionary<Message, string> TextENG;
        private Dictionary<Message, string> TextGEO;
        public LanguagePack(Lang language)
        {
            Language = language;
        }
    }
}
