using System;

namespace NetIt.Group2.SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 85, 12, 59, 45, 72, 51 };

            var sortingAlg = new SelectionSort();

            var sortedArray = sortingAlg.Sort(array);

            Helpers.Print(sortedArray);
        }
    }
}
