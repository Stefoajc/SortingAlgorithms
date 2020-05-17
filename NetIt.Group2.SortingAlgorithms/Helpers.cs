using System;

namespace NetIt.Group2.SortingAlgorithms
{
    public static class Helpers
    {
        public static int[] CreateCopy(int[] arrayToSort)
        {
            var array = new int[arrayToSort.Length];
            Array.Copy(arrayToSort, array, array.Length);
            return array;
        }

        public static void Swap(int[] arrayNumbers, int j, int k)
        {
            int current = arrayNumbers[k];
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
