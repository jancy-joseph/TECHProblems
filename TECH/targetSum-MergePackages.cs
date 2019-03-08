using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class targetSum_MergePackages
    {
        public static int[] GetIndicesOfItemWeights(int[] arr, int limit)
        {
            int[] indices = new int[2];
            Dictionary<int,int> weights = new Dictionary <int,int>();

            indices[0] = 0;
            indices[1] = 0;
            int num = arr.Length - 1;

            for (int i = 0; i <=num;i++)
            {
                if (weights.Count > 0)
                {
                    int tempkey = limit - i;
                    Console.WriteLine("arr[i]:{0} Tempkey:{1} i:{2}", arr[i], tempkey, i);

                    //Find its complement in Dictionary then we have found both the numbers that adds to Limit
                    if (weights.ContainsKey(tempkey))
                    {

                        if (i > tempkey)
                        {
                            indices[0] = i;
                            indices[1] = weights[tempkey];
                            return indices;
                        }
                        else
                        {
                            indices[0] = weights[tempkey];
                            indices[1] = i;
                            return indices;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Didnt find key {0} {1}", tempkey, weights.ContainsKey(tempkey));
                    }

                }
                //adding new elemets and its index in Dictionary
                weights.Add(arr[i], i);
            }
            Console.WriteLine("Didnt find the pair");
            return indices;
        }

    }
}
