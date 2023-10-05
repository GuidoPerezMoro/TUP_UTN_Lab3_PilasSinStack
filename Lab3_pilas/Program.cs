using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> pila = new LinkedList<int>();

        pila.AddElement(1);
        pila.AddElement(2);
        pila.AddElement(3);

        Console.WriteLine("Pila inicial:");
        pila.ShowElements();

        int removedElement = pila.RemoveElement();
        Console.WriteLine($"\nElemento quitado: {removedElement}");

        Console.WriteLine("\nPila después de quitar un elemento:");
        pila.ShowElements();
    }
}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public LinkedList()
    {
        head = null;
    }

    public void AddElement(T element)
    {
        Node<T> newNode = new Node<T>(element);
        newNode.Next = head;
        head = newNode;
    }

    public T RemoveElement()
    {
        if (head == null)
        {
            throw new InvalidOperationException("La pila está vacía.");
        }

        T data = head.Data;
        head = head.Next;
        return data;
    }

    public void ShowElements()
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        //Console.WriteLine("Elementos de la pila:");
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}