namespace Exercises.Test
{
    public class FindingPrimesTest
    {
        private FindingPrimes _findingPrimes;
        public FindingPrimesTest()
        {
            _findingPrimes = new FindingPrimes();
        }

        [Theory]
        [InlineData(1,10,4)]
        [InlineData(100,200,21)]
        [InlineData(1,1,0)]
        public void FindPrimesNumbers_ForGivenInput_ReturnCorrectPrimeNumberSAmount(int start, int end, int expexted)
        {
            var result = _findingPrimes.FindPrimesNumbers(start, end);

            result.Should().Be(expexted);
        }
    }
}
