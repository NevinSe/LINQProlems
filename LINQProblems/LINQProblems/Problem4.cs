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
        public Problem4()
        {
            lettersFromWord = new List<string>();
            Console.Write("Please Enter A Word: ");
            word = Console.ReadLine().ToUpper();
        }
        public string ListChar()
        {
            SplitWordToChar();
            SortAndCountCharList();
            foreach(string letter in lettersFromWord)
            {
                finalString += letter;
            }
            return finalString;
        }
        public void SplitWordToChar()
        {
            lettersFromWord = word.Split().ToList();
        }
        public void SortAndCountCharList()
        {
            var result = lettersFromWord.GroupBy(l => l.FirstOrDefault());
            foreach(var letter in lettersFromWord)
            {
                Console.Write(letter);
            }
        }
    }
}
