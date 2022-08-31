using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static void OrderBy(this List<Student> students)
        {
            Student tempSt;
            for (int j = 0; j <= students.Count - 2; j++)
            {
                for (int i = 0; i <= students.Count - 2; i++)
                {
                    if (students[i].Birthday.Year > students[i + 1].Birthday.Year)
                    {
                        tempSt = students[i + 1];
                        students[i + 1] = students[i];
                        students[i] = tempSt;
                    }
                }
            }
        }
    }
}
