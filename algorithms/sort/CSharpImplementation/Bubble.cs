
namespace Algorithms;

internal static class Bubble
{
    public static void Sort(int[] arrayToSort)
    {
        int[] array = arrayToSort;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j+1] < array[j])
                {
                    int aux = array[j+1];
                    array[j+1] = array[j];
                    array[j] = aux;
                }
            }
        }

        array.Print("Array ordenado com bubble sort: ");
    }
}
