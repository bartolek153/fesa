#include <iostream>
#include <random>

#include "Randomizer.h"

std::random_device rd;
std::mt19937 gen(rd());
std::uniform_int_distribution<int> distribuicao(0, 500000);

//Responsavel por criar valores aleatorios nas listas
int Randomizer::getRandom() {
	return distribuicao(gen);
}

//Intervalo aleatorio entre 0 e 10ms
int Randomizer::randomTime() {
	return rand() % 11;
}