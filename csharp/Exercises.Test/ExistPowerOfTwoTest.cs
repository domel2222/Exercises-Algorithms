using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class ExistPowerOfTwoTest
    {
        private ExistPowerOfTwo _existPowerOfTwo;
        public ExistPowerOfTwoTest()
        {
            _existPowerOfTwo = new ExistPowerOfTwo();
        }

        [Theory]
        [InlineData(new uint[] { 1, 3, 4 }, new int[] { 1, 2, 4 })]
        [InlineData(new uint[] { 8, 16, 32 }, new int[] { 1, 2, 4, 8, 16, 32})]
        [InlineData(new uint[] { 3, 2, 1}, new int[] { 1, 2})]
        public void ExistingPowerOfTwo_ForGivenCollection_ReturnCorrectResult(uint[] array, int[] resultInt)
        {
            var hashResult = new HashSet<int>(resultInt);

            var result = _existPowerOfTwo.ExistingPowerOfTwo(array);

            result.Should().Equal(hashResult);
        }
    }
}
