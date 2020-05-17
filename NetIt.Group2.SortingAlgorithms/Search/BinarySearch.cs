using System;

namespace NetIt.Group2.SortingAlgorithms.Search
{
    public class BinarySearch : ISearch
    {
        public int Search<T>(T[] sortedArray, T searchedItem) where T : IComparable<T>
        {
            int startIndex = 0;
            int endIndex = sortedArray.Length - 1;
            int middleIndex = sortedArray.Length / 2;

            while (endIndex != startIndex)
            {
                if (sortedArray[middleIndex].CompareTo(searchedItem) == 0)
                {
                    return middleIndex;
                }
                else if (sortedArray[middleIndex].CompareTo(searchedItem) > 0)
                {
                    endIndex = middleIndex;
                    middleIndex = (endIndex + startIndex) / 2;
                }
                else if (sortedArray[middleIndex + 1].CompareTo(searchedItem) == 0)
                {
                    return middleIndex + 1;
                }
                else if (sortedArray[middleIndex + 1].CompareTo(searchedItem) < 0)
                {
                    startIndex = middleIndex + 1;
                    middleIndex = (endIndex + startIndex) / 2;
                }
                else
                {
                    return -1;
                }
            }

            return -1;
        }


    }
}
