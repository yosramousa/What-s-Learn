using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class evens
    {
        public void displaymatrix()
        {
            int[,] arr1 = new int[2, 2];
            arr1[0, 0] = 1; arr1[0, 1] = 3;
            arr1[1, 0] = 2; arr1[1, 1] = 4;
            int[,] arr2 = new int[2, 2];
            arr2[0, 0] = 5; arr2[0, 1] = 7;
            arr2[1, 0] = 6; arr2[1, 1] = 8;
            int[,] result = new int[2, 2];
            result[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[0, 1] * arr2[1, 0];
            result[0, 1] = arr1[0, 0] * arr2[0, 1] + arr1[0, 1] * arr2[1, 1];
            result[1, 0] = arr1[1, 0] * arr2[0, 0] + arr1[1, 1] * arr2[1, 0];
            result[1, 1] = arr1[1, 0] * arr2[0, 1] + arr1[1, 1] * arr2[1, 1];
            Console.WriteLine(result[0, 0]);
            Console.WriteLine(result[0, 1]);
            Console.WriteLine(result[1, 0]);
            Console.WriteLine(result[1, 1]);
        }
        public void display()
        {
            int[] evens = new int[] { 0, 2, 4, 6, 8 };
            Console.WriteLine("The evens array length:" + " " + evens.Length);
            Console.WriteLine(" index1" + "   " + evens[0]);
            Console.WriteLine(" index2" + "   " + evens[1]);
            Console.WriteLine(" index3" + "   " + evens[2]);
            Console.WriteLine(" index4" + "   " + evens[3]);
            Console.WriteLine(" index5" + "   " + evens[4]);
            int crowed = evens[1];


        }
        public void displayevens()
        {   

            int[] evens = new int[5];
            int temp = 0;
            Console.WriteLine("Enter 5 evens numbers:");
            for (int i = 0; i < 5;)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp == 0 || temp % 2 == 0)
                {
                    evens[i] = temp;
                    i++;
                }
                else
                {
                    Console.WriteLine("invaid number, Try again");
                }

            }
            showevens(evens);
        }
        public void showevens(int[] evens)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(evens[i]);
            }
            Console.WriteLine("crowd = second number in array is:" + " " + evens[1]);
            int[] copy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                copy[i] = evens[i];
            }

        }
        public static void parameter(int[,] array)
        {
            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));
            Console.WriteLine(array.Length);
        }

        public void displaynames()
        {


            string[] names = new string[] { "yosra", "emy", "sma7", "sara" };
            foreach (string i in names)
            {
                Console.WriteLine(i);

                //  System.Console.Write("{0} ", i);
            }

        }
        //private static char myCharacter;
        //       static void Summarize(char[] contents)
        //       {
        //           int vowels = 0, consonants = 0, lines = 0;
        //           foreach (char current in contents)
        //           {
        //               if (Char.IsLetter(current))
        //               {
        //                   if ("AEIOUaeiou".IndexOf(current) != -1)
        //                   {
        //                       vowels++;
        //                   }
        //                   else
        //                   {
        //                       consonants++;
        //                   }
        //               }
        //               else if (current == '\n')
        //               {
        //                   lines++;
        //               }
        //           }
        //           Console.WriteLine("Total no of characters: {0}",
        //           contents.Length);
        //           Console.WriteLine("Total no of vowels : {0}",
        //           vowels);
        //           Console.WriteLine("Total no of consonants: {0}",
        //           consonants);
        //           Console.WriteLine("Total no of lines : {0}",
        //           lines); 

        //       }
      
        public  void method()
        {
            int[,] arr = new int[3, 5]; //new array




            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = 42;

                }

                //    Console.WriteLine(arr[i, j]);

            }

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 5; j++)
                {
                  Console.Write(  arr[i, j]);

                }

                Console.WriteLine();

            }
        }
    }
}
