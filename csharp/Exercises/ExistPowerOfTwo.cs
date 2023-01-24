using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public  class ExistPowerOfTwo
    {
        public HashSet<int> ExistingPowerOfTwo(uint [] array)
        {
            var powersCollection = new HashSet<int>();

            uint result = 0;

            foreach (uint item in array)
            {
                result |= item;
            };

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;

                if ((result & power) != 0)
                {
                    powersCollection.Add(power);
                }
            }

            if (powersCollection.Count == 0)
                Console.WriteLine("NA");

            return powersCollection;
        }
    }
}
