using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class AMAZONsubstringsclass
    {
        public List<string> subStringsKDist(string inputStr, int num)
        {
            Dictionary<char, int> subStringsHashMap = new Dictionary<char, int>();
            int count = 1;
            var subStringsKDist = new List<string>();
            for (int i = 0; i < inputStr.Length; i++)
            {
                for (int j = i; j < i+num; j++)
                {
                    if (!subStringsHashMap.ContainsKey(inputStr[j]))
                    {
                        subStringsHashMap.Add(inputStr[j], count);
                    }
                    else
                    {
                        subStringsHashMap.Clear();
                        break;
                    }
                }
                if (subStringsHashMap.Count > 0)
                {
                    string mysubstring = "";
                    foreach (KeyValuePair<char,int> hashvalue in subStringsHashMap){
                mysubstring = String.Concat(mysubstring, hashvalue.Key);
            }
            subStringsKDist.Add(mysubstring);
        }
    }
        if(subStringsKDist.Count ==0){
            Console.WriteLine("No Unique susbtrings found in the string");
        }
        return subStringsKDist;
    // WRITE YOUR CODE HERE
    }

    }
}
