using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    static class ListExtensions
    {
        public static void Print(this List<Exam> exams)
        {
            exams.ForEach(x => Console.WriteLine($"{x.StudentName} {x.Subject} {x.Point} {x.EndDate - x.StartDate}"));
        }
    }
}
