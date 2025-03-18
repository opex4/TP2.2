using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2._2
{
    public class Logic
    {
        private int[] sequence;

        public Logic(int[] sequence)
        {
            this.sequence = sequence;
        }

        public int CountSignChanges()
        {
            int count = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                if ((sequence[i - 1] > 0 && sequence[i] < 0) || (sequence[i - 1] < 0 && sequence[i] > 0))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
