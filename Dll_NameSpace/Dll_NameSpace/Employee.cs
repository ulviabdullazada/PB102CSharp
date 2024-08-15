using CL;
namespace Dll_NameSpace;
internal class Employee : Person
{
    public decimal Salary { get; set; }
    public Employee()
    {
        Name = "John";
        Surname = "Doe";
    }
}
