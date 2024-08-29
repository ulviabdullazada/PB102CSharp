using FileStream.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Services
{
    class StudentService
    {
        const string path = @"C:\Users\Ülvi\source\repos\FileStream\FileStream\students.json";
        public static List<Student> GetStudents()
        {
            using (StreamReader sr = new StreamReader(path)) 
            {
                var result = JsonConvert.DeserializeObject<List<Student>>(sr.ReadToEnd());
                //return result;
                return result ?? new List<Student>();
            }
        }
        public static void CreateStudent(Student student)
        {
            var students = GetStudents();
            students.Add(student);
            using (StreamWriter sw = new StreamWriter(path))
            {
                string studentsString = JsonConvert.SerializeObject(students);
                sw.WriteLine(studentsString);
            }
        }
    }
}
