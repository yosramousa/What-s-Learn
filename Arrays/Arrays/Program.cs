using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        //private static string textFile;
        //static readonly string textFile = ;
        

       
        //--------------------------------------------------------------------------------------------------------------------
        //static void Summarize(char[] contents)
        //{
        //    int vowels = 0, consonants = 0, lines = 0;
        //    foreach (char current in contents)
        //    {
        //        if (Char.IsLetter(current))
        //        {
        //            if ("AEIOUaeiou".IndexOf(current) != -1)
        //            {
        //                vowels++;
        //            }
        //            else
        //            {
        //                consonants++;
        //            }
        //        }
        //        else if (current == '\n')
        //        {
        //            lines++;
        //        }
        //    }
        //    Console.WriteLine("Total no of characters: {0}",
        //    contents.Length);
        //    Console.WriteLine("Total no of vowels : {0}",
        //    vowels);
        //    Console.WriteLine("Total no of consonants: {0}",
        //    consonants);
        //    Console.WriteLine("Total no of lines : {0}",
        //    lines);
        //}


        static void Main(string[] args) {
        //   if (File.Exists(textFile))
        //    {
        //        string text = File.ReadAllText(text)
        //            Console.WriteLine(text);
        //    }
        //    Console.WriteLine(args.Length);
        //    foreach (string arg in args)
        //    {
        //        Console.WriteLine(arg);
        //    }
            //string fileName = args[0];
            //FileStream stream = new FileStream(fileName,
            //FileMode.Open);
            //StreamReader reader = new StreamReader(stream);
            //int size = (int)stream.Length;
            //char[] contents = new char[size];
            //for (int i = 0; i < size; i++)
            //{
            //    contents[i] = (char)reader.Read();
            //}
            //foreach (char ch in contents)
            //{
            //    Console.Write(ch);
            //}

            //Console.WriteLine(args.Length);
            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}
            //if ("AEIOUaeiou".IndexOf(myCharacter) != -1)
            //{
            //    // myCharacter is a vowel
            //}
            //else
            //{
            //    // myCharacter is not a vowel
            //}




            evens b = new evens();
            // b.displaymatrix();
            // b.displayevens();
            //  b.displaynames();
          //  b.method();
            b.display();
         

            Console.Read();
        }
    }
}
