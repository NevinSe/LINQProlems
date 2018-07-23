using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem4
    {
        private string word;
        private string finalString;
        private List<string> lettersFromWord;
        private List<int> numbersFromWord;
        public Problem4()
        {
            lettersFromWord = new List<string>();
            Console.Write("Please Enter A Word: ");
            word = Console.ReadLine().ToUpper();
            SortWord();
        }
        public void SortWord()
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(!lettersFromWord.Contains(word[i].ToString()))
                {
                    lettersFromWord.Add(word[i].ToString());
                    numbersFromWord[i]
                }
                
            }



            ListChar();
        }
        public string ListChar()
        {
            foreach(KeyValuePair<int, string> pair in intChar)
            {
                finalString += pair;
            }
            return finalString;
        }
        


        //public void SplitWordToChar()
        //{
        //    lettersFromWord = word.Split().ToList();
        //}
        //public void SortAndCountCharList()
        //{
        //    var result = lettersFromWord.GroupBy(l => l.FirstOrDefault());
        //    foreach(var letter in lettersFromWord)
        //    {
        //        Console.Write(letter);
        //    }
        //}
    }
}
