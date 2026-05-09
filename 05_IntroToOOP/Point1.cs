namespace _05_IntroToOOP
{
    partial class Point
    {
        public void Print()
        {
            Console.WriteLine($"X : {x}. Y : {y}");
        }
        public override string ToString()
        {
            return $"X : {x}. Y : {y}";
        }
    }
}
