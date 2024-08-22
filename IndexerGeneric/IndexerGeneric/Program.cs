//using IndexerGeneric;
//using System.Collections;

//Group pb102 = new Group();

//var eldar = pb102[0];
//pb102[1] = eldar;
//var hemid = pb102[1];

//Console.WriteLine($"{hemid.Id} {hemid.Name} {hemid.Surname}");

//LinkedList<Student> students = new LinkedList<Student>();
using IndexerGeneric;

var fadila = new Student()
{
    Name = "Fadila",
    Surname = "Karimli"
};
var fardi = new Student()
{
    Name = "Fardi",
    Surname = "Ismayilzada"
};
var samir = new Student()
{
    Name = "Samir",
    Surname = "Naci"
};
//students.AddFirst(fadila);
//students.AddLast(fardi);
//students.AddFirst(samir);
//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}
//Queue queue = new Queue();
//queue.Enqueue(fadila);
//queue.Enqueue(fardi);
//queue.Enqueue(samir);
//Console.WriteLine(
//    ((Student)queue.Dequeue()).Name
//    );
//Stack stack = new Stack();
//stack.Push(fardi);
//stack.Push(samir);  
//stack.Push(fadila);
//Console.WriteLine(
//    ((Student)stack.Pop()).Name
//    );
//Console.WriteLine(
//    ((Student)stack.Peek()).Name
//    );
//Console.WriteLine(
//    ((Student)stack.Peek()).Name
//    );
//Dictionary<string, string> hi = new Dictionary<string, string>();
//hi.Add("en", "Hello");
//hi.Add("az", "Salam");
//hi.Add("tr", "Merhaba");
//Console.WriteLine(hi["az"]);
//Dictionary<int, string> students =  new Dictionary<int, string>();
//students.Add(1,"Fardi");
//students.Add(212,"Nihat");
//Console.WriteLine(students[212]);


//IntList list = new IntList(typeof(string), 12);
//list.Add(1);
//list.Add(12);
//list.Add(30);
//list.Add("Salam");
//Console.WriteLine(list);
//GenericList<string> list = new GenericList<string>();
//list.Add("Salam");
//Console.WriteLine(list);
//GenericList<Student> students = new GenericList<Student>();
//students.Add(fadila);
//students.Add(fardi);
//students.Add(samir);
//students.Add("Salam");
//Console.WriteLine(students);
//CustomDictionary<int, string> myDictionary = new CustomDictionary<int, string>();
//myDictionary.Add(1, "Salam");
//myDictionary.Add(2, "Necesen");
//myDictionary.GetDatas();
//GenericList<int> list = new GenericList<int>();
//list.Add(123);

int a = 22;
Increase(a);
Console.WriteLine(a);


static void Increase(in int num)
{
    num = 123;
    Console.WriteLine(num);
}

