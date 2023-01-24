namespace Exercises
{
    public class Permutation
    {
        public string CheckIsPermutation(int[] firstArray, int[] secondArray)
        {
            string yes = "YES";
            string no = "NO";

            if (firstArray.Length != secondArray.Length) return no;

            var frequencyOfApperance = CreateFrequencyApperance(firstArray);

            if (IsPermuntationExist(secondArray, frequencyOfApperance)) 
                return yes;

            return no;
        }

        private bool IsPermuntationExist(int[] secondArray,  Dictionary<int, int> frequencyOfApperance)
        {
            foreach (var value in secondArray)
            {
                if (!frequencyOfApperance.ContainsKey(value))
                    return false;

                if (--frequencyOfApperance[value] < 0)
                    return false;
            }

            return true;
        }

        private Dictionary<int, int> CreateFrequencyApperance(int[] firstArray)
        {
            var frequencyOfApperance = new Dictionary<int, int>();

            foreach (int value in firstArray)
            {
                if (frequencyOfApperance.ContainsKey(value))
                    frequencyOfApperance[value]++;

                else frequencyOfApperance.Add(value, 1);
            }

            return frequencyOfApperance;
        }
    }
}
