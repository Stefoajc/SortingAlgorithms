using NetIt.Group2.SortingAlgorithms.Sorting;
using System;

namespace NetIt.Group2.SortingAlgorithms.Sorting
{
    public class SelectionSort : ISort
    {
        public T[] Sort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            T[] array = Helpers.CreateCopy(arrayToSort);

            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstInUnsorted = i;
                int smallestInUnsortedIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[smallestInUnsortedIndex].CompareTo(array[j]) > 0)
                    {
                        smallestInUnsortedIndex = j;
                    }
                }

                Helpers.Swap(array, firstInUnsorted, smallestInUnsortedIndex);
            }

            return array;
        }
    }
}
