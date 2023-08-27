
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
    
    cout << "]" << endl;
}


// Principio base:
//
//   Para cada posicao do arranjo: 
//     * Comparar elemento com todos os outros a sua esquerda
//     * Mover para frente todos os elementos a esquerda
//       que forem maior que o elemento atual
//     * Repetir o processo exluindo

/* Pseudocode
 * for i: 1 to length(A) - 1
 *   j = i
 *   while j > 0 and A[j-1] > A[j]
 *     swap A[j] and A[j-1]
 *     j = j - 1
 */
 
void insertionSort(int array[], int length)
{
    // Ordena da direita para a esquerda
    
    int key;
    
    for (int i = 0; i < length; i++)
    {
        key = i;
        
        while (key > 0 && array[key] < array[key - 1])
        {
            int aux = array[key - 1];
            array[key - 1] = array[key];
            array[key] = aux;
            key--;
            
        }
        
        cout << i << " - ";
        printArray(array, length);
    }
}


int main()
{
    cout << "# Insertion Sort #" << endl << endl;
    
	int array[] = { 19, 28, 87, 66, 55, 44, 33, 92, 21, 0 };
	int length = sizeof(array) / sizeof(int);

    printArray(array, length);

	insertionSort(array, length);
}
