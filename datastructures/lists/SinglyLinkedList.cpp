#include <iostream>
#include "SinglyLinkedList.h"

using namespace std;

// Node constructor definitions
SinglyLinkedList::Node::Node() : data(0), next(nullptr) {}
SinglyLinkedList::Node::Node(int data) : data(data), next(nullptr) {}

// SinglyLinkedList constructor definition
SinglyLinkedList::SinglyLinkedList() : head(nullptr) {}

void SinglyLinkedList::prettyPrint() {
    
    Node* temp = head;
  
    // Check for empty list.
    if (head == NULL) {
        cout << "List is empty." << endl;
        return;
    }

    int indexCount = 1;

    cout << "HEAD\n";
    cout << "[" << temp->data << "]";
    temp = temp->next;

    // Traverse the list.
    while (temp != NULL) {
        cout << "->" << "[" << temp->data << "]";
        temp = temp->next;
        indexCount++;
    }
    
    cout << endl;
    printf("Found %d elements.\n", indexCount);
}

// Insertion definitions
SinglyLinkedList::Node* SinglyLinkedList::pushNode(int newData) {

    // 1. allocate node
    Node* newNode = new Node();

    newNode->data = newData;     // 2. put in the data
    newNode->next = this->head; // 3. Make next of new node as head

    // 4. Move the head to point to
    // the new node
    this->head = newNode;

    return newNode;
}

SinglyLinkedList::Node* SinglyLinkedList::insertNodeAfter(Node* prev_node, int newData) {
    // 1. Check if the given prev_node is NULL
    if (prev_node == NULL) {
        cout << "The given previous node cannot be NULL";
        return nullptr;
    }
 
    // 2. Allocate new node
    Node* newNode = new Node();
 
    newNode->data = newData;  // 3. Put in the data
    newNode->next = prev_node->next;  // 4. Make next of new node as
                                       // next of prev_node
    // 5. move the next of prev_node
    // as new_node
    prev_node->next = newNode;

    return newNode;
}

SinglyLinkedList::Node* SinglyLinkedList::append(int newData)
{
    Node* newNode = new Node();
    Node* last = this->head;
    
    newNode->data = newData;
    newNode->next = NULL;  // will be the last node

    if (this->head == NULL) {   // if the list is empty,
        this->head = newNode;  // make new node as head
        return nullptr;
    }

    while (last->next != NULL) {
        last = last->next;
    }

    last->next = newNode;

    return newNode;
}
