using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{

    //Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

    //Note: For the purpose of this problem, we define empty string as valid palindrome.

    //Example 1:

    //Input: "A man, a plan, a canal: Panama"
    //Output: true
    //Example 2:

    //Input: "race a car"
    //Output: false
    // 
    //Solution1: Use two stacks and reverse it and check.
    //Time Complexity:O


    public  class ValidPalindrome
    {

        public static void printstack(Stack<char> s)
        {
            Console.WriteLine("\n Stack Content :");
            foreach (var itm in s)
                Console.Write(itm);

        }

        public static bool CompareStacks(Stack<char> s1, Stack<char> s2)
        {

            int flag = 0;
            int flag1 = 0;

            while (s1.Count > 0 && s2.Count > 0)
            {
                var first = s1.Pop();
                //Console.WriteLine("First: {0} ",first);
                var second = s2.Pop();
                //Console.WriteLine("Second :{0}",second);
                if (first == second)
                {
                    flag = 1;

                }
                else
                {
                    flag1 = 1;
                    break;
                }
            }
            if ((flag == 1) && (flag1 == 0))
            {
                // Console.WriteLine("\n Result true");
                return true;
            }
            // Console.WriteLine("\n Result False");
            return false;
        }
        public static bool FindValidPalindrome(string searchString)
        {
            Stack<char> myStack1 = new Stack<char>();
            //Console.WriteLine(searchString);
            foreach (char ch in searchString)
            {

                // Console.WriteLine(" out: {0}", ch);
                //push to stack if alphabet else ignore
                //changing character to lower to remove erros from case-sensitiveness.
                if (char.IsLetter(ch))
                {
                    //Console.WriteLine(" in: {0}", Char.ToLower(ch));
                    myStack1.Push(Char.ToLower(ch));
                }
            }
            // printstack(myStack1);
            // Create a copy of the stack, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.This also reverses the stack.
            Stack<char> myStack2 = new Stack<char>(myStack1.ToArray());
            // printstack(myStack2);

            //while (myStack1.Count > 0)
            //{
            //    myStack2.Push(myStack1.Pop());
            //}
            //printstack(myStack2);
            //Compare two stack contents
            if (CompareStacks(myStack1, myStack2))
            {
                return true;
            }
            return false;
        }

        public static string SwapChars(string str)
        {
            int i;
            //converting to char Array as string is immutable
            var old = str.ToCharArray();
            char temp;
          //  Console.WriteLine("oldstring : {0}", str);
            double Midpoint = old.Length / 2;
            var newlength = Math.Round(Midpoint);
            for (i = 0; i <= newlength; i++)
            {

                temp = old[i];
                old[i] = old[old.Length - i - 1];
                old[old.Length - i - 1] = temp;

            }
            string swapped = new string(old);
          // Console.WriteLine("swapped string : {0}", swapped);
            return swapped;
        }

        public static string StripSpace(string str)
        {
            char[] strippedstr = new char[str.Length + 1];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsWhiteSpace(ch))
                {
                    //Console.WriteLine("Whitespace ");
                    continue;

                }
                if (char.IsLetter(ch))
                {
                    strippedstr[i] = Char.ToLower(ch);
                }
                j = i;

            }
            strippedstr[++j] = '\0';
           // Console.WriteLine(strippedstr.Length);
            string mystring = new string(strippedstr);
            return mystring;

        }

        public static unsafe bool FindPalindromeUsingSwap(string str)
        {

            var sourcestring = StripSpace(str);
     
           
            var swappedstr = SwapChars(sourcestring);
         
     
           // Console.WriteLine("First {0} : Second {1}", sourcestring, swappedstr);
            var result = string.Compare(sourcestring,swappedstr);
            if (result == 0)
            {
                return true;
            }
            return false;
        }

    }
}
