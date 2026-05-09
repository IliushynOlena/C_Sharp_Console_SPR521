namespace _06_StructClassRefOutParams
{
    //Access Spetificators
    //private
    //public
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        //have hide default constructor
        public Point(int x, int y)
        {
            X = x; 
            Y = y;   
        }
        public void Print()
        {
            Console.WriteLine($" X : {X}. Y : {Y}");
        }
    }
    class Time
    {
        private int h;

        public int H
        {
            get { return h; }
            set 
            {
                if (value >= 0 && value < 25)
                    h = value;
                else
                    throw new Exception("Inncorrect hours....");
            }
        }


        public int M { get; set; }
        public int S { get; set; }
        public Time(int h, int m, int s)
        {
            H = h;
            M = m;
            S = s;
        }
        public void Print()
        {
            Console.WriteLine($"H : {H}. M : {M}. S : {S}");
        }
    }
    internal class Program
    {
        //params
        static void MethodWithParams(string name, float averageMark,params int[]marks)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Average mark : {averageMark}");
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }

        static void Modify(ref int num, ref string str, ref Time t)
        {
            num += 1;
            str += "!!!";
            t.H++;
            t.M++;
            t.S++;
        }
        static void GetCurrentTime(out int h, out int m, out int s)
        {
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;
          
        }

        static void Main(string[] args)
        {
            /*OUT parameter - передає аргумент як оригінал*/
            int h, m ,s;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurrentTime(out h, out m, out s);
            Console.WriteLine($"{h}:{m}:{s}");

            /*Ref parameter - передає аргумент як оригінал*/
            int num = 10;
            string str = "Hello academy";
            Time t = new Time(1, 1, 1);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Time : ");
            t.Print();
            Modify(ref num,ref  str,ref t);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Time : ");
            t.Print();

            Time[] times = new Time[5];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = new Time(0, 0, 0);

                try
                {
                    times[i].H = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }

            /*//Params
            int[] marks = { 11, 12, 8, 9, 6, 12 };
            //MethodWithParams("Bob", 9.6f,marks);
            //MethodWithParams("Tom",5.3f, new int[] {1,2,3,4,2,3,6,4,5});
            MethodWithParams("Olga", 4, 5, 6, 4, 5, 6,  4, 5, 6, 10,11,11,11);
            */
            /*
            Point @struct = new Point();
            @struct.X = 100;

            Point p = new Point(10,5);//value --> new --> invoke default constructor
            Time time = new Time(22,15,33);//references ---> new create dynamic memory
            p.Print();
            time.Print();

            int a;

            Point p2;// invoke default constructor
            Time t2;// = new Time(2,2,2);
            */
        }
    }
}
