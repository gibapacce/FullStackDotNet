using System;

// Node class represents a single node in the doubly linked list
public class Node
{
    public int data; // Data stored in the node
    public Node prev; // Reference to the previous node
    public Node next; // Reference to the next node

    // Constructor to initialize a new node with given data
    public Node(int d)
    {
        data = d;
        prev = null;
        next = null;
    }
}

// DoublyLinkedList class represents the doubly linked list
public class DoublyLinkedList
{
    private Node head; // Reference to the first node in the list

    // Constructor to initialize an empty list
    public DoublyLinkedList()
    {
        head = null; // Empty list initially
    }

    // Function to insert a new node at the beginning of the list
    public void InsertAtBeginning(int newData)
    {
        // Create a new node with the given data
        Node newNode = new Node(newData);
        // Set the next of the new node to the current head
        newNode.next = head;
        // If head is not null, set the previous of the head to the new node
        if (head != null)
            head.prev = newNode;
        // Update the head to point to the new node
        head = newNode;
    }

    // Function to insert a new node at the end of the list
    public void InsertAtEnd(int newData)
    {
        // Create a new node with the given data
        Node newNode = new Node(newData);
        // Initialize a pointer to traverse the list
        Node lastNode = head;
        // Set the next of the new node to null
        newNode.next = null;

        // If the list is empty, make the new node as the head and return
        if (head == null)
        {
            newNode.prev = null;
            head = newNode;
            return;
        }

        // Traverse to the last node in the list
        while (lastNode.next != null)
            lastNode = lastNode.next;

        // Set the next of the last node to the new node
        lastNode.next = newNode;
        // Set the previous of the new node to the last node
        newNode.prev = lastNode;
    }

    // Function to delete a node by key
    public void DeleteNode(int key)
    {
        // Start from the head of the list
        Node temp = head;
        // If the node to be deleted is the head, update head to the next node and return
        if (temp != null && temp.data == key)
        {
            head = temp.next;
            head.prev = null;
            return;
        }

        // Search for the node with the given key
        while (temp != null && temp.data != key)
        {
            temp = temp.next;
        }

        // If the node with the given key is not found, return
        if (temp == null) return;

        // Update the references of the adjacent nodes to skip the node to be deleted
        if (temp.next != null)
        {
            temp.next.prev = temp.prev;
        }

        if (temp.prev != null)
        {
            temp.prev.next = temp.next;
        }
    }

    // Function to print the doubly linked list
    public void PrintList()
    {
        // Initialize a pointer to traverse the list
        Node lastNode = null;
        // Print the list in forward direction
        Console.WriteLine("Traversal in forward direction: ");
        while (head != null)
        {
            Console.Write(head.data + " ");
            lastNode = head;
            head = head.next;
        }
        Console.WriteLine();
        // Print the list in reverse direction
        Console.WriteLine("Traversal in reverse direction: ");
        while (lastNode != null)
        {
            Console.Write(lastNode.data + " ");
            lastNode = lastNode.prev;
        }
        Console.WriteLine();
    }

    // Function to search for an element in the list
    public bool Search(int key)
    {
        // Start from the head of the list
        Node current = head;
        // Traverse the list and search for the key
        while (current != null)
        {
            if (current.data == key)
                return true; // Key found, return true
            current = current.next; // Move to the next node
        }
        return false; // Key not found, return false
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create a new doubly linked list
        DoublyLinkedList dll = new DoublyLinkedList();

        // Insert nodes into the list
        dll.InsertAtEnd(1);
        dll.InsertAtBeginning(2);
        dll.InsertAtEnd(3);
        dll.InsertAtBeginning(4);

        // Print the list
        Console.WriteLine("Doubly Linked List:");
        dll.PrintList();

        // Delete a node from the list
        dll.DeleteNode(1);
        Console.WriteLine("Doubly Linked List after deleting node with key 1:");
        dll.PrintList();

        // Search for elements in the list
        Console.WriteLine("Is 3 present in the list? " + (dll.Search(3) ? "Yes" : "No"));
        Console.WriteLine("Is 5 present in the list? " + (dll.Search(5) ? "Yes" : "No"));
    }
}
