
#include <iostream>

using namespace std;

// Principio base:
//
//   Para cada posicao do arranjo: 
//     * Pegar dois elementos consecutivos
//     * Se o primeiro elemento for maior, trocar de posicao
//     * Repetir o processo, excluindo posicoes ja ordenadas

void bubbleSort(int array[], int length)
{
    // Ordena da direita para a esquerda
    
    for (int i = 0; i < length - 1; i++)
    {
        for (int j = 0; j < length - i - 1; j++)
        {
            if (array[j] > array[j+1])
            {
                int aux = array[j];
                array[j] = array[j+1];
                array[j+1] = aux;
            }
        }
        
        cout << length - i - 1 << " - " << array[length - i - 1] << endl;
    }
}


int main()
{
    cout << "# Bubble Sort #" << endl << endl;
    
	int array[] = { 19, 28, 87, 66, 55, 44, 33, 92, 21, 0 };
	int length = sizeof(array) / sizeof(int);

	bubbleSort(array, length);
}
