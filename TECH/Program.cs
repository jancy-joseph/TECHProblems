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
            ////Twosum
            //int targetnumber = 9;
            //int[] intarray = { 3, 5, 12, 11, 4 };
            //var result = TwoSum.FindtargetIndex(intarray, targetnumber);
            //if (result == null)
            //{
            //    Console.WriteLine(" Index not found");
            //}
            //else
            //{
            //    Console.WriteLine("   Index found  {0}:{1}", result[0], result[1]);
            //}
            //// Output: 3 5 12 11 4   Index found  1:4

            string str = "A man, a plan, a canal: Panama";
            string str1 = "race a car";

            var result = ValidPalindrome.FindPalindromeUsingSwap(str);
           // var result = ValidPalindrome.FindValidPalindrome(str);
            if (result)
            {
                Console.WriteLine("\n String : \"{0}\"  is a Valid Paindrome \n", str);
            }
            else
            {
                Console.WriteLine(" String :\"{0}\" is Not a Valid Palindrome \n", str);
            }
            var result1 = ValidPalindrome.FindPalindromeUsingSwap(str1);
           // var result1 = ValidPalindrome.FindValidPalindrome(str1);
            if (result1)
            {
                Console.WriteLine(" String : \"{0}\" is a Valid Paindrome \n", str1);
            }
            else
            {
                Console.WriteLine(" String : \"{0}\" is Not Valid Palindrome \n", str1);
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
