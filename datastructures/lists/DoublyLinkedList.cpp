// #include <iostream>
// #include "SinglyLinkedList.h"

// using namespace std;

// // Node constructor definitions
// SinglyLinkedList::Node::Node() : data(0), next(nullptr) {}
// SinglyLinkedList::Node::Node(int data) : data(data), next(nullptr) {}

// // SinglyLinkedList constructor definition
// SinglyLinkedList::SinglyLinkedList() : head(nullptr) {}

// void SinglyLinkedList::print() {
   
// }

// void SinglyLinkedList::prettyPrint() {
//     Node* temp = head;
//     int indexCount = 0;
  
//     // Check for empty list.
//     if (head == NULL) {
//         cout << "List is empty." << endl;
//         return;
//     }

//     cout << "[" << temp->data << "]";
//     temp = temp->next;

//     // Traverse the list.
//     while (temp != NULL) {
//         cout << "->" << "[" << temp->data << "]";
//         temp = temp->next;
//         indexCount++;
//     }
    
//     cout << endl;
//     printf("Found %d elements.\n", indexCount);
// }

// // Insertion definitions
// void SinglyLinkedList::pushNode(int newData) {

//     // 1. allocate node
//     Node* newNode = new Node();

//     newNode->data = newData;     // 2. put in the data
//     newNode->next = this->head; // 3. Make next of new node as head

//     // 4. Move the head to point to
//     // the new node
//     this->head = newNode;
// }

// void SinglyLinkedList::insertNodeAfter(Node* prev_node, int newData) {

// }