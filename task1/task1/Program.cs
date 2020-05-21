using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book b = new Book();
            b.ID = 10;
            b.Name = "arabic Book";
            Console.WriteLine(b);




            BookList B1 = new BookList();
            BookList B2 = new BookList();
            B1[0] = new Book() { ID = 10, Name = "English book" };
            Console.WriteLine(B1[0]);
            B1[1] = new Book() { ID = 20, Name = "frensh book" };
            Console.WriteLine(B1[1]);

            //if (B2.Contains(b))
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");

            //B1.Remove(b);




            //IEnumerator enumerator = B1.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Book B = enumerator.Current as Book;
            //    Console.WriteLine(B);
            //}

            Book[] arr = {

                new Book() { ID =10 ,Name = "Arabic" },
                new Book() { ID = 2, Name = "English" },
                new Book() { ID = 5, Name = "French" }

            };

            Array.Sort(arr);
            foreach (Book c in arr)
            {

                Console.WriteLine(c.ID);
            }  

            //Book bo = new Book();
            //Book boo = (Book)bo.Clone();
            //bo.ID = 50;
            //Console.WriteLine(bo.ID);
            //Console.WriteLine(boo.ID);



            //ArrayList r = new ArrayList();
            //r.Add(new Book() { ID = 10, Name = "A" });
            //r.Add(new Book() { ID = 20, Name = "B" });
            //r.Add(new Book() { ID = 30, Name = "C" });

            //foreach (Book B in r)
            //{
            //    Console.WriteLine(B.ToString());
            //}
            //List<Book> li = new List<Book>();
            //li.Add(new Book() { ID = 1, Name = "CSharp" });
            //li.Remove(li[0]);

            //Dictionary<int, Book> d = new Dictionary<int, Book>();
            //Book d1 = new Book() { ID = 10, Name = "dec1" };
            //Book d2 = new Book() { ID = 20, Name = "dec2" };
            //Book d3 = new Book() { ID = 30, Name = "dec3" };
            //Book d4 = new Book() { ID = 40, Name = "dec4" };
            //d.Add(1, d1);
            //d.Add(2, d2);
            //d.Add(3, d3);
            //d.Add(4, d4);
            //Console.WriteLine(d[1]);
            //Console.WriteLine(d.Count);
            //Console.WriteLine(d.Remove(1));
            //Console.WriteLine(d.Count);
            //Console.WriteLine(d.ContainsKey(1));



            Console.ReadLine();
        }
    }
}
