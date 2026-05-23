using System;
using System.ComponentModel.Design;

namespace _10_Indexers
{
    class Laptop
    {
        public string Mark { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Mark : {Mark}. Price : {Price}";
        }
    }
    class Shop
    {
        private Laptop[] laptops;
        public Shop(int size)//5
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop GetLaptop(int index)//2000
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            else
                throw new IndexOutOfRangeException();

        }

        public void SetLaptop(Laptop laptop, int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }
            else
                throw new IndexOutOfRangeException();
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set //VALUE
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[string name]//HP
        {
            get
            {
                //readonly
                foreach (var laptop in laptops)
                {
                    if (laptop.Mark == name)
                        return laptop;
                }
                return null;
            }
            //private set //value
            //{
            //    for (int i = 0; i < laptops.Length; i++)
            //    {
            //        if(laptops[i].Mark == name)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }

            //}
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price) return i;

            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Inncorect price");
            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    this[index] = value;
                }
            }
        }
    }
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultArray multArray = new MultArray(2, 3);

            //for (int i = 0; i < multArray.Rows; i++)
            //{
            //    for (int j = 0; j < multArray.Cols; j++)
            //    {

            //        multArray[i, j] = i + j;//indexator - set
            //        Console.Write($"{multArray[i, j]} ");//indexator - get
            //    }
            //    Console.WriteLine();
            //}

            Shop shop = new Shop(3);
            shop.SetLaptop(new Laptop() { Mark = "HP", Price = 25000 }, 0);
            Console.WriteLine(shop.GetLaptop(0));

            shop[1] = new Laptop() { Mark = "Asus", Price = 35000 };
            Console.WriteLine(shop[1]); 
            int[] arr = new int[3];
            arr[0] = 100;
            Console.WriteLine(arr[0]);
            Console.WriteLine("-------------- [string name ]----------");
            //shop["HP"] = new Laptop() { Mark = "Mac", Price = 100000 };
            Console.WriteLine(shop["HP"]);

            shop[25000.0] = new Laptop() { Mark = "HP", Price = 19999 };
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine(shop[i]);
            }
            Console.WriteLine(shop[(double)19999]);
        }
    }
}
