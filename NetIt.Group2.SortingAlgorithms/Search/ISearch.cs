using System;

namespace NetIt.Group2.SortingAlgorithms.Search
{
    public interface ISearch
    {
        int Search<T>(T[] collection, T searchedItem) where T : IComparable<T>;
    }
}
