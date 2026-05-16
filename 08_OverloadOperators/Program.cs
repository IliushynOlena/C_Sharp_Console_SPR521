namespace _08_OverloadOperators
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }
        //public static return_type operator [symbol](parameters)
        //{  code.... }
        #region Uno operators  - (-5) ++ --
        public static Point operator - (Point p)
        {
            Point res = new Point() 
            { 
               X = -p.X,
               Y = -p.Y,
            };
           
            return res ;
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Binary operators + - * /
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y,
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y,
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y,
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y,
            };
            return res;
        }

        #endregion
        #region Logic operators
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X== p2.X && p1.Y == p2.Y;  
        }
        //in  pair
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.X +  p1.Y ) > (p2.X + p2.Y);
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.X + p1.Y) < (p2.X + p2.Y);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.X + p1.Y) >= (p2.X + p2.Y);
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.X + p1.Y) <= (p2.X + p2.Y);
        }
        #endregion
        #region true/false operators
        public static bool operator true(Point p1)
        {
            return (p1.X > 0 && p1.Y > 0);    
        }
        //in pair
        public static bool operator false(Point p1)
        {
            return p1.X < 0 || p1.Y < 0;
        }

        #endregion
        #region Overload types
        public static explicit operator int(Point p1)
        {
            return p1.X + p1.Y;
        }
        //public static implicit operator int(Point p1)
        //{
        //    return p1.X + p1.Y;
        //}
        public static implicit operator Point_3D(Point p1)
        {
            return new Point_3D(p1.X, p1.Y, p1.X+p1.Y);
        }


        #endregion
    }
    class Point_3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D() : this(0, 0,0) { }
        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {




            int a = 5;//int --> int
            double d = 3.6;//double ---> double

            d = a;//int ---> double 5.0000000000000000 (IMPLICIT)   
            a = (int)d;//double ----> int 3  explicit


            int b = 4;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);

            Point p1 = new Point(5, 5);
            Console.WriteLine("------------------Overload int");
            a = (int)p1;
            Console.WriteLine(a);

            Point_3D p3 = p1;
            Console.WriteLine(p3);

            Point p2 = new Point(7, 4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1++);
            Console.WriteLine(++p1);
            Console.WriteLine(p1--);
            Console.WriteLine(--p1);
            Console.WriteLine(p1+p2);
            Console.WriteLine(p1-p2);
            Console.WriteLine(p1*p2);
            Console.WriteLine(p1/p2);

            Console.WriteLine("-------------------");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if ( p1 == p2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not equals");
            }
            if (p1 > p2)
            {
                Console.WriteLine("p1 > p2");
            }
            else
            {
                Console.WriteLine("p1 < p2");
            }
            if (p1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
