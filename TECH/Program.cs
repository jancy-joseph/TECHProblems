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

            // string str = "A man, a plan, a canal: Panama";
            // string str1 = "race a car";

            // var result = ValidPalindrome.FindPalindromeUsingSwap(str);
            //// var result = ValidPalindrome.FindValidPalindrome(str);
            // if (result)
            // {
            //     Console.WriteLine("\n String : \"{0}\"  is a Valid Paindrome \n", str);
            // }
            // else
            // {
            //     Console.WriteLine(" String :\"{0}\" is Not a Valid Palindrome \n", str);
            // }
            // var result1 = ValidPalindrome.FindPalindromeUsingSwap(str1);
            //// var result1 = ValidPalindrome.FindValidPalindrome(str1);
            // if (result1)
            // {
            //     Console.WriteLine(" String : \"{0}\" is a Valid Paindrome \n", str1);
            // }
            // else
            // {
            //     Console.WriteLine(" String : \"{0}\" is Not Valid Palindrome \n", str1);
            // }

            //Maximum subarray
            //int targetnumber = 7;
            //int[] intarray = {-2,-3,4,-1,-2,1,5,-3};
            //var result = maximumsubarray.FindtargetIndex(intarray, targetnumber);
            //if (result == -1)
            //{
            //    Console.WriteLine(" Maximum subarray not found");
            //}
            // Output: 3 5 12 11 4   Index found  1:

            ///FindUniq
            ///
            ////string s = "leetcode";
            //string s = "loveleetcode";
            ////string s ="";

            //var result = FindUniq.FirstUniqCharByIndex(s);
            //if (result == -1)
            //{
            //    Console.WriteLine(" Uniq char not found");
            //}

            // ReverseWords- didnt work
            //string s = "jancy is name my";
            //Console.WriteLine(" Old string: {0}", s);
            //var result = FlipSentenceAndItsWords.ReverseWords(s,0,(s.Length -1));
            //Console.WriteLine(" new String :{0}", result);

            int[] arr = { 4, 6, 10, 15, 16 };
            int Lim = 21;
            int[] result = new int[2];

            result = targetSum_MergePackages.GetIndicesOfItemWeights(arr, Lim);
            if (result[1] == 0)
            {
                Console.WriteLine("Didnt Find two array Elements matching Lim");
            }
            else
            {
                Console.WriteLine(" X: {0} + Y: {1} = {2}", result[0], result[1], Lim);
            }

            


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
