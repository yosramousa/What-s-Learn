using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseGenericClass__Method
{
    class genericlist<T> where T :struct/*, System.Collections.IEnumerable*/
    {
       
        private T []superarray;
        public int indexcount = 0;
      
        public genericlist()
        {

            superarray = new T[10];


        }
        public int Add(T value)
        {
            superarray[indexcount] = value;
          return  indexcount++;
        }

        public T getindex(int index)
        {
            return superarray[index];
        }

        //public Tvalue getAnyThing <Tvalue>()
        //{
        //    //value;
            
        //}

         
    public class floatlist
        {

            private float[] superarray;
            public int indexcount = 0;

            public floatlist()
            {

                superarray = new float[10];


            }
            public int Add(float value)
            {
                superarray[indexcount] = value;
                return indexcount++;
            }

            public float getindex(int index)
            {
                return superarray[index];
            }

        }

    }
}
