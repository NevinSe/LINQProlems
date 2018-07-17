using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem1
    {
        // determine if list contains substing "th"
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        public void Contains()
        {
            var containsString = words.Where(m => m.Contains("th"));
            foreach(var s in containsString)
            {
                Console.WriteLine(s);
                
            }
        }
    }
}
