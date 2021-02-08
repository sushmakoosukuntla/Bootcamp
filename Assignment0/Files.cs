using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment0
{
    public class Files
    {


        //program that reads a text file and displays the number of words.

        public static int NoOfWordsInTextFile(string path)
        {
            if (File.Exists(path))
            {


                var wordsString = File.ReadAllText(path);
                var wordsArray = wordsString.Split(" ");
                return wordsArray.Length;
            }
            else
                return -1;

        }

        //program that reads a text file and displays the longest word in the file.

        public static string LongestWord(string path)
        {
            if (File.Exists(path))
            {
                var wordsString = File.ReadAllText(path);
                var wordsArray = wordsString.Split(" ");
                string longestWord = "";
                var wordLength = 0;
                foreach (var word in wordsArray)
                {
                    if (word.Length > wordLength)
                    {
                        longestWord = word;
                        wordLength = word.Length;
                    }

                }
                return longestWord;
            }

            else
                return "1";

        }
    }
}

