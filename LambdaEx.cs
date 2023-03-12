using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaFunctionProject
{
    internal class LambdaEx
    {
        public static void FunctionEx()
        {
            List<int> list = new List<int>() { 5, 1, 2, 5, 6, 9, 5, 4, 6, 2, 5, 4, 7 };
            List<int> evenList = list.FindAll(x => (x % 2) == 0);
            List<int> oddList = list.FindAll(x => (x % 2) != 0);

            foreach (var i in evenList)
            {
                Console.WriteLine(i);
            }
            foreach (var i in oddList)
            {
                Console.WriteLine(i);
            }

            int count = list.Count(x => x == 5);
            Console.WriteLine(count);

            List<Student> student = new List<Student>()
            {
                new Student{Id=1,Name="Rushi"},
                new Student{Id=2,Name="Rutik"},
                new Student{Id=3,Name="Koshti"},
                new Student{Id=4,Name="Ru"}
            };
            //var studentList = student.Select(x => new { Id = x.Id % 2 == 0, x.Name });
            var studentList = student.Select(x => x.Id % 2 == 0 );

            foreach (var i in studentList)
            {
                Console.WriteLine(i + ": " + i);
            }
        }
    }
}
