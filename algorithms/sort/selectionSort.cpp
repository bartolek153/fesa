
#include <iostream>

using namespace std;

// Principio base:
//
//   Para cada posicao do arranjo: 
//     * Encontrar o menor elemento do arranjo
//     * Jogar o elemento encontrado para o inicio da lista
//     * Repetir o processo com os elementos posteriores, 
//       excluindo os indices dos elementos que ja foram ordenados

void selectionSort(int array[], int length)
{
    // Ordena da esquerda para direita
    
    for (int i = 0; i < length; i++)
    {
        int min_index = i;

        for (int j = min_index; j < length; j++)
        {
            if (array[j] < array[min_index])
                min_index = j;
        }

        if (array[i] > array[min_index])
        {
            int aux = array[i];
            array[i] = array[min_index];
            array[min_index] = aux;
        }
        
        cout << i << " - " << array[i] << endl;
    }
}


int main()
{
    cout << "# Selection Sort #" << endl << endl;
    
	int array[] = { 19, 28, 87, 66, 55, 44, 33, 92, 21, 0 };
	int length = sizeof(array) / sizeof(int);

	selectionSort(array, length);
}
