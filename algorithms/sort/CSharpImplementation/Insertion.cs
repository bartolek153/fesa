
namespace Algorithms;

internal static class Insertion
{
    public static void Sort(int[] arrayToSort)
    {
        int[] array = arrayToSort;
        int keyIndex;

        for (int i = 0; i < array.Length; i++)
        {
            keyIndex = i;

            while (keyIndex > 0 && array[keyIndex] < array[keyIndex - 1])
            {
                int aux = array[keyIndex];
                array[keyIndex] = array[keyIndex - 1];
                array[keyIndex - 1] = aux;

                keyIndex--;
            }
        }

        array.Print("Array ordenado com insertion sort: ");
    }
}
