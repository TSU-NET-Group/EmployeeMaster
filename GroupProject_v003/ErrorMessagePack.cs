using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_v001
{
    // ####################################################################################################
    // ####################################################################################################
    //
    // აქ შექმნილია იუზერის მიერ ავტორიზაციისას დაშვებული შეცდომების საპასუხო ერორების ერთობლიობა
    //
    // ####################################################################################################


    // ერორების ენუმერატორი ( იუზერის შეცდომებისთვის )
    enum Error
    {
        noRadio ,
        noLogIn,
        noPassword,
        wrongPassword,
        noSuchId,
        noNothing
    }

    // კლასი, სადაც კონსტრუქტორით ვქმნით ჩვენებურ ერორ წყვილს, გასაღები სიტყვა - ერორის ენუმერატორის სახელი, მნიშვნელობა (message) - ერორის სტრინგ დახასიათება
    class ErrorPair
    {
        public Error error;
        public string message;

        public ErrorPair(Error error, string message)
        {
            this.error = error;
            this.message = message;
        }
    }

    // სტატიკური კლასი, ერორთა ერთობლიობა მათი განმარტებებიანად
    static class ErrorMessagePack
    {
        // ერორების ერთობლიობა
        public static ErrorPair[] errors =
        {
            new ErrorPair(Error.noRadio, "* აირჩიე ეროვნება"),
            new ErrorPair(Error.noLogIn, "* შეავსე ID"),
            new ErrorPair(Error.noPassword, "* შეავსე პაროლი"),
            new ErrorPair(Error.wrongPassword, "* არასწორი პაროლი"),
            new ErrorPair(Error.noSuchId, "* ასეთი აიდი არ არსებობს სისტემაში"),
            new ErrorPair(Error.noNothing, "* ფორმა ცარიელია")
        };

        // ერორის პოვნა ენუმერატორ სახელით (დავაბრუნებთ ერორ წყვილს, გამოვიყენებთ რომ შესაბამისი ენამით ვიპოვოთ მისი შესაბამისი ერორ განმარტება)
        public static ErrorPair errorOf(Error error)
        {
            foreach(var pair in errors)
            {
                if(pair.error == error)
                {
                    return pair;
                }
            }

            return null;
        }
    }
}
