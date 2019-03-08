using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class MaxSumArray_KadanesAlgorithm
    {
        public int maxset(List<int> A)
        {
            int MaxSum = int.MinValue;
            int TempSum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                TempSum = Max(A[i], TempSum + A[i]);
                if (TempSum > MaxSum)
                {
                    MaxSum = TempSum;
                }
                if (MaxSum < 0)
                {
                    MaxSum = 0;
                }
            }
            return MaxSum;
    }
    }
}
