using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int t1 = 0;
            int t2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                string d = "";
                t1++;
                t2++;
                if (t1 == 3)
                {
                    d += "fizz";
                    t1 = 0;
                }
                if(t2==5)
                {
                    d += "buzz";
                    t2 = 0;

                }
                if(d !="")
                {
                    Console.WriteLine(d);
                }
                else
                {
                    Console.WriteLine(i);

                }

                
              

            }
            Console.ReadLine();
        }
    }
}
