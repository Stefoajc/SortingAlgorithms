using System;

namespace NetIt.Group2.SortingAlgorithms
{
    public static class Helpers
    {
        public static T[] CreateCopy<T>(T[] arrayToSort)
        {
            var array = new T[arrayToSort.Length];
            Array.Copy(arrayToSort, array, array.Length);
            return array;
        }

        public static void Swap<T>(T[] arrayNumbers, int j, int k)
        {
            T current = arrayNumbers[k];
            arrayNumbers[k] = arrayNumbers[j];
            arrayNumbers[j] = current;
        }

        public static void Print<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                T item = array[i];
                Console.Write(item + ((i == array.Length - 1) ? "" : ", " ));
            }
            Console.WriteLine();
        }
    }
}
