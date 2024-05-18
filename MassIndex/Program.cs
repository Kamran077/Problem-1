using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mass index = kilo/boy*boy
            //18 ve ya daha asagi ZEIF
            //18 ve 25 arasi NORMAL
            //25den yuxari OBEZ
            Console.Write("Kilonuzu yazin : ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Boyunuzu yazin : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            

            double massindex = kilo / (boy * boy);
            Console.WriteLine("Your mass index : " + massindex);

            if (massindex == 18 || massindex <= 18)
            {
                Console.WriteLine("ZEIF!");
            }
            else if (massindex > 18 && massindex <= 25)
            {
                Console.WriteLine("NORMAL!");
            }
            else 
            {
                Console.WriteLine("OBEZ!");
            }

            Console.ReadLine();


        }
    }
}
