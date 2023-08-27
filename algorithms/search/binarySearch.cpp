#include <iostream>

int buscaBinaria(int lista[], int tamanho, int valor_busca)
{
    int inicio = 0;
    int fim = tamanho - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] == valor_busca)
        {
            return meio; // Elemento encontrado, retornar o índice do
            elemento
        }
        else if (lista[meio] < valor_busca)
        {
            inicio = meio + 1; // Busca na segunda metade da lista
        }
        else
        {
            fim = meio - 1; // Busca na primeira metade da lista
        }
    }
    return -1; // Elemento não encontrado, retornar -1
}

int main()
{
    int lista[] = {11, 12, 22, 25, 34, 64, 90};
    int tamanho = sizeof(lista) / sizeof(lista[0]);
    int valor_busca = 22;

    int resultado = buscaBinaria(lista, tamanho, valor_busca);

    if (resultado != -1)
    {
        std::cout << "O valor " << valor_busca << " foi encontrado noíndice " << resultado << std::endl;
    }
    else
    {
        std::cout << "O valor " << valor_busca << " não foi encontrado na lista." << std::endl;
    }

    return 0;
}