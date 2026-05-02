namespace _05_IntroToOOP
{

    class MyClass
    {
        //class body
        //c-tor
        //values
        //methods
    }
    //private
    //protected
    //public
    //internal
    //protected internal
    class Point
    {

        //private int number;
        //private const float PI = 3.14f;
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
        //propfull + TAB + full property
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property ---> prop + TAB
        public string Name { get; set; }

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
        public string Color { get; set; }



        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            //setX(x);
            X = x;
            setY(y);
        }
        public void setX(int newX)
        {
            if( newX > 0)
                 this.x = newX; 
            else
                 this.x = 0; 
        }
        public void setY(int newY)
        {
            if (newY > 0)
                this.y = newY;
            else
                this.y = 0;
        }
        public int getX() { return this.x; }  
        public int getY() { return this.y; }  
        

        public void Print()
        {
            Console.WriteLine($"X : {x}. Y : {y}");
        }
        public override string ToString()
        {
            return $"X : {x}. Y : {y}";
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
            point.Print();
            Console.WriteLine(point.ToString());
            point.setX(55);
            Console.WriteLine(point.ToString());
            Console.WriteLine(point.getX());

            //point.x = 100;//error
            point.X = 555;//setter (value = 555)
            Console.WriteLine(point.X);//getter

            point.Color = "Red";
            point.Salary = 15000;

            Console.WriteLine(point.Color);
            Console.WriteLine(point.Salary);

            Char.IsUpper('a')
        }
    }
}
