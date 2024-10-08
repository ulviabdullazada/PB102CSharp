﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerGeneric
{
    internal class Student : IPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
