using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addingTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum; //declaring each of the integers and the sum

            Console.WriteLine("<<== SIMPLE PROGRAM TO ADD TWO INTEGERS ==>>");
            Console.WriteLine("\n enter first number");

            a = Convert.ToInt32(Console.ReadLine()); //get the value of first integer from user

            Console.WriteLine("\n enter second number");

            b = Convert.ToInt32(Console.ReadLine()); //get the value of second integer from user
            sum = a + b; //adding both integers

            Console.WriteLine("\n the sum of both integers is {0}", sum);
            //Console.WriteLine("\n thank you");
            Console.ReadLine();
        }
    }
}
