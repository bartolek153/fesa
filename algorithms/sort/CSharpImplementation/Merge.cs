
namespace Algorithms;

internal static class Merge
{
    public static void Sort(int[] arrayToSort)
    {
        int[] array = arrayToSort;

        _MergeSort(array, 0, array.Length - 1);

        array.Print("Array ordenado com merge sort: ");
    }

    private static void _MergeSort(int[] array, int begin, int end)
    {
        if (begin >= end)
            return;

        int middle = begin + (end - begin) / 2;

        _MergeSort(array, begin, middle);
        _MergeSort(array, middle + 1, end);

        _Merge(array, begin, middle, end);
    }

    private static void _Merge(int[] array, int start, int middle, int end)
    {
        int leftLen = middle - start + 1;
        int rightLen = end - middle;

        int[] L = new int[leftLen];
        int[] R = new int[rightLen];
            
        for (int _l = 0; _l < leftLen; _l++)
            L[_l] = array[start + _l];
        for (int _r = 0; _r < rightLen; _r++)
            R[_r] = array[middle + _r + 1];

        int l = 0, r = 0;
        int k = start;

        while (l < leftLen && r < rightLen) 
        {
            if (L[l] < R[r])
            {
                array[k] = L[l];
                l++;
            }
            else
            {
                array[k] = R[r];
                r++;
            }

            k++;
        }

        while (l < leftLen)
        {
            array[k] = L[l];
            l++;
            k++;
        }

        while (r < rightLen)
        {
            array[k] = R[r];
            r++;
            k++;
        }
    }
}
