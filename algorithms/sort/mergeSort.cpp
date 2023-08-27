
#include <iostream>

using namespace std;


void printArray(int arr[], int length)
{
    cout << "[ ";
    
    for (int p = 0; p < length; p++)
    {
        cout << arr[p];
        
        if (p != length - 1)
            cout << ", ";
    }
    
    cout << " ]" << endl;
}


void merge(int array[], int start_index, int mid_index, int end_index)
{
    int leftLength = mid_index - start_index + 1;
    int rightLength = end_index - mid_index;
    
    cout << "Left: " << start_index << " | Middle: " << mid_index << " | Right: " << end_index << endl;
    cout << "len(L) = " << leftLength << " ... len(R) = " << rightLength << ";\n\n";
    
    // instantiate temporary arrays to hold data 
    // (thus, requires extra memory)
    int leftArray[leftLength];
    int rightArray[rightLength];
    
    for (int l = 0; l < leftLength; l++)
        leftArray[l] = array[start_index + l];
    
    for (int r = 0; r < rightLength; r++)
        rightArray[r] = array[mid_index + 1 + r];
    
    cout << "L = ";
    printArray(leftArray, leftLength);
    
    cout << "R = ";
    printArray(rightArray, rightLength);
    
    // merge temporary arrays back into array
    int l = 0, r = 0;
    int auxIndex = start_index;
    
    while (l < leftLength && r < rightLength)
    {
        if (leftArray[l] < rightArray[r])
        {
            array[auxIndex] = leftArray[l];
            l++;
        }
        else 
        {
            array[auxIndex] = rightArray[r];
            r++;
        }
        
        auxIndex++;
    }
    
    while (l < leftLength)
    {
        array[auxIndex] = leftArray[l];
        l++;
        auxIndex++;
    }
    
    while (r < rightLength)
    {
        array[auxIndex] = rightArray[r];
        r++;
        auxIndex++;
    }
    
    cout << "Resulting array: ";
    printArray(array, end_index - start_index + 1);
    cout << "::::::::::::::::" << endl << endl;
}


// Principio base:
//
//   Recursivamente:
//     * Dividir o arranjo em duas partes, até que sobre subarranjos com 1 elemento
//     * Para cada subarranjo resultante da divisão, remesclar ja reordenando
 
void mergeSort(int array[], int start_index, int end_index)
{
    if (start_index >= end_index)  // it means the 
        return;
        
    int mid_index = start_index + (end_index - start_index) / 2;
    
    // cout << start_index << " " << mid_index << " " << end_index << endl;
        
    mergeSort(array, start_index, mid_index);  // sorts left partition of array
    mergeSort(array, mid_index + 1, end_index);  // sorts right partition of array
    
    // when the recursion reaches the base case, 
    // it starts the merging
    merge(array, start_index, mid_index, end_index);
}


int main()
{
    cout << "# Merge Sort #" << endl << endl;
    
	int array[] = { 19, 28, 87, 66, 55, 44, 33, 92, 21, 0 };
	int length = sizeof(array) / sizeof(int);

	mergeSort(array, 0, length - 1); // sorts from first position to the end
}


/* Pseudocode
 *  
 * mergesort(array a)
 *   if len(a) == 1
 *     return a
 * 
 *   arrayOne = a[0]...a[n/2]
 *   arrayTwo = a[n/2 + 1]...a[n]
 * 
 *   arrayOne = mergesort(arrayOne)
 *   arrayTwo = mergesort(arrayTwo)
 * 
 *   return merge(arrayOne, arrayTwo)
 * 
 * merge(array a, array b)
 *   array c
 * 
 *   while (a and b have elements)
 *     if (a[0] > b[0])
 *       add b[0] to the end of c
 *       remove b[0] from b
 *     else
 *       add a[0] to the end of c
 *       remove a[0] from a
 * 
 *    while (a has elements)
 *      add a[0] to the end of c
 *      remove a[0] from a
 * 
 *    while (b has elements)
 *      add b[0] to the end of c
 *      remove b[0] from b
 * 
 *    return c
 */