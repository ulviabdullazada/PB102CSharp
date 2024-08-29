using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Models
{
    internal class Student
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public override string ToString()
        {
            return $"{Code} -> {Name} {Surname} {Age}. {Group.Name}{Group.No}";
        }
    }
}
