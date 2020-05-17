using System;

namespace NetIt.Group2.SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] array = Helpers.CreateCopy(arrayToSort);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] <= array[j])
                    {
                        continue;
                    }

                    Helpers.Swap(array, j, j - 1);
                }
            }
            return array;
        }
                
    }
}
