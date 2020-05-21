using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class file
    {    public static void showfile()
        {
            string stringfrom, stringto;
            StreamReader sreaderfrom; StreamWriter swriterto;
            Console.WriteLine("please Enter input file copy from:");
            stringfrom = Console.ReadLine();
            Console.WriteLine("please Enter output file copy to:");
            stringto = Console.ReadLine();
            Console.WriteLine(stringfrom + " " + stringto);
            try
            {
                sreaderfrom = new StreamReader(stringfrom);
                swriterto = new StreamWriter(stringto);
                while (sreaderfrom.Peek() != -1)
                {
                    string sBuffer = sreaderfrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swriterto.WriteLine(sBuffer);
                }
                swriterto.Close();
                sreaderfrom.Close();


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file input is not found");
            }
            catch (Exception e)
            {


                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
