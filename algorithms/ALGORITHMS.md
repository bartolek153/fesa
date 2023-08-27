
# Algoritmos

Em matemática e ciência da computação, um algoritmo é uma sequência finita de ações executáveis que visam obter uma solução para um determinado tipo de problema

## Análise assintótica

* Análise Assintótica é a estimativa do desempenho de um algoritmo à medida que o tamanho do problema tende ao infinito

Técnica utilizada na análise de algoritmos, que descreve o comportamento no tempo de execução ou no uso de recursos de hardware.
É expressa em termos da notação Grande O (Big O, usada para representar a complexidade assintótica de um algoritmo e escrita na forma O(f(n)), sendo f(n) uma função que descreve o crescimento do algoritmo em relação ao tamanho da entrada n) e sempre descreve o limite superior do crescimento de um algoritmo, ou seja, sempre o pior caso.

Obs.: a implementação real e o ambiente de execução também podem afetar o desempenho na prática.

### Notação Big O

1) omplexidade de Tempo Constante: O(1)

    O tempo de execução do algoritmo não depende do tamanho da entrada.

2) Complexidade de Tempo Linear: O(n)

    A execução do algoritmo cresce linearmente com o tamanho da entrada.
    À medida que o tamanho da entrada aumenta, o tempo de execução aumenta na mesma proporção.

3) Complexidades de Tempo Não Lineares: O(n2), O(n log n), O(log n), O(2n)

    O tempo de execução do algoritmo cresce de forma não linear em relação ao tamanho da entrada.

### Complexidade de acesso a um elemento de um arranjo

A complexidade algoritmica para acessar um elemento específico em um arranjo por índice é O(1). O índice acessa diretamente o elemento, assim, não importa quantos elementos existam no arranjo, o tempo de acesso será sempre constante.

A complexidade algoritmica para percorrer todos os elementos de um arranjo é O(n), pois depende do tamanho do arranjo (n).

## Algoritmos de ordenação

* Procedimentos computacionais que organizam um conjunto de elementos em uma ordem específica.
* Buscam reorganizar os elementos de forma crescente ou decrescente, facilitando a busca, recuperação e manipulação de dados.
* A escolha de um algoritmo depende do tamanho do conjunto de dados e dos recursos disponíveis.

### Bubble Sort

* O maior elemento sempre "flutua" para a direita.
* O(n) | O(n^2) | O(n^2)

### Insertion Sort

* O algoritmo obtém cada elemento e o "insere" em sua posição na parte já ordenada da lista.
* O(n) | O(n^2) | O(n^2)

### Selection Sort

* O algoritmo "seleciona" o menor elemento da lista desordenada e o joga para o início.
* O(n^2) | O(n^2) | O(n^2)

### Merge Sort

* "Dividir e conquistar/mesclar"
* O(n log n) | O(n log n) | O(n log n)

### Quick Sort

* Escolhe-se um elemento como pivô, rearranja os elementos de forma que todos os elementos menores que o pivô fiquem à sua esquerda e todos os elementos maiores fiquem à sua direita
* O(n log n) | O(n log n) | O(n log n)

## Recursão

Uma função ou procedimento chama a si mesmo como parte de seu processo de execução. Torna a solução mais elegante e concisa.

A sequência de chamadas recursivas continua até que um caso base seja atingido, onde a função para de se chamar a si mesma e começa a retornar resultados para as chamadas anteriores, permitindo a construção da solução para o problema original.

### Caso base

* este é o ponto de parada da recursão.
* condição em que a função recursiva deixa de chamar a si mesma e retorna um valor direto, sem novas chamadas recursivas.
* evita que a recursão entre em um loop infinito.

### Progressão em direção ao caso base

* cada chamada recursiva deve levar o problema a um estado mais próximo do caso base.

### Chamadas recursivas

* A função recursiva chama a si mesma com argumentos modificados, abordando um subproblema menor. Cada chamada recursiva resolve uma parte menor do problema, e a combinação das soluções desses subproblemas leva à solução do problema original quando a recursão se desenrola.

## Algoritmos de Busca

* Verificam se uma dada informação ocorre em uma sequência ou não. 
* Abordagem para encontrar um elemento em uma lista ou vetor.

### Linear Search

* Percorre a lista sequencialmente, elemento por elemento, até encontrar o valor desejado ou chegar ao final da lista. 
* O(n) | O(n) | O(1)

### Binary Search

* divide repetidamente a lista ao meio e verifica se o elemento que está procurando está na primeira metade ou na segunda metade  da lista, reduzindo o espaço de busca pela metade a cada iteração.
* O(log n) | O(log n) | O(1)
