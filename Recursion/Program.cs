using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {

        static int FirstRecursion(int n, int h)
        {
               
            Console.WriteLine(h);
            h++;
            
            if (n == 1)
                return 1;

            return FirstRecursion(n-1, h);
        }

        static int SecondRecursion(int n)
        {
            Console.WriteLine(n);

            if (n == 1)
                return 1;       

            return SecondRecursion(n-1);
        }

        static int ThirdRecursion(int n)
        {
            
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;
        
            return ThirdRecursion(n - 1) + ThirdRecursion(n - 2); 
        }

        static void Main(string[] args)
        {
            const string Menu = "Enter the number n:";
            const string First = "All numbers up to n(n being number) using recursion:";
            const string Second = "All numbers starting from n(n being number) and going down to 1:";
            const string Third = "Calculating n-th (n being number) number in fibonnacii series:";

            Console.WriteLine(Menu);
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(First);
            FirstRecursion(n, 1);

            Console.WriteLine(Second);
            SecondRecursion(n);

            Console.WriteLine(Third);
            Console.WriteLine(ThirdRecursion(n));
            
            Console.ReadKey();
        }
    }
}
