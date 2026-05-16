using System.Collections;
using System.Runtime.Serialization;

namespace _07_Exeptions
{
    class MyClass
    {
        public void BadMethod()
        {
            Exception exception = new Exception("My Exeption message");
            exception.HelpLink = "https://google.com";
            exception.Data.Add("Exception reason : ", "Test system");
            exception.Data.Add("Time invocation : ", DateTime.Now);
            exception.Data.Add("User name : ", "Olena");
            throw exception;
        }
    }
    class LoginExeption : Exception
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public LoginExeption()
        {
           //Time = DateTime.Now;
        }

        public LoginExeption(string? message) : base(message)
        {
            //Time = DateTime.Now;
        }

        public LoginExeption(string? message, Exception? innerException) : base(message, innerException)
        {
            //Time = DateTime.Now;
        }

        protected LoginExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    class User
    {
        private string login;
        public string Login
        {
            get { return login; }
            set {
                if (value == "")
                    throw new LoginExeption("Login is invalid...");
                else
                    login = value;
            }
        }
    }
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("My Exception!");
        }
    }
    internal class Program
    {
        static double SafeDivision(double a, double b)
        {
            if( b == 0)
            {
                throw new DivideByZeroException("Second operand = 0");
            }
            return a / b;   
        }
        static void Main(string[] args)
        {
            #region Example 1
            /*
            int a = 1, b = 2;

            //string str = null;
            //str.ToUpper();

            //try catch finally  throw
            try
            {
                Console.WriteLine("Enter number a : ");
                //a = int.Parse(null);
                a = int.Parse(Console.ReadLine()!);//""     null
                Console.WriteLine("Enter number b : ");
                b = int.Parse(Console.ReadLine()!);

                a = a / b;
                Console.WriteLine($"Res : {a}");

            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Can't divide by zero....Study Math!!!");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("To large number");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You must enter number");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("ArgumentNullException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            Console.WriteLine("Continue.............");
            */


            #endregion
            #region Example 2
            /*
            double a = 85, b = 0, res = 0;
            try
            {
                res = SafeDivision(a, b);
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Can't divide by zero....Study Math!!!");

            }
            */
            #endregion
            #region Example 3
            /*
            try
            {
                MyClass myClass = new MyClass();
                myClass.BadMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Member name : {e.TargetSite}");
                Console.WriteLine($"Member class : {e.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type : {e.TargetSite.MemberType}");
                Console.WriteLine($"Method name : {e.TargetSite.Name}");
                Console.WriteLine($"Message : {e.Message}");
                Console.WriteLine($"Source : {e.Source}");
                Console.WriteLine($"Help Link : {e.HelpLink}");
                Console.WriteLine($"Stack Trace : {e.StackTrace}");
                foreach (DictionaryEntry dic in e.Data)
                {
                    Console.WriteLine($"{dic.Key} -- {dic.Value}");
                }
               
            }
            */
            #endregion
            #region Example 4
            /*
            User user = new User();

            try
            {
                user.Login = "";
            }
            catch (LoginExeption ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Time);
            }*/
            #endregion
            #region Example 5
            try
            {
                throw new UserException();
            }
            catch (UserException userException)
            {
                Console.WriteLine("Exception catch!.");
                userException.Method();
                FileStream fs = null;
                try
                {
                    fs = File.Open(@"C:\NonExistentFile.log", FileMode.Open);
                    //write

                    //....exception 

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);

                }
                finally
                {
                    //fs.Close();
                    Console.WriteLine("End inner try");
                }

            }
            finally
            {
                Console.WriteLine("End outer try");
            }
            #endregion
        }
    }
}
