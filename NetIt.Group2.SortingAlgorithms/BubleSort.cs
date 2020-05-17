using System;
namespace NetIt.Group2.SortingAlgorithms
{
    public class BubleSort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] array = Helpers.CreateCopy(arrayToSort);

            Helpers.Print(array);

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Helpers.Swap(array, i, i + 1);
                    }

                    Helpers.Print(array);
                }
            }

            return array;
        }

    }
}
