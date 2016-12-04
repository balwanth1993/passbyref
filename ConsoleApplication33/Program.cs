using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Value of 'a' before the function : {0}", a);
            
            Sum(ref a);

           
            Console.WriteLine("Value of 'a' after  the function : {0}", a);


        }
        public static void Sum(ref int x)
        {

            x = x + 100;
            Console.WriteLine("Result is " + x);
        }
    }
}
