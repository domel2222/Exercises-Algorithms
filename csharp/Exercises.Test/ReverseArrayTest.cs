namespace Exercises.Test
{
    public class ReverseArrayTest
    {
        private ReverseArray _reverseArray;
        public ReverseArrayTest()
        {
            _reverseArray = new ReverseArray();
        }

        [Theory]
        [InlineData( new int [] {1,2,3}, new int[] {3,2,1} )]
        [InlineData(new int[] { 9, 15, 1,96 }, new int[] { 96, 1, 15, 9 })]
        public void ReverseArrayMethod_ForGivenArray_ReturnCorrectCollection(int[] array, int[] correctArray)
        {
            //act

            var result = _reverseArray.ReverseArrayMethod(array);
            //assert

            result.Should().Equal(correctArray);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 1, 2 })]
        [InlineData(new int[] { 9, 15, 1, 96 }, new int[] { 1, 96, 15, 9 })]
        public void ReverseArrayMethod_ForGivenArray_ShouldNotReturnCorrectCollection(int[] array, int[] correctArray)
        {
            //act

            var result = _reverseArray.ReverseArrayMethod(array);
            //assert

            result.Should().NotEqual(correctArray);
        }
    }
}
