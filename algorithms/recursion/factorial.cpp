#include <iostream>

int fatorial(int n)
{
    if (n == 0 || n == 1)
    {
        // Caso base: fatorial de 0 ou 1 é 1
        return 1;
    }
    else
    {
        // Chamada recursiva
        return n * fatorial(n - 1);
    }
}

int main()
{
    int numero = 5;
    int resultado = fatorial(numero);
    cout << "O fatorial de " << numero << " é " << resultado << std::endl;

    return 0;
}
