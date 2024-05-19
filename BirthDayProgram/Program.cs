using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the current year : ");
            int cyear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            int birthday = cyear - age;
            Console.WriteLine("User's birthday : " + birthday);

            Console.ReadLine();



        }
    }
}
