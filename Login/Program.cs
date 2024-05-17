using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int again = 3;

            while (true)
            {
                Console.Write("Enter the Username : ");
                string username = Console.ReadLine();

                Console.Write("Enter the Password : ");
                string password = Console.ReadLine();

                if(username=="Kamran" && password=="123")
                {
                    Console.WriteLine("Process Succesfully!");
                    break;
                }
               else
                {
                    Console.WriteLine("Process Failed,Please Try Again!");
                    if (again > 0)
                    {
                        again-=1;
                    }
                    if(again==0)
                    {
                        Console.WriteLine("FAILED!!!");
                        break;
                    }
                }



            }
            Console.ReadLine();



        }
    }
}
