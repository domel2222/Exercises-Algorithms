namespace Exercises
{
    public class FindingPrimes
    {
        public int FindPrimesNumbers(int start, int end)
        {
            var range = Enumerable.Range(start, end);

            var primeNumberCounter = 0;
            foreach (var number in range)
            {
                if (IsPrimeNumber(number))
                {
                    primeNumberCounter++;
                }
            }
            return primeNumberCounter;
        }

        private bool IsPrimeNumber(int number)
        {
            var divisors = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors++;
                }
            }
            return divisors == 2 ? true : false;
        }
    }
}