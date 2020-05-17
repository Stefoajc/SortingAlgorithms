using System;

namespace NetIt.Group2.SortingAlgorithms.Sorting
{
    public interface ISort
    {
        T[] Sort<T>(T[] arrayToSort) where T : IComparable<T>;
    }
}
