using Delegate;
using System.Reflection;

#region Delegate

//using System.Text;
//using System.Threading.Channels;
//Predicate

//Func<void, Student>

//List<Student> students = new List<Student>
//{
//    new Student("Eldar","Ahmadov",19),
//    new Student("Fardi","Ismayilzada",18),
//    new Student("Agil", "Kazimov",28),
//    new Student("Elshad", "Mammadov",41),
//    new Student("Gamid", "Aliyev", 38)
//};

//students.ForEach(std => Console.WriteLine(std));

//Console.WriteLine(students.Find(std => std.Age == 18));

//static bool FindStudent(Student std)
//{
//    return std.Age == 20;
//}


//Eldar methods = Add;
//methods += Difference;
//methods += (x, y) =>
//{
//    Console.WriteLine(x * y);
//};
//methods(20,10);

//Elshad methods = x =>
//{
//    Console.WriteLine("First method worked");
//    string result = "";
//    for (int i = 1; i < x.Length; i+=2)
//    {
//        result += x[i];
//    }
//    return result;
//};

//methods += x => x.Substring(2);


//Console.WriteLine(methods("Elshad"));


//int number1 = Convert.ToInt32(Console.ReadLine());
//char key = Console.ReadKey().KeyChar;
//Console.WriteLine();
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("=");
//switch (key)
//{
//    case '+':
//        Calculator(number1, number2, Add);
//        break;
//    case '-':
//        Calculator(number1, number2, Difference);
//        break;
//    case '*':
//        Calculator(number1, number2, Multiply);
//        break;
//    case '^':
//        //anonymous method
//        Calculator(number1, number2, delegate (int x, int y)
//        {
//            int result = 1;
//            for (int i = 0; i < y; i++)
//            {
//                result *= x;
//            }
//            Console.WriteLine(result);
//        });
//        break;
//    case '?':
//        //lambda expression
//        Calculator(number1, number2, (x, y) =>
//        {
//            double a = y;
//            bool result = false;
//            while (a > 1)
//            {
//                a = a / x;
//                if (a == 1)
//                {
//                    result = true;
//                    break;
//                }
//            }
//            Console.WriteLine(result);
//        });
//        break;
//    default:
//        break;
//}


//static void Calculator(int num1, int num2, Action<int, int> method)
//{
//    method(num1, num2);
//}


//static void Add(int x, int y)
//{
//    Console.WriteLine(x + y);
//}
//static void Difference(int num1, int num2)
//{
//    Console.WriteLine(num1 - num2);
//}

//static void Multiply(int num1, int num2)
//{
//    Console.WriteLine(num1 * num2);
//}

//static void Divide(int eded1, int eded2)
//{
//    Console.WriteLine(eded1 / eded2);
//}
#endregion

#region Reflection
//Console.WriteLine();
//var studentType = typeof(Student);
//foreach (var item in studentType.GetMembers())
//{
//    Console.WriteLine(item.Name);
//}
//Student valeh = new Student("Valeh","Maharrmov",19);
//valeh.GetType().GetProperty("Name").SetValue(valeh,"Abulfaz");
//Console.WriteLine(valeh);
#endregion

#region Sealed
//abstract class A
//{
//    public string Name { get; set; }
//    public abstract string GetInfo();
//}
//abstract class B : A
//{
//    public string Surname { get; set; }
//    public override string GetInfo()
//    {
//        return Name + " " + Surname;
//    }
//}
//sealed interface I
//{

//}
#endregion

#region Nullable value types
//int? number = null;
//Console.WriteLine(number ?? 20);
#endregion

#region Task
List<Exam> exams = new List<Exam>();
exams.Add(new Exam("Nargiz",70,"Proqramlashdirma",new DateTime(2024,08,27, 09,00,00), new DateTime(2024, 08, 27, 12, 13, 17)));
exams.Add(new Exam("Samir", 100, "Proqramlashdirma", new DateTime(2024, 08, 27, 09, 00, 00), new DateTime(2024, 08, 27, 09, 13, 21)));
exams.Add(new Exam("Tarxan", 21, "Proqramlashdirma", new DateTime(2024, 08, 27, 09, 00, 00), new DateTime(2024, 08, 27, 09, 00, 2)));
exams.Add(new Exam("Nihat", 75, "Proqramlashdirma", new DateTime(2024, 08, 27, 09, 00, 00), new DateTime(2024, 08, 27, 11, 13, 58)));
exams.Add(new Exam("Elshad", 101, "Proqramlashdirma", new DateTime(2024, 08, 27, 09, 00, 00), new DateTime(2024, 08, 27, 15, 13, 00)));

//1.
//exams.FindAll(x => x.Point >= 50).ForEach(x => Console.WriteLine($"{x.StudentName} {x.Subject} {x.Point} {x.EndDate - x.StartDate}"));

//exams.FindAll(x => x.StartDate >= DateTime.Now.AddDays(-7)).Print();

exams.FindAll(x => (x.EndDate - x.StartDate).TotalMinutes >= 60).Print();
#endregion