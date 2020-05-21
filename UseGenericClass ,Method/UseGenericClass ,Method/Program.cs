using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UseGenericClass__Method
{
    public class A : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //intlist i = new intlist();
            //Console.WriteLine(  i.Add(10));
            //Console.WriteLine(i.getindex(0));
            //Console.WriteLine(i.Add(20));
            //Console.WriteLine(i.getindex(0));
            //Console.WriteLine(i.getindex(1));
            //Console.ReadLine();


            //genericlist <A> intlist= new genericlist<A>();
            //intlist.Add(10);
            //intlist.getindex(0);
            genericlist<float> floatlist = new genericlist<float>();
            floatlist.Add(100f);
            floatlist.getindex(0);
            genericlist<int> intlist = new genericlist<int>();
         intlist.Add(100);
           intlist.getindex(0);


        }
    }
}
