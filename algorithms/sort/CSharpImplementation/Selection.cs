
namespace Algorithms;

internal static class Selection
{
    public static void Sort(int[] arrayToSort)
    {
        int[] array = arrayToSort;

        for (int i = 0; i < array.Length; i++)
        {
            int min_index = i;

            for (int j = i; j < array.Length; j++)
                if (array[j] < array[min_index])
                    min_index = j;

            int aux = array[i];
            array[i] = array[min_index];
            array[min_index] = aux;
        }

        array.Print("Array ordenado com selection sort: ");
    }
}
