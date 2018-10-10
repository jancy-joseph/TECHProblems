using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetnumber = 9;
            int[] intarray= { 3, 5, 12, 11, 4 };
            var result = TwoSum.FindtargetIndex(intarray, targetnumber);
            if (result == null)
            {
                Console.WriteLine(" Index not found");
            }
            else
            {
                Console.WriteLine("Index found{0}:{1}", result[0], result[1]);
            }
            
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
