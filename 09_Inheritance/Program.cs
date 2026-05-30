using System.Security.Cryptography.X509Certificates;

namespace CSharp;


abstract class Person// : Object
{
    protected string name;
    private readonly DateTime birthdate;
    public Person()
    {
        name = "no name";
        birthdate = new DateTime();//01.01.0001
    }
    public Person(string n, DateTime b)
    {
        name = n;
        if( b > DateTime.Now)
        {
            birthdate = new DateTime();
        }
        else
        {
            birthdate = b;
        }
    }
    public virtual void Print()
    {
        Console.WriteLine($"Name : {name}. " +
            $"Birth : {birthdate.ToShortDateString()}");
    }
    public abstract void DoWork();
    public override string ToString()
    {
        return $"Name : {name}. " +
            $"Birth : {birthdate.ToShortDateString()}";
    }
}
//class Child : BaseClass, Interface1, Interface2, Interface3
class Worker :  Person // public 
{
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { this.salary = value > 0 ? value : 0; }
    }
    public Worker(): base()
    {
        salary = 0;
    }
    public Worker(string n, DateTime b, decimal s):base(n, b) 
    {    
        Salary = s;
    }
    public override void DoWork()
    {
        Console.WriteLine("Doing some work!!!!");
    }
    //new or override
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Salary : {Salary}");
    }
}
sealed class Programmer : Worker
{
    public int CodeLines { get; set; }
    public Programmer(): base()
    {
           CodeLines = 0; 
    }
    public Programmer(string n, DateTime b, decimal s): base(n,b,s)
    {
        CodeLines = 0;
    }
    public sealed override void DoWork()
    {
        Console.WriteLine("Write C# code!");
    }
    public void WriteCodeLines()
    {
        CodeLines++;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Write code lines : {CodeLines}");
    }
}

//sealed - метод заборонений до перевизначення 
class TeamLead : Worker
{
    public int ProjectCount { get; set; }
    //public override void DoWork()
    //{
    //    Console.WriteLine("Manage Team projects");
    //}
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker("Misha", new DateTime(2000,12,5), 15000);
        worker.Print();

        Programmer pr = new Programmer("Petya",new DateTime(1999,5,5), 45000);
        pr.Print();
        pr.WriteCodeLines();
        pr.WriteCodeLines();
        pr.WriteCodeLines();
        pr.Print();

        Person[] people = new Person[]
        {
            //new Person(),
            worker,
            new Programmer("Petya",new DateTime(1999,5,5), 45000)
        };
        //virtual override
        foreach (var person in people)
        {
            Console.WriteLine("-------------Info----------------");
            person.Print();
            Console.WriteLine();
            person.DoWork();
        }

        Programmer p = null;

        //------------ 1 - --- use cast ()

        try
        {
            p = (Programmer)people[0];
            p.DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //--------------- 2 ----    use as
        p = people[0] as Programmer;
        if (p == null)
            Console.WriteLine("reference empty");
        else
            p.DoWork();

        //--------------3- --  use IS and AS

        if (people[1] is Programmer)
        {
            p = people[1] as Programmer;
            p.DoWork();
        }
        else Console.WriteLine("Incorrect type");

    }
}