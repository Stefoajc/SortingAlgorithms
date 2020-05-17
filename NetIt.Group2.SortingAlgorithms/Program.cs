using NetIt.Group2.SortingAlgorithms.Search;
using NetIt.Group2.SortingAlgorithms.Sorting;
using System;
using System.Linq;

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

            //int[] array = Enumerable.Range(0, 100).ToArray();

            //var search = new BinarySearch();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(i == search.Search(array, array[i]));
            //}
        }
    }
}
