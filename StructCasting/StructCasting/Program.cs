#region Struct
//Console.WriteLine("Hello");

//Array
//Int32
//ClassA classA = new();
//StructA structA = new();
//classA.Num = 50;
//Console.WriteLine(classA.Num);

//structA.Hi();
//Console.WriteLine(structA.Num);
#endregion
#region Enum
//Console.WriteLine("Heftenin gununu daxil edin");


//string dayOfWeek = Console.ReadLine();
//var result = Enum.GetName(typeof(Weekdays), dayOfWeek);
//var result = Enum.Parse(typeof(Weekdays), dayOfWeek);
//Console.WriteLine(Convert.ToInt32((Enum)result));
#endregion
#region Tuple
//int num = Convert.ToInt32(Console.ReadLine());
//var result = TupleExam.CheckWeekDayWithTuple(num);
//if (result.Item1)
//{
//    Console.WriteLine("Heftenin gunu dogrudur");
//    Console.WriteLine(result.Item2);
//}
//else
//{
//    Console.WriteLine("Heftenin gunu yalnisdir");
//}

//(int num, string) a = new(10,"Salam");
//Console.WriteLine(a.num);
#endregion
#region Record
//PersonClass person = new PersonClass(); //0x0002
//person.Name = "Eldar";
//person.Surname = "Ahmadov";

//PersonClass person2 = new PersonClass();//0x0120
//person2.Name = "Eldar";
//person2.Surname = "Ahmadov";

//Console.WriteLine(person == person2);

//PersonRecord person3 = new PersonRecord("Eldar", "Ahmadov");

//PersonRecord person4 = person3;


//PersonRecord person5 = person3 with { Name = "Mahammad" };

//Console.WriteLine(person5);

//PersonRecord person1 = new PersonRecord()
//{
//    Name = "Sultan",
//    Surname = "Soltanli"
//};
//PersonRecord person2 = person1;

//person1.Name = "Mahammad";

//Console.WriteLine(person2);
#endregion

