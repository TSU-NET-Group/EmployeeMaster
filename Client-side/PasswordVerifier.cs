using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public static class PasswordVerifier
    {

        public static bool verifyPassword(string password)
        {
            string temp;
            return verifyPassword(password, out temp);

        }
        public static bool verifyPassword(string password, out string error)
        {
            /*
             paroli unda iyos aseTi:
                                    a-z, A-Z, 0-9, !, ?, *, (no spaces),

                                    savaldebulo : min 1 spec symbol,
                                                  min 4 latin symbol,
                                                  min 3 nums,
                                                  fixed 8 characters
        */
            #region sub methods
            bool isNum(char c)
            {
                return c >= (int)'0' && c <= (int)'9';
            }
            bool isSpec(char c)
            {
                return c == '!' || c == '?' || c == '*';
            }
            bool isLatin(char c)
            {
                return (c >= (int)'a' && c <= (int)'z') || (c >= (int)'A' && c <= (int)'Z');
            }
            bool isForeign(char c)
            {
                return !isLatin(c) && !isNum(c) && !isSpec(c);
            }
            #endregion

            error = string.Empty;

            if (password.Length == 8)
            {

                int numCounter = 0;
                int latinCounter = 0;
                int specCounter = 0;
               

                for(int i = 0; i < password.Length; i++)
                {
                    if (isForeign(password[i]))
                    {
                        error = "Input contains wrong symbols, allowed symbols: latin characters, numbers, and ?, !, or *";
                        return false;
                    }
                    if (isLatin(password[i])) latinCounter++;
                    if (isNum(password[i])) numCounter++;
                    if (isSpec(password[i])) specCounter++;
                }
                if(numCounter == 3 && latinCounter == 4 && specCounter == 1)
                {
                    return true;
                }
                else
                {
                    error = "Password should contain 4 latin symbols, 3 numbers, and any of !, ? or * once";
                    return false;
                }
                //validacia tu gahyva useri parolis sherchevis wesebs 
            }
            else
            {
                error = "Input is not 8 symbols";
                return false;
                //roca 8 ze naklebi an meti iqneba parolebi magis case 
            }

            /*
             1. ორივე ტოლია
             2. 8 სიმბოლოა
             3. 
             */
        }
    }
}
