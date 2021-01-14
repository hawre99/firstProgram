using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int year = 2021;
            Console.WriteLine("Please enter your Name :");
            string name = Console.In.ReadLine();
            Console.WriteLine("year of birt :");
            String age = Console.In.ReadLine();
            int conAge = int.Parse(age);

            int yearOfBirth = year - conAge;

            Console.WriteLine("your Name is " + name);
            Console.WriteLine("your age is " + yearOfBirth);
        }
    }
}
