using System.Text;

namespace _01_IntroToC_
{
    
    class Program
    {

        static void Literals()
        {
            Console.WriteLine((10).GetType());  
            Console.WriteLine((10D).GetType()); 
            Console.WriteLine((10f).GetType()); 
            Console.WriteLine((10m).GetType()); 
            Console.WriteLine((10L).GetType()); 
            Console.WriteLine((10UL).GetType());
            Console.WriteLine(0xFF);            
        }
        static void ConsoleMethods()
        {
            
            Console.Title = "Приклад використання метолів класу Console";

            Console.BackgroundColor = ConsoleColor.Green;

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);

            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            Console.ResetColor();
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());

            Console.Write("Enter a simpe message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Your message is: " + message);
            Console.Beep(300, 3000);
            Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }
        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Деяке повідомлення \nІ ще " +
                "одне просте повідомлення  " +
                "в новому рядку" +
                "ще якийсь текст");

            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");



            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
        }

        static void Task1()
        {
            //some code
        }

        static void Main(string[] args)
        {
            int NUMBER = int.Parse(Console.ReadLine()!);
            Task1();
            // Literals();
            //ConsoleMethods();
            FormatString();
            //const int UK = 380;
            //const int USA = 107;
            //const int Poland =407;
            //enum Name { UK=380, USA, Poland };  
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.Write("Hello\n");
            //Console.Write("\t\tHello\n");
            //Console.Write("\"Hello\"");
            //Console.Write("\\Hello\\");
            //Console.Write("Hello");
            //Console.Write("Hello");
            //Console.Write("Hello");
            //Console.WriteLine("Hello");


            //object obj = new object();

            //int a = 5;
            //Int32 b = 16;
            //int c = 16;
            //// cw + TAB
            //Console.WriteLine(a);

            //short g = 9;
            //ushort u = 7;

            //float t = 3.14f;
            //Single p = 3.33f;

            //double n = 2.22d;
            //Double d = 1.25;

            //decimal s = 1.14m;

            //char o = 'a';
            //bool flag = false;

            ////Console.WriteLine("Enter number : ");
            ////string str = Console.ReadLine()!;
            ////int number = int.Parse(str);
            ////Console.WriteLine("Number : " + number);
            ////Console.WriteLine("Number : " + number + 100);
            ////Console.WriteLine("Number : " + number + 100 + "!!!");
            ////Console.WriteLine("Number : " + (number + 100) + "!!!");
            ////Console.WriteLine($"Number : {number + 100} !!!");
            ////Console.WriteLine(100.ToString());

            ////Nullable data types --- Not nullable

            //string message = null;
            //message = "mesaage";

            ////Nullable< int> r = null;
            //int? r = null;
            //r = 77;

            //Console.OutputEncoding = Encoding.UTF8;
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            //Console.WriteLine($"ToLongDateString {now.ToLongDateString()}");
            //Console.WriteLine($"ToLongTimeString {now.ToLongTimeString()}");
            //Console.WriteLine($"ToShortDateString {now.ToShortDateString()}");
            //Console.WriteLine($"ToShortTimeString {now.ToShortTimeString()}");
            //Console.WriteLine($"ToString {now.ToString("yyyy/MM/dd")}");


            //float f1 = 4.5f;
            //int i1 = 44;

            // float f2 =  f1 + i1;//4.5 + 44 = 48.50000000;

            //double d1 = f2;//48.5000000000000000;

            /////int i2 = d1;//48  error implicit
            //int i2 = (int) d1;//48  error explicit


            //string t1 = null;
            //string t2 = t1;

            //if (t1 != null)
            //    t1.ToUpper();
            ////? null-conditional operator (not null)
            //t1?.ToUpper();

            ////--1 
            //t2 = (t1 == null) ? "Error" : t1;
            ////--2
            //if( t1 == null)
            //{
            //    t2 = "Empty";
            //}
            //else
            //{
            //    t2 = t1;    
            //}
            ////--3 ?? null-conditional operator 
            //t2 = t1 ?? "Empty";

            ////Random
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(-100,100));
            //}
            //Console.WriteLine(random.NextDouble());//0...1
            //Console.WriteLine(random.Next());//0...maxInt
            //Console.WriteLine(random.Next(100));//0...99
            //Console.WriteLine(random.Next(10,100));//10...99

            //if (true)
            //{

            //}
            //else
            //{

            //}

            //Console.BackgroundColor = ConsoleColor.Green;   

            //ConsoleColor color  = ConsoleColor.White;

            //switch (color)
            //{
            //    case ConsoleColor.Black:Console.WriteLine("Black");break;
            //    case ConsoleColor.DarkBlue: Console.WriteLine("DarkBlue"); break;
               
            //    default:
            //        break;
            //}

            //while (true)
            //{

            //}
            //do
            //{

            //} while (true);
        }
    }
}




