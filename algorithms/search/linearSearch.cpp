
int buscaSequencial(int lista[], int tamanho, int valor_busca)
{
    for (int i = 0; i < tamanho; i++)
    {
        if (lista[i] == valor_busca)
        {
            // Elemento encontrado, retornar o índice do elemento
            return i;
        }
    }
    // Elemento não encontrado, retornar -1
    return -1;
}
