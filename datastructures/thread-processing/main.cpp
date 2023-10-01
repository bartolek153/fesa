#include <iostream>
#include <vector>
#include <chrono>
#include <thread>
#include <queue>
#include <stack>
#include <functional>
#include <mutex>
#include <condition_variable>

#include "Vetor.h"
#include "ListaSimples.h"
#include "ListaDupla.h"

using namespace std;

queue<function<void()>> functionQueue;
mutex queueMutex;
condition_variable queueCondition;

// Funcao que sera executada pelas threads
void threadExecutor() {
    while (true) {
        function<void()> func;
        {
            unique_lock<mutex> lock(queueMutex);

			// Aguarda ate que a fila tenha alguma funcao para executar
            queueCondition.wait(lock, []{ return !functionQueue.empty(); });

            func = functionQueue.front();
            functionQueue.pop();
        }

        func();  // Executa a funcao
    }
}

void processarPilha(stack<int>& pilha) {
	int i = 0;
	while (!pilha.empty()) {
		this_thread::sleep_for(chrono::milliseconds(7));
		cout << "(pl) Pagamento " << ++i << " processado. Valor = R$ " << pilha.top() << endl;
        pilha.pop();
    }
}

void processamentoSincrono() {
	srand(static_cast<unsigned>(time(NULL)));

	stack<int> pilhaFiltro;
	stack<int> pilhaFiltroCopia;
	vector<int> vetor, vetor1, vetor2, vetor3;
	ListaSimples l1, l2, l3, l4;
	ListaDupla lis1, lis2, lis3, lis4;

	//Insercao de valores nos vetores
	preencherVetor(vetor, 1000);
	preencherVetor(vetor1, 3000);
	preencherVetor(vetor2, 5000);
	preencherVetor(vetor3, 10000);

	//Insercao de valores nas listas
	for (int i = 0; i < 1000; i++) {
		l1.inserirElemento();
		lis1.inserirElemento();
	}
	for (int i = 0; i < 3000; i++) {
		l2.inserirElemento();
		lis2.inserirElemento();
	}
	for (int i = 0; i < 5000; i++) {
		l3.inserirElemento();
		lis3.inserirElemento();
	}
	for (int i = 0; i < 10000; i++) {
		l4.inserirElemento();
		lis4.inserirElemento();
	}
	
	vector<vector<int>> vetores = { vetor, vetor1, vetor2, vetor3 };  // vetor de vetores
	vector<ListaSimples> listasSimples = { l1, l2, l3, l4 };  // vetor de listas simples
	vector<ListaDupla> listasDuplas = { lis1, lis2, lis3, lis4 };  // vetor de listas duplas

	vector<int> tamanhos = { 1000, 3000, 5000, 10000 };

	// varre as listas, procurando o maior valor gerado
	int maiorValor = 0;

	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < tamanhos[i]; j++) {
			if (vetores[i][j] > maiorValor)
				maiorValor = vetores[i][j];
		}

		int _lsMaior = listasSimples[i].getHighest();
		int _ldMaior = listasDuplas[i].getHighest();

		if (_lsMaior > maiorValor)
			maiorValor = _lsMaior;
		if (_ldMaior > maiorValor)
			maiorValor = _ldMaior;
	}

	long alvoPilha = 2 * maiorValor / 3;

	// recria as listas, considerando o dois tercos do maior valor
	for (int i = 0; i < 4; i++) {
		vector<int> vetorAux;			
		ListaSimples lsAux;
		ListaDupla ldAux;

		for (int j = 0; j < vetores[i].size(); j++) {
			if (vetores[i][j] > alvoPilha) {
				pilhaFiltro.push(vetores[i][j]);
				continue;
			}
			vetorAux.push_back(vetores[i][j]);
		}
		
		Node* current = listasSimples[i].getHead();

		while (current != NULL) {
			if (current->data > alvoPilha) {
				pilhaFiltro.push(current->data);	
			} else {
				lsAux.inserirElemento(current->data);
			}

			current = current->next;
		}
		
		Node2* current2 = listasDuplas[i].getHead();

		while (current2 != NULL) {
			if (current2->data > alvoPilha) {
				pilhaFiltro.push(current2->data);	
			} else {
				ldAux.inserirElemento(current2->data);
			}

			current2 = current2->next;
		}

		vetores[i] = vetorAux;
		listasSimples[i] = lsAux;
		listasDuplas[i] = ldAux;
	}

	pilhaFiltroCopia = pilhaFiltro;

	cout << "Listas de pagamentos prontas. Iniciando processamento sequencial... (Atividade 10)" << endl;
	this_thread::sleep_for(chrono::seconds(3));

	// Processar todos os vetores
	for (int i = 0; i < vetores.size(); ++i) {
		processarVetor(vetores[i]);
	}

	// Processar todas as listas simples
	for (int i = 0; i < listasSimples.size(); ++i) {
		mostrarListaSimples(listasSimples[i]);
	}

	// Processar todas as listas duplas
	for (int i = 0; i < listasDuplas.size(); ++i) {
		mostrarListaDupla(listasDuplas[i]);
	}

	processarPilha(pilhaFiltro);

	cout << endl << "Processamento sincrono completo." << endl;
}

void processamentoParalelo() {
	srand(static_cast<unsigned>(time(NULL)));

	stack<int> pilhaFiltro;
	vector<int> vetor, vetor1, vetor2, vetor3;
	ListaSimples l1, l2, l3, l4;
	ListaDupla lis1, lis2, lis3, lis4;

	//Insercao de valores nos vetores
	preencherVetor(vetor, 1000);
	preencherVetor(vetor1, 3000);
	preencherVetor(vetor2, 5000);
	preencherVetor(vetor3, 10000);

	//Insercao de valores nas listas
	for (int i = 0; i < 1000; i++) {
		l1.inserirElemento();
		lis1.inserirElemento();
	}
	for (int i = 0; i < 3000; i++) {
		l2.inserirElemento();
		lis2.inserirElemento();
	}
	for (int i = 0; i < 5000; i++) {
		l3.inserirElemento();
		lis3.inserirElemento();
	}
	for (int i = 0; i < 10000; i++) {
		l4.inserirElemento();
		lis4.inserirElemento();
	}
	
	vector<vector<int>> vetores = { vetor, vetor1, vetor2, vetor3 };  // vetor de vetores
	vector<ListaSimples> listasSimples = { l1, l2, l3, l4 };  // vetor de listas simples
	vector<ListaDupla> listasDuplas = { lis1, lis2, lis3, lis4 };  // vetor de listas duplas

	vector<int> tamanhos = { 1000, 3000, 5000, 10000 };

	// varre as listas, procurando o maior valor gerado
	int maiorValor = 0;

	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < tamanhos[i]; j++) {
			if (vetores[i][j] > maiorValor)
				maiorValor = vetores[i][j];
		}

		int _lsMaior = listasSimples[i].getHighest();
		int _ldMaior = listasDuplas[i].getHighest();

		if (_lsMaior > maiorValor)
			maiorValor = _lsMaior;
		if (_ldMaior > maiorValor)
			maiorValor = _ldMaior;
	}

	long alvoPilha = 2 * maiorValor / 3;

	// recria as listas, considerando o dois tercos do maior valor
	for (int i = 0; i < 4; i++) {
		vector<int> vetorAux;			
		ListaSimples lsAux;
		ListaDupla ldAux;

		for (int j = 0; j < vetores[i].size(); j++) {
			if (vetores[i][j] > alvoPilha) {
				pilhaFiltro.push(vetores[i][j]);
				continue;
			}
			vetorAux.push_back(vetores[i][j]);
		}
		
		Node* current = listasSimples[i].getHead();

		while (current != NULL) {
			if (current->data > alvoPilha) {
				pilhaFiltro.push(current->data);	
			} else {
				lsAux.inserirElemento(current->data);
			}

			current = current->next;
		}
		
		Node2* current2 = listasDuplas[i].getHead();

		while (current2 != NULL) {
			if (current2->data > alvoPilha) {
				pilhaFiltro.push(current2->data);	
			} else {
				ldAux.inserirElemento(current2->data);
			}

			current2 = current2->next;
		}

		vetores[i] = vetorAux;
		listasSimples[i] = lsAux;
		listasDuplas[i] = ldAux;
	}

	cout << "Iniciando processamento simultaneo... (Atividade 5)" << endl;
	this_thread::sleep_for(chrono::seconds(3));

	for (int i = 0; i < 4; ++i) {
		functionQueue.push(bind(processarVetor, vetores[i]));
		functionQueue.push(bind(mostrarListaSimples, listasSimples[i]));
		functionQueue.push(bind(mostrarListaDupla, listasDuplas[i]));
	}
	functionQueue.push(bind(processarPilha, pilhaFiltro));

    thread thread1(threadExecutor);
    thread thread2(threadExecutor);

	thread1.join();
    thread2.join();
}

int main() {
	// processamentoSincrono();
	processamentoParalelo();

    return 0;
}