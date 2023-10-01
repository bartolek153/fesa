#include <iostream>
#include <chrono>
#include <thread>

#include "ListaDupla.h"
#include "Randomizer.h"

using namespace std;

Node2::Node2(int value) : data(value), prev(nullptr), next(nullptr) {}

ListaDupla::ListaDupla() : head(nullptr), tail(nullptr), size(0), highest(0) {}

Node2* ListaDupla::getHead() {
	return this->head;
}

int ListaDupla::getSize() {
	return this->size;
}

int ListaDupla::getHighest() {
	return this->highest;
}

void ListaDupla::inserirElemento() {
    Node2* newNode2 = new Node2(Randomizer::getRandom());
    if (!head) {
        head = newNode2;
        tail = newNode2;
    }
    else {
        tail->next = newNode2;
        newNode2->prev = tail;
        tail = newNode2;
    }

    size++;

    if (newNode2->data > highest)
        highest = newNode2->data;
    
}

void ListaDupla::inserirElemento(int data)
{
    Node2* newNode2 = new Node2(data);
    if (!head) {
        head = newNode2;
        tail = newNode2;
    }
    else {
        tail->next = newNode2;
        newNode2->prev = tail;
        tail = newNode2;
    }

    size++;

    if (newNode2->data > highest)
        highest = newNode2->data;
}

void mostrarListaDupla(ListaDupla list) {
    Node2* current = list.getHead();
    int i = 0;
    while (current) {
        cout << "(ld) Pagamento " << i + 1 << " processado. Valor = R$ " << current->data << endl;
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