using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class ArrayWaveForm
    {
        public List<int> wave(List<int> A)
        {
            A.Sort();
            for (int i = 0; i < (A.Count - 2); i = i + 2)
            {
                int temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;
            }
            return A;
        }
    }
}
