using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ExistPowerOfTwo
    {
        public List<int> ExistingPowerOfTwo(uint [] array)
        {
            var powersCollection = new List<int>();

            if(!array.Any()) return powersCollection;

            var highestnumberOfPower = 0;
            foreach (var num in array)
            {
                var power = 0;
                var check = num;

                while (check > 0)
                {
                    check = check >> 1;
                    power++;
                }

                if (power > highestnumberOfPower) 
                    highestnumberOfPower = power;
            }

            if (highestnumberOfPower == 0)
            {
                Console.WriteLine("NA");

                return powersCollection;
            }

            for (int i = 0; i < highestnumberOfPower; i++)
            {
                powersCollection.Add((int)Math.Pow(2, i));
            }

            return powersCollection;
        }
    }
}
