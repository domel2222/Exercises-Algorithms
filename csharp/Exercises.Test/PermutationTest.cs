using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public  class PermutationTest
    {
        private Permutation _permutation;
        public PermutationTest()
        {
            _permutation = new Permutation();
        }

        [Fact]
        public void CheckIsPermutation_ForGivenCollections_ReturnsYes()
        {
            var firstArray = new int[] { 1, 2, 5, 3, 7, 0, 7, 3, 5, 2, 1 };
            var secondArray = new int[] { 7, 3, 1, 2, 5, 0, 5, 2, 1, 3, 7 };
            var expected = "YES";

            var result = _permutation.CheckIsPermutation(firstArray, secondArray);

            result.Should().Be(expected);
        }

        [Fact]
        public void CheckIsPermutation_ForGivenCollections_ReturnsNo()
        {
            var firstArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var secondArray = new int[] { 6, 5, 4, 3, 2, 0, 11, 10, 9, 8, 7 };
            var expected = "NO";

            var result = _permutation.CheckIsPermutation(firstArray, secondArray);

            result.Should().Be(expected);
        }
    }
}
