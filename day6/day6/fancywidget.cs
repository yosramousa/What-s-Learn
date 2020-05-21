using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class fancywidget : widget
    {
        public override void first()
        {
            base.first();
            Console.WriteLine(" Hello, i'm a fancywidget class.");



            Console.ReadLine();
        }
       
           

        }
    }

