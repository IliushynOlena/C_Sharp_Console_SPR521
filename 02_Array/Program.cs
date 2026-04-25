namespace _02_Array
{
    class Program
    {
        static void PrintArray(string text, int[]arr)
        {
            Console.WriteLine(text + " : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] ModifyArray(int[]arr, int modifier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= modifier;
            }
            return arr;
        }
        static void ShowArray(int number, int[] arr)
        {
            Console.WriteLine("Number : " + number);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void ShowArray(int number1, int number2,params  int[] arr)
        {
            Console.WriteLine("Number : " + number1);
            Console.WriteLine("Number : " + number2);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Methods with array as params
            Random random = new Random();
            double[] arr = [2, 7, 9, 6, 5, 4, 3, 2, 14];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse( Console.ReadLine()!);
                arr[i] = random.Next(10, 50) + random.NextDouble();
            }

          
            //int[] arr = [2, 7, 9, 6, 5, 4, 3, 2, 14];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //    arr[i] = random.Next(10, 50) + random.NextDouble();
            //}
            //PrintArray("Original arr : ", arr);
            //ModifyArray(arr, 7);
            //PrintArray("Original arr : ", arr);

            //ShowArray(100, arr);
            //ShowArray(200, new int[] { 11,22,33,44,55});
            //ShowArray(300, 30,40,50,60,70,80,90,100);



            #region Example 1 Create Arrays
            /*
          //-----------------1---------------------
            ///Array == int[]
            int a ;
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            Console.WriteLine();

            //numbers = default 0
            //bool = false
            //references = null
            //-----------------2---------------------
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i * 2;
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            //-----------------3---------------------
            //int[]arr3 = new int[5] { 1, 2,3,4,5 };
            int[]arr3 = [1, 2, 3,4,5];
            for (int i = 0; i < arr3.Length;i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();


            //-----------------4---------------------
            //int[]arr4 = new int[] { 10,11,12,13,14,15,16,17,18,19,20 };
            int[]arr4 = [10,11,12,13,14,15,16,17,18,19,20];
            for (int i = 0; i < arr4.Length;i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();


            //-----------------5---------------------
            int[] arr5 = new int[5];
            for(int i = 0;i < arr5.Length;i++)
            {
                arr5[i] = 100;
                Console.Write(arr5[i] + " ");
            }
            Console.WriteLine();
            arr5.SetValue(77, 0);
            arr5.SetValue(77, 4);
        
            foreach (int elem in arr5)
            {
                //elem = 0; read only
                Console.Write(elem + " ");
            }
            */
            #endregion
            #region Two demention Array
            /*
            int[,] array = new int[3, 3];
            array[0,0] = 1;
            array[0,1] = 2;
            array[0,2] = 3;
            array[1,0] = 4;
            array[1,1] = 5;
            array[1,2] = 6;
            array[2,0] = 7;
            array[2,1] = 8;
            array[2,2] = 9;

            Console.Write(array[0,0] + " ");
            Console.Write(array[0,1]+ " ");
            Console.Write(array[0,2]+ " ");
            Console.WriteLine();   
            Console.Write(array[1,0]+ " ");
            Console.Write(array[1,1]+ " ");
            Console.Write(array[1,2]+ " ");
            Console.WriteLine();   
            Console.Write(array[2,0]+ " ");
            Console.Write(array[2,1]+ " ");
            Console.Write(array[2,2]+ " ");
            Console.WriteLine();
            //------------------------- 2 -------------------
            int[,]array2 = new int[3,4];

            // i ----> row
            //j ----> col
            Console.WriteLine($"Lenght : {array2.Length}");

            for (int i = 0; i < array2.GetLength(0); i++)//3
            {
                for (int j = 0; j < array2.GetLength(1); j++)//4
                {
                    array2[i, j] = i + j * 2;
                    //Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= array2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= array2.GetUpperBound(1); j++)//3
                {
                   Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine();
            }

            ///3
            int[,] arr4 =
            {
                  { 1,2,3},
                  {4,5,6 },
                  {7,8,9 }
            };
            Console.WriteLine(arr4.Length);
         
            Console.WriteLine(arr4.ToString());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr4[i, j]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region _3D_Arrays
            /*
              //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
             */
            #endregion
            #region _4D_Arrays
            /*
              int[,,,] array = new int[2, 2, 2, 2];

             array[0, 0, 0, 0] = 0x0;
             array[0, 0, 0, 1] = 0x1;
             array[0, 0, 1, 0] = 0x2;
             array[0, 0, 1, 1] = 0x3;

             array[0, 1, 0, 0] = 0x4;
             array[0, 1, 0, 1] = 0x5;
             array[0, 1, 1, 0] = 0x6;
             array[0, 1, 1, 1] = 0x7;

             array[1, 0, 0, 0] = 0x8;
             array[1, 0, 0, 1] = 0x9;
             array[1, 0, 1, 0] = 0xA;
             array[1, 0, 1, 1] = 0xB;

             array[1, 1, 0, 0] = 0xC;
             array[1, 1, 0, 1] = 0xD;
             array[1, 1, 1, 0] = 0xE;
             array[1, 1, 1, 1] = 0xF;


             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     for (int k = 0; k < 2; k++)
                     {
                         for (int l = 0; l < 2; l++)
                         {
                             Console.Write("{0:X} ", array[i, j, k, l]);
                         }
                         Console.Write('\n');
                     }
                     Console.WriteLine();
                 }
                 Console.Write("\n");
             }

             //2
             int[,,,] array2 =
              {
               {
                 { { 0x0, 0x1 }, {0x2, 0x3 } },
                 { { 0x4, 0x5 }, {0x6, 0x7 } }
               },
               {
                 { { 0x8, 0x9 }, {0xA, 0xB } },
                 { { 0xC, 0xD }, {0xE, 0xF } }
               }
             };


             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     for (int k = 0; k < 2; k++)
                     {
                         for (int l = 0; l < 2; l++)
                         {
                             Console.Write("{0:X} ", array2[i, j, k, l]);
                         }
                         Console.Write("\n");
                     }
                     Console.Write("\n");
                 }
                 Console.Write("\n");
             }
             */
            #endregion
            #region Jagged_array
            /*
            int[]   [] jagged = new int[3][];
            jagged[0] = new int[8] { 1, 2, 3, 4, 5,6,7,8 };
            jagged[1] = new int[3] {1,2,3 };
            jagged[2] = new int[4] {7,8,9,10 };

            Console.WriteLine(jagged.Length);

            for (int i = 0; i < jagged.Length; i++)//3
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (int[] item in jagged)
            {
                foreach (int el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region Methods Array
            /*
            int[]arr = {1,2,3,4,5,6,7,8,9,10};
            PrintArray("Original array ", arr);

            //5  ---> 5
            //0x1258 ---> 
            int[] clone = (int[]) arr.Clone();
            PrintArray("Clone ", clone);

            Array.Reverse(arr);
            PrintArray("Reverse array ", arr);
            Array.Reverse(arr,3,4);
            PrintArray("Reverse array ", arr);

            arr = clone;//arr = 0x36s9s9    clone = 0x36s9s9
            PrintArray("Original array ", arr);

            int[] arr2 = new int[20];
            PrintArray("Before copy array2 ", arr2);
            arr.CopyTo(arr2, 10);
            PrintArray("After copy array2 ", arr2);

            Console.WriteLine($"Lenght : {arr.Length}");
            Console.WriteLine($"Lenght : {arr.GetLength(0)}");

            Array.Clear(arr, 7,2);
            Console.WriteLine($"Lenght : {arr.Length}");
            PrintArray("Original array ", arr);

            Array.Resize(ref arr, 30);
            PrintArray("Original array after resize ", arr);
            Array.Sort(arr);
            PrintArray("Original array after sort ", arr);

            Console.WriteLine("Find element 7 : " + Array.IndexOf(arr,7));
            Console.WriteLine("Find element 7 : " + Array.IndexOf(arr,70));
            Console.WriteLine("Find element 7 : " + Array.BinarySearch(arr,7));

            Console.WriteLine($"Max element : {arr.Max()}");
            Console.WriteLine($"Min element : {arr.Min()}");
            Console.WriteLine($"Average element : {arr.Average()}");
            Console.WriteLine($"Rank : {arr.Rank}");
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"Rank : {arr3.Rank}");
            */
            #endregion

            #endregion
        }
    }
}
