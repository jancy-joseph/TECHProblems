using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class FlipSentenceAndItsWords
    {

        public static string ReverseWords(string str,int low,int high)
        {
            
            var old = str.ToCharArray();
            char temp,ltemp,rtemp;
            //  Console.WriteLine("oldstring : {0}", str);
            //double Midpoint = old.Length / 2;
            int llow = low, lhigh, rlow, rhigh=high;
            //var newlength = Math.Round(Midpoint);
           // for (int i = 0; i <= newlength; i++)
           while(low<=high)
            {

                temp = old[low];
                old[low] = old[high];
                old[high] = temp;
                //lhigh = low;
                //rlow = high;
                //if (old[low] == ' ')
                //{
                //    lhigh = low - 1;
                //    while (llow < lhigh)
                //    {
                //        ltemp = old[llow];
                //        old[llow] = old[lhigh];
                //        old[lhigh] = ltemp;
                //        llow = llow + 1;
                //        lhigh = lhigh - 1;

                //    }
                //    llow = low + 1;
                    

                //}


                if (old[high] == ' ')
                {
                    rlow = high + 1;

                    while (rlow < rhigh)
                    {
                        rtemp = old[rlow];
                        old[rlow] = old[rhigh];
                        old[rhigh] = rtemp;
                        rlow = rlow + 1;
                        rhigh = rhigh - 1;

                    }
                    rhigh = high - 1;

                }

                low = low + 1;
                high = high - 1;
                lhigh = low;
                rlow = high;
                Console.WriteLine("low: {0} ,high: {1},llow : {2},lhigh: {3},rlow :{4},rhigh :{5}", low, high, llow, lhigh, rlow, rhigh);

            }

            string s = new string(old);
           // Console.WriteLine("string s:{0}", s);


            return s;
                  
        }
    }
}
