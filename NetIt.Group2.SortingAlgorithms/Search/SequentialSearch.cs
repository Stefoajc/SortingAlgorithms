using System;

namespace NetIt.Group2.SortingAlgorithms.Search
{
    public class SequentialSearch : ISearch
    {

        public int Search<T>(T[] array, T searchedItem) where T: IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(searchedItem) == 0)
                    return i;
            }

            return -1;
        }

    }
}
