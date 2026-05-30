namespace _11_Interfaces
{
    //class Name,  absract class Name2,  interface Name3

    interface IWorker
    {
        //public
        string Work();//empty methods (public)
        bool IsWorking { get; }//empty properties
        //private int number;//can*t create private fields
        event EventHandler WorkEnded;

    }


    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"Full Name : {FirstName}  {LastName}\n" +
                $"Birthdate : {Birthdate.ToShortDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Position : {Position}. Salary : {Salary}";
        }
    }
    interface IWorkable
    {
        string Work();
        bool IsWorking { get; }
    }
    interface IManager
    {
        List<IWorkable> ListWorkers { get; set; }
        void Organize();
        void MakeBudject();
        void Control();
    }

    //Director : Employee - inheriatance
    //Director :  IManager - implementation/realization
    class Director : Employee, IManager
    {
        public List<IWorkable> ListWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("I constrol work all workers");
        }

        public void MakeBudject()
        {
            Console.WriteLine("I count money!!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work!");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I get pay for products!";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {

        public bool IsWorking => true;

        public List<IWorkable> ListWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("Xaxaxaxaxa. I am a BOSS!");
        }

        public void MakeBudject()
        {
            Console.WriteLine("I have many money!!!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I am a Boss. A organize work!"); ;
        }

        public string Work()
        {
            return "I am manager. I do my work!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director()
            {
                FirstName = "Oleg",
                LastName = "Ilchuk",
                Birthdate = new DateTime(1995, 5, 5),
                Position = "Director",
                Salary = 45000
            };
            Console.WriteLine(director);

            director.Organize();
            director.MakeBudject();
            director.Control();
            director.ListWorkers = new List<IWorkable>() {
            new Seller()
                {
                    FirstName = "Olga",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2001, 12, 1),
                    Position = "Seller",
                    Salary = 8500
                },
                 new Seller()
                {
                    FirstName = "Maria",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2004, 12, 1),
                    Position = "Seller",
                    Salary = 9200
                }
            };

            foreach (var w in director.ListWorkers)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("Administrator");

            //Інтерфейсні посилання
            Administrator administrator = new Administrator() 
            //IWorkable administrator = new Administrator() 
            //IManager administrator = new Administrator() 
            {
                FirstName = "Ivan",
                LastName = "Popchuk",
                Birthdate = new DateTime(1990, 4, 15),
                Position = "Administrator",
                Salary = 25000

            };
            Console.WriteLine(administrator);
            //Console.WriteLine(administrator.Work());;
            administrator.Organize();
            administrator.MakeBudject();
            administrator.Control();

            IWorkable seller = new Seller()
            {
                FirstName = "Maria",
                LastName = "Tomson",
                Birthdate = new DateTime(2004, 12, 1),
                Position = "Seller",
                Salary = 9200
            };
            //seller.Salary = 100000;
           // Console.WriteLine(seller.Salary);
            Console.WriteLine(seller);
            Console.WriteLine(seller.Work());

            if (seller is Seller )
            {
                (seller as Seller)!.Salary = 15000;
                Console.WriteLine(seller);
            }

            //Multipli Interfaces
            Administrator admin = new Administrator();//admin = xc2z1x3c2zx1c32zx

            IWorkable worker = admin;//worker = xc2z1x3c2zx1c32zx
            worker.Work();
            //worker.IsWorking = false;

            IManager manager = admin;//manager = xc2z1x3c2zx1c32zx
            manager.Organize();
            manager.MakeBudject();
            manager.Control();

        }
    }
}
