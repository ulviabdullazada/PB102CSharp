using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Delegate;
/*
Exam class

 - StudentName
 - Point
 - Subject
 - StartDate
 - EndDate


Exams siyahisi duzeldirsiniz
Butun examleri daxil etdikden sonra console-da asagidaki siyahilari gosterirsiniz:
- pointi 50-den cox olan examlarin siyahisini gosterirsiniz
- son 1 hefte erzinde olan examlarin siyahisini gosterirsiniz
- 1-saatdan uzun ceken imtahanlarin siyahisi


Siyahilari gosterende asagidaki datalari gosterirsiniz her bir siyahi ucun
 - StudentName Subject  Point Duration
*/
class Exam
{
    public string StudentName { get; set; }
    public int Point { get; set; }
    public string Subject { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Exam(string name, int point, string subject, DateTime startDate, DateTime endDate)
    {
        StudentName = name;
        Point = point;
        Subject = subject;
        StartDate = startDate;
        EndDate = endDate;
    }
}
