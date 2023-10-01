#include <iostream>
#include <chrono>
#include <thread>

#include "ListaSimples.h"
#include "Randomizer.h"

using namespace std;

Node::Node(int data) : data(data), next(nullptr) {}

ListaSimples::ListaSimples() : head(nullptr), size(0), highest(0) {}

void ListaSimples::inserirElemento() {
	Node* newNode = new Node(Randomizer::getRandom());
	if (!head) {
		head = newNode;
	}
	else {
		newNode->next = head;
		head = newNode;
	}
	size++;
}

void ListaSimples::inserirElemento(int data)
{
	Node* newNode = new Node(data);
	if (!head) {
		head = newNode;
	}
	else {
		newNode->next = head;
		head = newNode;
	}
	size++;
}

Node* ListaSimples::getHead() {
	return this->head;
}

int ListaSimples::getSize() {
	return this->size;
}

int ListaSimples::getHighest() {
	return this->highest;
}

// void ListaSimples::mostrarLista() {
void mostrarListaSimples(ListaSimples list) {
	Node* current = list.getHead();
	int i = 0;
	while (current) {
		cout << "(ls) Pagamento " << i + 1 << " processado. Valor = R$ " << current->data << endl;
		int intervalo = Randomizer::randomTime();
		this_thread::sleep_for(chrono::milliseconds(intervalo));
		current = current->next;
		i++;

		if (i >= list.getSize()) {
			break;
		}
	}
	cout << endl;
}