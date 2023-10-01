
/* Singly Linked List (Lista Simplesmente Encadeada)
   |
   |-> Linear data structure in which
       each element of the list contains a pointer, 
       which points to the next element in the list 

   Elements are not stored in contiguous memory locations     
*/


class SinglyLinkedList {
    
    class Node {
        public:
        int data;
        Node* next;

        Node();
        Node(int data);
    };

    public:
    typedef Node Node;

    SinglyLinkedList();

    /// methods
    void prettyPrint();

    // insertion
    Node* pushNode(int);
    Node* insertNodeAfter(Node*, int);
    Node* append(int);
    
    // searching
    void searchData();

    // deletion
    void deleteNode();

    private:
    Node* head;
};
