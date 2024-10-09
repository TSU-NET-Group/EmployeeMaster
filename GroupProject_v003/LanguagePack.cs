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
    // ეს ფაილის აღარ არის საჭირო, თუმცა ჯერ არ ვშლით, ჯერ დააიგნორეთ
    //
    // ####################################################################################################


    class WordPair
    {
        public string geo;
        public string eng;

        public WordPair(string geo, string eng)
        {
            this.geo = geo;
            this.eng = eng;
        }
    }


    static class LanguagePack
    {
        public static WordPair[] formWords = {
            new WordPair("ავტორიზაცია", "Autorization"),
            new WordPair("ID:", "ID:"),
            new WordPair("პაროლი:", "Password:"),
            new WordPair("შესვლა", "Log in"),
            new WordPair("დაგავიწყდა პაროლი???", "Forgot Password???"),
            new WordPair("ენა", "Language"),
            new WordPair("ქართველი", "Georgian"),
            new WordPair("უცხოეთის მოქალაქე", "Foreigner")
        };
    }
}
