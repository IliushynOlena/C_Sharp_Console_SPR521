using System.Globalization;
using System.Runtime.CompilerServices;

namespace _03_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str = "some name";//9b

            string fname, lname;//fname = null; lname = null;
            fname = "Oleg";
            lname = "Nikituk";

            string fullname = fname + " bla bla bla " + lname;
            Console.WriteLine($"Full name : {fullname}");

            char[] letter = { 'H', 'e', 'l', 'l','o','!' };
            Console.WriteLine($"Lenght letters : {letter.Length}");
            string greeting = new string(letter, 2, 3);
            Console.WriteLine($"Greetings : {greeting}");


            string[] arr_words = { "Hello", "Goodbye", "Point", "Tree" };
            string message = string.Join(" - ", arr_words);
            Console.WriteLine($"Message : {message}");


            string []words = message.Split(new string[] {" - "}, StringSplitOptions.None);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string mess = "Lorem Ipsum is simply dummy text of the printing " +
                "and typesetting industry. Lorem " +
                "Ipsum has been the industry's standard dummy" +
                " text ever since the 1500s, when an unknown " +
                "printer took a galley of type and scrambled" +
                " it to make a type specimen book. It has survived" +
                " not only five centuries, but also the leap into" +
                " electronic typesetting, remaining essentially unchanged.";
            Console.WriteLine(mess.Length);
            string []w = mess.Split(new char[] { ' ',',','.','!','?',':','\n'},
                 StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(w.Length);
            //foreach (var item in w)
            //{
            //    Console.WriteLine($"|{item}|");
            //}


            //ConsoleKeyInfo key = Console.ReadKey();
            //if  (key.Key == ConsoleKey.F12)
            //{
            //    Console.WriteLine("F12 - Have a nice day !");
            //}


            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow);
            Console.WriteLine(dateNow.ToShortDateString());
            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine(dateNow.ToShortTimeString());
            Console.WriteLine(dateNow.ToLongTimeString());
            Console.WriteLine(dateNow.ToString("yyy.MM.dd"));
            Console.WriteLine(dateNow.ToString("yyy/MM/dd"));
            Console.WriteLine(dateNow.ToString("yyy-MM-dd"));
            Console.WriteLine(dateNow.ToString("HH:mm:ss"));

            DateTime vacation = new DateTime(2026, 07, 27);

            TimeSpan timeSpan = vacation - dateNow;
            Console.WriteLine(timeSpan);
            Console.WriteLine($"Days :{timeSpan.Days}");
            Console.WriteLine($"Hours : {timeSpan.Hours}");
            Console.WriteLine($"Minutes : {timeSpan.Minutes}");
            Console.WriteLine($"Seconds : {timeSpan.Seconds}");
            Console.WriteLine($"Milliseconds : {timeSpan.Milliseconds}");


            Console.WriteLine($"TotalDays : {timeSpan.TotalDays}"); 
            Console.WriteLine($"TotalHours : {timeSpan.TotalHours}"); 
            Console.WriteLine($"TotalMinutes : {timeSpan.TotalMinutes}"); 
            Console.WriteLine($"TotalSeconds : {timeSpan.TotalSeconds}"); 
            Console.WriteLine($"TotalMilliseconds : {timeSpan.TotalMilliseconds}");


            decimal money = 43.20m;
            //CultureInfo us = new CultureInfo("uk-UA");
          //CultureInfo us = new CultureInfo("en-US");
            CultureInfo us = new CultureInfo("es-HN");
            string price = $"Total summa of product : {money.ToString("C2",us)}";
            Console.WriteLine(price);

            //Methods
            string nullStr = null;

            //nullStr.ToUpper();

            if (nullStr != null)
                nullStr.ToUpper();
            //null conditional operator
            nullStr?.ToLower();

            string emptyStr = "";
            Console.WriteLine(emptyStr.Length);
            if( string.IsNullOrEmpty(emptyStr) )
            {
                Console.WriteLine("Is null or empty");
            }
            string str2 = "              ";
            Console.WriteLine(str2.Length);
            if (string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("IsNullOrWhiteSpace");
            }
            
            // Comparing 2 strings 
            string str1 = "This is test";
            string str3 = "This is test";

            if (string.Compare(str1, str3) == 0)
            {
                Console.WriteLine(str1 + " and " + str3 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str3 + " are not equal.");
            }


            //String Contains String:
            string str4 = "This is testing";
            if (str4.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            //Getting a Substring:
            string str41 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str41);
            string substr = str41.Substring(23, 4);
            Console.WriteLine(substr);



            //C / c
            //Задаємо грошові одиниці , вказуючи кількість цифр після коми
            //
            //D / d
            //Цілочисельний формат, де ми вказуємо максимальну кількість цифр (5)
            //
            //  00015
            //  00155
            //  01478
            //  00587
            //
            //E / e
            //Кількість цифр після коми
            //
            //F / f
            //Кількість цифр після коми
            //
            //G / g
            //Вибирає більш короткий варіант : F або E
            //
            //
            //P / p
            //Задает відображення знаку відсотків поряд з числом
            //
            //X / x
            //Шестнадцятковий формат числа
            int number = 23;
            Console.WriteLine(number);
            
            Console.WriteLine("Number : " + number.ToString());

            Console.WriteLine($"Number : {number}");

            Console.WriteLine("Number : {0:d5}, {1}, {2}",100, 200, "Hello");
         
            Console.WriteLine("Number : {0:d4}. {1}", number, "Hello");
          
            Console.WriteLine("Number {0:d2}", number);

            string result = String.Format("Number: {0:d5}", number);
            //Console.ReadKey();
            Console.WriteLine(result); // 23
            //string result2 = String.Format("{0:d4}", number);
            //interpolation
            string result2 = $"Number : {number:d4}";
            // string result2 = $"Number : {number, 15}";
            Console.WriteLine(result2); // 0023
            //Console.ReadKey(); // pause


            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00
            //Console.ReadKey(); // pause

            double number2 = 45.086546546545;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:F4}";
            Console.WriteLine(result3); // 45,0800
            //Console.ReadKey(); // pause

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10
                                        //Console.ReadKey(); // pause

            var someDir = "a";
            Console.WriteLine(@$"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");

            Console.WriteLine($"Name: {"Ivan",-10} Age: {23,10}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",-10} Age: {34,10}"); // spaces after


            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = System.String.Concat(s3, "!!!"); // = string "hello world!!!"
            Console.WriteLine(s4);

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s11.IndexOf(subString); // = 6
            Console.WriteLine(indexOfSubstring);
            Console.ReadKey();

            string s12 = " ? Me tengo?!, To be honest!!!   ";
            //s12 = s12.Trim();

          
            
            s12 = s12.Trim(new char[] { '?', ' ', '!' });

            Console.WriteLine($"After trimming: /{s12}/");

            Console.ReadKey();

        }
    }
}
