using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCasting
{
    class PersonClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    //readonly record struct PersonRecord(string Name, string Surname);

    //record PersonRecord(string Name, string Surname);
    record PersonRecord()
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

}
