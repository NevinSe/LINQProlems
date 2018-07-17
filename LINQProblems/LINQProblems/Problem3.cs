using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem3
    {
        List<int[]> splitGrades;
        List<string> classGrades = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };
        List<int[]> newClassGrades = new List<int[]>();
        public Problem3()
        {
            splitGrades = new List<int[]>();
        }
        public void SplitGrades()
        {
            foreach(var grade in classGrades)
            {
                splitGrades.Add(grade.Split(',').Select(h => Int32.Parse(h)).ToArray());
            }
        }
        public void DropLowestGrade()
        {
            List<int> tempList = new List<int>();
            for(int i = 0; i< splitGrades.Count; i++)
            {
                Array.Sort(splitGrades[i]);
                tempList = splitGrades[i].ToList();
                tempList.RemoveAt(0);
                newClassGrades.Add(tempList.ToArray());
            }
            
        }
        public List<double> AverageGrades()
        {
            List<double> averageGrades = new List<double>();
            SplitGrades();
            DropLowestGrade();
            for (int i = 0; i < newClassGrades.Count; i++)
            {
                averageGrades.Add(newClassGrades[i].Average());
            }
            return averageGrades;
        }
    }
}
