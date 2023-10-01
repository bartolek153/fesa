using namespace std;

class Node {  //No da lista simples
public:
	int data;
	Node* next;

	Node(int data);
};

//Lista simples = possui apenas um ponteiro ao proximo no
class ListaSimples
{
    private:
		Node* head;
		int size;
		int highest;

    public:
		ListaSimples();

		Node* getHead();
		int getSize();
		int getHighest();

		void inserirElemento();
		void inserirElemento(int);
		void mostrarLista();
};

void mostrarListaSimples(ListaSimples);
