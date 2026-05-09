namespace _05_IntroToOOP
{

    class MyClass
    {
        //class body
        //c-tor
        //properties
        //methods
    }
    partial class Point
    {

        private int number;
        private const float PI = 3.14f;
        //private readonly int Id;
        //public Point()
        //{
        //    Id = 10;
        //}
        //void setId(int id)
        //{
        //    Id = id;
        //}
        private int x;
        //Properties
        public int X//value 
        {
            get { return this.x; }
            set
            {
                if (value > 0)
                    this.x = value;
                else
                    this.x = 0;
            }
        }
        private int y;
        //propfull + TAB --> full property
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        public string Name { get; set; }
        //Auto property ---> prop + TAB
        //public string Name { get; set; }

        private decimal salary;
        public decimal Salary//value
        {
            get { return salary; }
            set 
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                    salary = 0;
            }
        }
        //readonly
        public string Color { get; } = "Orange";

        static int count;
        static Point()
        {
            count = 0;
        }

        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            //setX(x);
            X = x;
            setY(y);
            count++;
        }
       
        

       
    }
    class DerivedClass : MyClass//public
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5,18);
            point.X = 55;//setter  int value  = 55;
            Console.WriteLine(point.X);//getter
            point.PrintNew();
            point.Print();
            Console.WriteLine(point.ToString());
            point.setX(55);
            Console.WriteLine(point.ToString());
            Console.WriteLine(point.getX());

            //point.x = 100;//error
            point.X = 555;//setter (value = 555)
            Console.WriteLine(point.X);//getter

            //point.Color = "Red";
            point.Salary = 15000;

            Console.WriteLine(point.Color);
            Console.WriteLine(point.Salary);

            Char.IsUpper('a');
        }
    }
}


namespace _05_IntroToOOP
{
    partial class Point
    {
        public void PrintNew()
        {
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"X : {X}");
            Console.WriteLine($"Y : {y}");
        
        }
    }
}
