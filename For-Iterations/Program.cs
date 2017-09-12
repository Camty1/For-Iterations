using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) // 
            {
                //Console.WriteLine(i.ToString());

                if (i == 7)
                {
                    Console.WriteLine("Found Seven");
                    break; // Use this to exit from the for loop since you would waste processing going through the rest of the iterations of the for loop
                    // Break is same as Js
                }
            }

            for (int myValue = 0; myValue < 12; myValue++) // Same as Javascript, just int instead of var
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
