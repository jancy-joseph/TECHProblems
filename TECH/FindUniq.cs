using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class FindUniq
    {
        //static public int FirstUniqChar(string s)
        //{
        //    Dictionary<char, int> charmap = new Dictionary<char, int>();
        //    int count = 1;

        //    for (int i = 0; i <= s.Length - 1; i++)
        //    {
        //        if (charmap.ContainsKey(s[i]))
        //        {
        //            //int temp = charmap[s[i]];
        //            //Console.WriteLine("Temp: {0}", temp);
        //            //temp = temp + 1;
        //            //charmap[s[i]] = temp;
        //            charmap[s[i]] = charmap[s[i]] + 1;
        //            Console.WriteLine(" Key : {0}, Value :{1}", s[i],charmap[s[i]]);
        //        }
        //        else
        //        {
        //            charmap.Add(s[i], count);
        //            Console.WriteLine(" Key : {0}, Value :{1}", s[i], charmap[s[i]]);
        //        }
        //    }
        //    foreach (KeyValuePair<char, int> mychar in charmap)
        //    {
        //        Console.WriteLine(" Key : {0}, Value :{1}", mychar.Key, mychar.Value);
        //        if (mychar.Value == 1)
        //        {
        //            Console.WriteLine("Unique char is  {0}", mychar.Key);
        //            return 0;
        //        }
        //    }
        //    Console.WriteLine(" No Unique Element found in Array");
        //    return -1;//error
        //}
        
        static public int FirstUniqCharByIndex(string s)
        {
            Dictionary<char, int> charmap = new Dictionary<char, int>();
            Dictionary<char,int> indexmap = new Dictionary<char,int>();
            int count = 1;
            
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (charmap.ContainsKey(s[i]))
                {
                    //int temp = charmap[s[i]];
                    //Console.WriteLine("Temp: {0}", temp);
                    //temp = temp + 1;
                    //charmap[s[i]] = temp;
                    charmap[s[i]] = charmap[s[i]] + 1;
                    Console.WriteLine(" Key : {0}, Value :{1}", s[i], charmap[s[i]]);
                }
                else
                {
                    indexmap.Add(s[i], i);
                    charmap.Add(s[i], count);
                    Console.WriteLine(" Key : {0}, Value :{1}", s[i], charmap[s[i]]);
                }
            }
            foreach (KeyValuePair<char, int> mychar in charmap)
            {
                Console.WriteLine(" Key : {0}, Value :{1}", mychar.Key, mychar.Value);
                if (mychar.Value == 1)
                {
                    Console.WriteLine("Unique char is  {0}", mychar.Key);
                    return indexmap[mychar.Key];
                }
            }
            Console.WriteLine(" No Unique Element found in Array");
            return -1;//error
        }




    }
}
