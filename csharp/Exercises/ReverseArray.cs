namespace Exercises
{
    public class ReverseArray
    {
        public int[] ReverseArrayMethod(int[] array)
        {
            if (array is null) return Array.Empty<int>();

            Array.Reverse(array);

            return array;
        }
    }
}
