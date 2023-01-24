namespace Exercises.Test
{
    public class PalindromeTest

    {
        private Palindrome _palindrome;

        public PalindromeTest()
        {
            _palindrome = new Palindrome();
        }

        [Theory]
        [InlineData("Do geese see God?")]
        [InlineData("Was it a car or a cat I saw?")]
        [InlineData("deified")]
        [InlineData("Radar")]
        public void CheckIsPalindrome_ProvideCorrectStrings_ReturnTrue(string sentence)
        {
            var result = _palindrome.CheckIsPalindrome(sentence);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("25 Palindrome Words")]
        [InlineData("")]
        [InlineData("What is the most famous palindrome?")]
        [InlineData("phrases")]
        public void CheckIsPalindrome_ProvideWrongStrings_ReturnFalse(string sentence)
        {
            var result = _palindrome.CheckIsPalindrome(sentence);

            result.Should().BeFalse();
        }
    }
}