using System;
using System.Collections.Generic;

namespace PowerSet
{
    public class MainPS
    {
        public static void Main(string[] args)
        {
            PowerSet ps = new PowerSet();
            List<List<int>> retVal = ps.GetPowerSet(new int[] {1,2,3,4});

            foreach (List<int> list in retVal)
            {
                foreach (int item in list)
                {
                    Console.Out.Write("{0}, ", item);
                }
                Console.Out.WriteLine("");
            }
        }
    }
}

