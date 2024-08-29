//Directory.CreateDirectory("C:\\Users\\Ülvi\\Desktop\\PB102Code\\Salam\\Aleykum");
//Directory.Delete("C:\\Users\\Ülvi\\Desktop\\PB102Code\\Salam",true);
//string path = "C:\\Users\\Ülvi\\Desktop\\PB102Code\\salam.txt";
//if (Directory.Exists(Path.Combine(path,"Salam","Aleykum")))
//{
//    File.Create(Path.Combine(path, "Salam", "Aleykum","salam.txt")).Close();
//}
//else
//{
//    Console.WriteLine("Qovluq movcud deyil");
//}

//using (StreamWriter sw = new StreamWriter(path))
//{
//    sw.WriteLine("");
//}


//using (StreamReader sr = new StreamReader(path))
//{
//    Console.WriteLine(sr.ReadToEnd());
//}

using FileStream.Models;
using FileStream.Services;
using Newtonsoft.Json;

Group pb102 = new Group
{
    Name = "PB",
    No = 102
};
//Student nihat = new Student
//{
//    Age = 17,
//    Code = "0001",
//    Name = "Nihat",
//    Surname = "Soltanov",
//    Group = pb102
//};

//List<Student> students = new List<Student>()
//{
//    nihat,
//    new Student
//    {
//        Name = "Tarkhan",
//        Surname = "Zeynalabdiyev",
//        Age = 25,
//        Group = pb102,
//        Code = "0002"
//    }
//};

//using (StreamWriter sw = new StreamWriter(path))
//{
//    string result = JsonConvert.SerializeObject(students);
//    sw.WriteLine(result);
//}

//var students = StudentService.GetStudents();

//students.ForEach(student => Console.WriteLine(student.Name));
Console.OutputEncoding = System.Text.Encoding.UTF8;
bool isContinue = true;
do
{
    Console.WriteLine("1 - Tələbələrə bax");
    Console.WriteLine("2 - Yeni tələbə yarat");
    Console.WriteLine("3 - Console-u təmizlə");
    char key = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (key)
    {
        case '1':
            StudentService.GetStudents().ForEach(x => Console.WriteLine(x));
            break;
        case '2':
            StudentService.CreateStudent(
                new Student
                {
                    Code = Console.ReadLine(),
                    Group = pb102,
                    Age = Convert.ToInt32(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    Surname = Console.ReadLine()
                }
            );
            break;
        case '3':
            Console.Clear();
            break;
        default:
            isContinue = false;
            break;
    }
}
while (isContinue);