
#include <iostream>
#include <random>
#include <chrono>

using namespace std;

// Classe para gerar numeros aleatorios
class Randomizer {
    public: 
    
    static int* randomArray(int const n) {
        
        // gerador de numeros aleatorios
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution < > dis(0, 1000);

        // Cria um array de inteiros
        int * array = new int[n];

        // Preenche o array com numeros aleatorios
        for (int i = 0; i < n; i++) {
            array[i] = dis(gen);
        }

        // Retorna o array
        return array;
    }
    
    static int randomInt(int const n) {
        
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution < > dis(0, n);


        return dis(gen);
    }
};

// Funcao para medir o tempo de execucao de uma funcao
template <typename Func>
    long long medirTempoOrdenacao(Func funcao, int arr[], int tam) {

        auto start = chrono::steady_clock::now(); // Marca o tempo de inicio
        funcao(arr, tam); // Executa a funcao
        auto end = chrono::steady_clock::now(); // Marca o tempo de fim

        // Calcula a diferenca entre o tempo de inicio e fim
        return chrono::duration_cast < chrono::microseconds > (end - start).count();
    }

// Funcao para medir o tempo de execucao das funcoes de busca
template <typename Func>
    long long medirTempoBusca(Func funcao, int arr[], int tam, int valor_busca) {
        
        //insertionSort(arr, tam);

        auto start = chrono::steady_clock::now();
        funcao(arr, tam, valor_busca);
        auto end = chrono::steady_clock::now();

        return chrono::duration_cast < chrono::nanoseconds > (end - start).count();
    }

// Percorre a lista, compara o elemento atual com o elemento buscado e retorna o indice
int buscaSequencial(int lista[], int tamanho, int valor_busca) {

    //Percorre a lista
    for (int i = 0; i < tamanho; i++) {
        if (lista[i] == valor_busca) {
            return i; //retorna o indice
        }
    }
    //Se nao encontrar, retorna -1
    return -1;
}

// Percorre a lista, dividindo-a de meio em meio e comparando o elemento atual com o elemento buscado
int buscaBinaria(int lista[], int tamanho, int valor_busca) {
    // Define o inicio e o fim da lista
    int inicio = 0;
    int fim = tamanho - 1;

    while (inicio <= fim) {
        int meio = (inicio + fim) / 2;

        // Se o elemento do meio for o elemento buscado, retorna o indice
        if (lista[meio] == valor_busca) {
            return meio;

        }
        // Se o elemento do meio for menor que o elemento buscado, define o inicio como o elemento seguinte ao meio
        else if (lista[meio] < valor_busca) {
            inicio = meio + 1;

        }
        // Se o elemento do meio for maior que o elemento buscado, define o fim como o elemento anterior ao meio
        else {
            fim = meio - 1;
        }
    }
    // Se nao encontrar, retorna -1
    return -1;

}

void bubbleSort(int arranjo[], int tamanho) {

    // Passa por todo o arranjo ate estar organizado.
    for (int i = 0; i < tamanho - 1; i++) {

        // Manda o maior numero pro final.
        // Como o final esta organizado, fica limitado
        // o numero de trocas/comparacoes.
        for (int j = 0; j < tamanho - i - 1; j++) {
            if (arranjo[j] > arranjo[j + 1]) {
                int temp = arranjo[j];
                arranjo[j] = arranjo[j + 1];
                arranjo[j + 1] = temp;
            }
        }
    }
}

void insertionSort(int arranjo[], int tamanho) {
    for (int i = 1; i < tamanho; i++) {

        // Elemento que esta sendo levado
        // para a esquerda(menor).
        int chave = arranjo[i];

        // Elemento anterior a ele.
        int j = i - 1;

        // Enquanto a chave nao alcanca o limite esquerdo
        // e o elemento anterior a chave for maior,
        // a chave e levada para a esquerda e so para
        // quando o elemento a esquerda da chave for menor.
        while (j >= 0 && arranjo[j] > chave) {
            arranjo[j + 1] = arranjo[j];
            j--;
        }

        // O valor da chave e escrita a
        // direita do valor anterior (j),
        // que e j + 1.
        arranjo[j + 1] = chave;
    }
}

void selectionSort(int arranjo[], int tamanho) {
    // Define o primeiro elemento sendo o menor
    for (int i = 0; i < tamanho - 1; i++) {
        int menorIndice = i;

        // Faz a comparacao com todo o arranjo
        for (int j = i + 1; j < tamanho; j++) {
            if (arranjo[j] < arranjo[menorIndice]) {
                menorIndice = j;
            }
        }

        // Realiza a troca
        if (menorIndice != i) {
            int temp = arranjo[menorIndice];
            arranjo[menorIndice] = arranjo[i];
            arranjo[i] = temp;
        }
    }
}

int main() {

    // Tamanho dos arrays
    int tamanho1 = 1000;
    int tamanho2 = 3000;
    int tamanho3 = 7000;
    int tamanho4 = 10000;

    // Arrays com numeros aleatorios
    int* array1 = Randomizer::randomArray(tamanho1);
    int* array2 = Randomizer::randomArray(tamanho2);
    int* array3 = Randomizer::randomArray(tamanho3);
    int* array4 = Randomizer::randomArray(tamanho4);

    // Imprime o tempo de execucao dos algoritmos de ordenacao, para cada tamanho de array
    cout << "Bubble Sort" << endl;
    cout << "Tempo (1000): " << medirTempoOrdenacao(bubbleSort, array1, tamanho1) << " ms" << endl << endl;
    cout << "Tempo (3000): " << medirTempoOrdenacao(bubbleSort, array2, tamanho2) << " ms" << endl << endl;
    cout << "Tempo (7000): " << medirTempoOrdenacao(bubbleSort, array3, tamanho3) << " ms" << endl << endl;
    cout << "Tempo (10000): " << medirTempoOrdenacao(bubbleSort, array4, tamanho4) << " ms" << endl << endl;

    cout << "Insertion Sort" << endl;
    cout << "Tempo (1000): " << medirTempoOrdenacao(insertionSort, array1, tamanho1) << " ms" << endl << endl;
    cout << "Tempo (3000): " << medirTempoOrdenacao(insertionSort, array2, tamanho2) << " ms" << endl << endl;
    cout << "Tempo (7000): " << medirTempoOrdenacao(insertionSort, array3, tamanho3) << " ms" << endl << endl;
    cout << "Tempo (10000): " << medirTempoOrdenacao(insertionSort, array4, tamanho4) << " ms" << endl << endl;

    cout << "Selection Sort" << endl;
    cout << "Tempo (1000): " << medirTempoOrdenacao(insertionSort, array1, tamanho1) << " ms" << endl << endl;
    cout << "Tempo (3000): " << medirTempoOrdenacao(insertionSort, array2, tamanho2) << " ms" << endl << endl;
    cout << "Tempo (7000): " << medirTempoOrdenacao(insertionSort, array3, tamanho3) << " ms" << endl << endl;
    cout << "Tempo (10000): " << medirTempoOrdenacao(insertionSort, array4, tamanho4) << " ms" << endl << endl;
    

    int numeroAleatorio1 = Randomizer::randomInt(tamanho1);
    int numeroAleatorio2 = Randomizer::randomInt(tamanho2);
    int numeroAleatorio3 = Randomizer::randomInt(tamanho3);
    int numeroAleatorio4 = Randomizer::randomInt(tamanho4);

    array1[numeroAleatorio1] = numeroAleatorio1;
    array2[numeroAleatorio2] = numeroAleatorio2;
    array3[numeroAleatorio3] = numeroAleatorio3;
    array4[numeroAleatorio4] = numeroAleatorio4;

    // Imprime o tempo de execucao das funcoes de busca, para cada tamanho de array
    cout << "Busca Sequencial" << endl;
    cout << "Tempo (1000) " << medirTempoBusca(buscaSequencial, array1, tamanho1, numeroAleatorio1) << " ns" << endl << endl;
    cout << "Tempo (3000) " << medirTempoBusca(buscaSequencial, array2, tamanho2, numeroAleatorio2) << " ns" << endl << endl;
    cout << "Tempo (7000) " << medirTempoBusca(buscaSequencial, array3, tamanho3, numeroAleatorio3) << " ns" << endl << endl;
    cout << "Tempo (10000) " << medirTempoBusca(buscaSequencial, array4, tamanho4, numeroAleatorio4) << " ns" << endl << endl;

    cout << "Busca Binaria:" << endl;
    cout << "Tempo (1000): " << medirTempoBusca(buscaBinaria, array1, tamanho1, numeroAleatorio1) << " ns" << endl << endl;
    cout << "Tempo (3000): " << medirTempoBusca(buscaBinaria, array2, tamanho2, numeroAleatorio2) << " ns" << endl << endl;
    cout << "Tempo (7000): " << medirTempoBusca(buscaBinaria, array3, tamanho3, numeroAleatorio3) << " ns" << endl << endl;
    cout << "Tempo (10000): " << medirTempoBusca(buscaBinaria, array4, tamanho4, numeroAleatorio4) << " ns" << endl << endl;

    return 0;
}