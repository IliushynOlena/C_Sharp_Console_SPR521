using System.Text;

namespace _04_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");


            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");


            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            message += "blalalalala";
            Console.WriteLine(message);
            Console.WriteLine($"Lenght : {message.Length}");

            StringBuilder  builder = new StringBuilder(200);
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);

            builder.AppendLine("Hello");
            builder.AppendLine("Hello");
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            builder.AppendLine("Hello");
            builder.AppendLine("Hello");
            builder.AppendLine("Hello");
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            Console.WriteLine(builder);
        }
    }
}
