using System.Text.RegularExpressions;

namespace Exercises
{
    public class Palindrome
    {
        public bool CheckIsPalindrome(string wording)
        {
            if (string.IsNullOrWhiteSpace(wording)) return false;

            var clearSentence = Regex.Replace(wording.ToLower(), "[^a-zA-Z]", ""); 

            for (int i = 0, j = clearSentence.Length - 1; i < clearSentence.Length / 2; i++, j--)
            {
                if (clearSentence[i] != clearSentence[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
