using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerGeneric
{
    internal class Group
    {
        public Student[] Students { get; set; }

        public Group()
        {
            Students = new Student[] {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Eldar",
                    Surname = "Ahmadov"
                },
                new Student {
                    Id = Guid.NewGuid(),
                    Name = "Hamid",
                    Surname = "Aliyev"
                }
            };
        }
        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="i">index</param>
        /// <returns></returns>
        public Student this[int i]
        {
            get 
            {
                if (i >= Students.Length)
                {
                    return Students[Students.Length - 1];
                }
                else if(i < 0)
                {
                    return Students[0];
                }
                return Students[i];
            }
            set 
            {
                if (i >= Students.Length)
                {
                    Students[Students.Length - 1] = value;
                }
                else if (i < 0)
                {
                    Students[0] = value;
                }
                Students[i] = value;
            }
        }

        public Student this[string name]
        {
            get
            {
                foreach (var std in Students)
                {
                    if (std.Name == name)
                    {
                        return std; 
                    }
                }
                return null;
            }
        }
    }
}
