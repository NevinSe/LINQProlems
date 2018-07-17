using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1 problem1 = new Problem1();
            //problem1.Contains();

            //Problem2 problem2 = new Problem2();
            //var noDuplicatedNames = problem2.NoDuplicates();
            //foreach(var name in noDuplicatedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Problem3 problem3 = new Problem3();
            //List<double> averageGrades = problem3.AverageGrades();
            //foreach(var grade in averageGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            Problem4 problem4 = new Problem4();
            Console.WriteLine(problem4.ListChar());

            Console.ReadLine();
        }
    }
}
