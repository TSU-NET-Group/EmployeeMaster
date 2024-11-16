using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaster
{


    enum Lang
    {
        GEORGIAN,
        ENGLISH
    }

    enum My_message
    {
        LABEL_LOGIN,
        LABEL_REGISTER,
        LABEL_PASSWORD,
        LABEL_ID,
        LABEL_FORGET_PASSWORD,
        LABEL_GROUPBOX_NAME,
        LABEL_LANGUAGE_CHANGER,
        LABEL_GEORGIAN,
        LABEL_FOREIGHNER,
        LABEL_EMAIL,
        LABEL_NAME,
        LABEL_LASTNAME,
        LABEL_PHONENUMBER,
        LABEL_DEPARTMENT,
        LABEL_POSITION,
        LABEL_ETHNICITY,
        LABEL_IMAGE
    }

    class LanguagePack
    {
        Lang Language;


        public Dictionary<My_message, string> Text
        {
            get
            {
                if (Language == Lang.ENGLISH) { return TextENG; }
                else if (Language == Lang.GEORGIAN) { return TextGEO; }
                else throw new NotImplementedException($"No support for the requested language {Language}");
            }
            private set 
            {
                
            }
        }

        private static Dictionary<My_message, string> TextENG = new Dictionary<My_message, string>();

        private static Dictionary<My_message, string> TextGEO = new Dictionary<My_message, string>();
        
        //checking if inputed language even exists in enum
        public LanguagePack(Lang language)
        {
            if(language == Lang.ENGLISH || language == Lang.GEORGIAN)
            {
                Language = language;
            }
            else
            {
               throw new Exception("This language is not intended!");
            }
            
        }
        // adding values to the private dicitonaries 
        public void addTranslate(My_message message, string valaue) 
        {
            if (Language == Lang.GEORGIAN)
            {
                TextGEO[message] =  valaue;
            }
            else if (Language == Lang.ENGLISH) 
            {
                TextENG[message] = valaue;
            }
        }
    }
}
