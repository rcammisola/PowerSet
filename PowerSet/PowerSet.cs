using System.Collections.Generic;

namespace PowerSet
{
    class PowerSet
    {
        public List<List<int>> GetPowerSet(int[] set)
        {
            List<List<int>> powerSet = new List<List<int>>();

            /// Total number of sub sets from the initial set should be 
            /// 2^S where S is the length of the set.
            int totalSubSets = (int) System.Math.Pow(2, set.Length);
            for (int i = 0; i < totalSubSets; i++)
            {
                int[] indexes = SetBits(i);

                powerSet.Add(new List<int>());
                foreach (int index in indexes)
                {
                    powerSet[i].Add(set[index]);
                }
            }
            
            return powerSet;
        }

        /// <summary>
        /// Take a number and work out which bits are set 
        /// and return them as an array.
        /// </summary>
        /// <param name="num">Number to check</param>
        /// <returns>Int array specifying indexes of the bits set.</returns>
        public int[] SetBits(int num)
        {
            // int is always 32 bits
            int totalBits = 32;
            List<int> bitIndexes = new List<int>();
            int mask = 1;

            for (int i = 0; i < totalBits; i++)
            {
                // if this bit is set, add the index
                if ((num & mask) == 1)
                {
                    bitIndexes.Add(i);
                }

                // move the number along 1 bit to the right to test the next bit
                num = num >> 1;
            }

            return bitIndexes.ToArray();
        }
    }
}
