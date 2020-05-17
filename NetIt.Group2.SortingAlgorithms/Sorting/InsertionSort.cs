using NetIt.Group2.SortingAlgorithms.Sorting;
using System;

namespace NetIt.Group2.SortingAlgorithms.Sorting
{
    public class InsertionSort : ISort
    {
        public T[] Sort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            T[] array = Helpers.CreateCopy(arrayToSort);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) <= 0 )
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
