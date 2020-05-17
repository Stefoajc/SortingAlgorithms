using System;

namespace NetIt.Group2.SortingAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] array = Helpers.CreateCopy(arrayToSort);
            
            Helpers.Print(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstInUnsorted = i;
                int smallestInUnsortedIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[smallestInUnsortedIndex] > array[j])
                    {
                        smallestInUnsortedIndex = j;
                    }
                }

                Helpers.Swap(array, firstInUnsorted, smallestInUnsortedIndex);

                Helpers.Print(array);
            }

            return array;
        }
    }
}
