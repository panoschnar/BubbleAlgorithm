using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Name="Panos", Score=99, Birthday=new DateTime(1988,04,04)};
            Student s2 = new Student() { Name="Sofia", Score=92, Birthday=new DateTime(1983,08,12)};
            Student s3 = new Student() { Name="Maria", Score=88, Birthday=new DateTime(1992,08,29)};
            var students = new List<Student>() { s1,s2,s3};

            //Bubble Algorithm

            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");

            BubbleSort.OrderBy(students);
            students.OrderBy();

            Console.WriteLine("Sorted:");
            foreach (var stu in students)
                Console.WriteLine($"{stu.Name} {stu.Score} {stu.Birthday.Year}");
            Console.Read();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Birthday { get; set; }
    }
}
