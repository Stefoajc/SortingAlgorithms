namespace NetIt.Group2.SortingAlgorithms
{
    public class SequentialSearch
    {

        public int Search(int[] array, int searchedItem)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedItem)
                    return i;
            }

            return -1;
        }

    }
}
