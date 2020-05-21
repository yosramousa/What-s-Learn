using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIndexers
{
    class EvenArray
    {
  public int[] superarray;
        public EvenArray() { }
        public EvenArray(int size)
        {
            superarray = new int[size];

        }
       



    //how to write an indexer to concate property9set&get) with array validation
    public int this[int index]
        {
            get { return superarray[index] * 10; }
            set
            {
                if (value % 2 == 0)
                { superarray[index] = value; }
                else
                { throw new Exception("invalid..Only even numbers are added"); }


            }




        }

    }














}
