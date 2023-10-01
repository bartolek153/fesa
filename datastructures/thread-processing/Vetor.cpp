#include <iostream>
#include <vector>
#include <chrono>
#include <thread>

#include "Randomizer.h"

using namespace std;


//Escreve os valores aleatorios nos vetores
void preencherVetor(vector<int>& vetor, int qtnd) {
	for (int i = 0; i < qtnd; i++) {
		vetor.push_back(Randomizer::getRandom());
	}
}

//Le e imprime os valores dos vetores
void processarVetor(vector<int>& vetor) {
	for (int i = 0; i < vetor.size(); i++) {
		cout << "(vc) Pagamento " << i + 1 << " processado. Valor = R$ " << vetor[i] << endl;
		int intervalo = Randomizer::randomTime();
		this_thread::sleep_for(chrono::milliseconds(intervalo));
	}
}