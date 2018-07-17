using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem2
    {
        List<string> names = new List<string> {"Mike","Dan","Scott","Nick","Mike"};
        public IEnumerable<string> NoDuplicates()
        {
            return names.Distinct();
        }
    }
}
