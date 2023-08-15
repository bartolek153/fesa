
#include <iostream>
#include "printarray.hpp"

using namespace std;

// ordena de tras para frente
void bubbleSort(int array[], int length)
{
	// percorre o arranjo inteiro
	for (int i = 0; i < length; i++)
	{
		// Para cada elemento percorrido, 
		// o algoritmo compara o vizinho próximo (à direita) deste elemento,
		// e leva o maior dentre eles para o fim do arranjo na iteracao atual.
		for (int j = 0; j < length - i - 1; j++)
		{
			cout << "i: " << i << ", j: " << j;

			if (array[j] > array[j + 1])
			{
				cout << " (moved)";

				int temp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = temp;
			}

			cout << "\n";
		}
	}
}

int main()
{
	int array[] = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
	int length = sizeof(array) / sizeof(int);

	bubbleSort(array, length);

	printarray(array);
}