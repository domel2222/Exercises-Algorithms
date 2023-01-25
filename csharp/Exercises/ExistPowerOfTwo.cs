namespace Exercises
{
    public class ExistPowerOfTwo
    {
        public List<int> ExistingPowerOfTwo(uint [] array)
        {
            var powersCollection = new List<int>();

            if (!array.Any()) return powersCollection;

            int highestNumberOfPower = GetHighestPower(array);

            if (highestNumberOfPower == 0)
            {
                Console.WriteLine("NA");

                return powersCollection;
            }

            for (int i = 0; i < highestNumberOfPower; i++)
            {
                powersCollection.Add((int)Math.Pow(2, i));
            }

            return powersCollection;
        }

        private int GetHighestPower(uint[] array)
        {
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

            return highestnumberOfPower;
        }
    }
}
