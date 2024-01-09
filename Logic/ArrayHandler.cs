namespace Logic
{
    public class ArrayHandler
    {
        public double OddIndexedElementsSum(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array is Null");
            }
            if (array.Length <= 1) // no elements => no odd-indexed elements
                                   // 1 element is 0st => no odd-indexed elements
            {
                throw new ArgumentException("No odd-indexed elements");
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
