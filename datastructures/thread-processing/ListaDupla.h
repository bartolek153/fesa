using namespace std;

//No da lista dupla
class Node2 {
public:
	int data;
	Node2* prev;
	Node2* next;

	Node2(int value);
};

//Lista dupla = dois ponteiros, um ao proximo no e outro ao no anterior
class ListaDupla {
    private:
	Node2* head;
	Node2* tail;
	int size;
	int highest;

    public:
	ListaDupla();

	Node2* getHead();
	int getSize();
	int getHighest();

	void inserirElemento();
	void inserirElemento(int);
};

void mostrarListaDupla(ListaDupla);