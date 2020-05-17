using NetIt.Group2.SortingAlgorithms.Sorting;
using System;

namespace NetIt.Group2.SortingAlgorithms.Sorting
{
    public class BubleSort : ISort
    {
        public T[] Sort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            T[] array = Helpers.CreateCopy(arrayToSort);

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Helpers.Swap(array, i, i + 1);
                    }
                }
            }

            return array;
        }

    }
}
