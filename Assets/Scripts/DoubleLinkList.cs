using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleLinkList<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }


    }
    public int count = 0;
    public Node head;
    public void InsertAtStart(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            count++;
        }
        else
        {
            newNode.Next = head;
            newNode.Previous = null;
            head.Previous = newNode;
            head = newNode;
            count++;
        }
    }

    public void InsertAtEnd(T value)
    {
        if (head == null)
        {
            InsertAtStart(value);
            count++;
        }
        else
        {
            Node newNode = new Node(value);
            Node aux = SearchLastNode();
            aux.Next = newNode;
            newNode.Previous = aux;
            count++;
        }

    }

    public void InsertAtPosition(T value, int position)
    {
        if (position == 0)
        {
            InsertAtStart(value);
        }
        else if (position == count - 1)
        {
            InsertAtEnd(value);
        }
        else if (position >= count)
        {
            throw new NullReferenceException("No puede hacer eso");
        }
        else
        {
            Node newNode = new Node(value);
            Node aux = head;
            int i = 0;
            while (i < position - 1)
            {
                i++;
                aux = aux.Next;
            }
            Node futurePast = aux.Next;
            aux.Next = newNode;
            newNode.Previous = aux;
            newNode.Next = futurePast;
            futurePast.Previous = newNode;
            count++;
        }

    }

    public void DeleteAtStart()
    {
        if (head == null)
        {
            throw new NullReferenceException("No hay nada que borrar");
        }
        else
        {
            Node aux = head.Next;
            aux.Previous = null;
            head = null;
            head = aux;
            count--;

        }
    }

    public void DeleteAtEnd()
    {
        if (head == null)
        {
            throw new NullReferenceException("No hay nada que borrar");

        }
        else if (count == 1)
        {
            DeleteAtStart();
        }
        else
        {
            Node aux = SearchLastNode();
            Node previousNode = aux.Previous;
            previousNode.Next = null;
            aux.Previous = null;
            count--;

        }
    }

    public void DeleteAtPosition(int position)
    {
        if (position == 0)
        {
            DeleteAtStart();
        }
        else if (position == count - 1)
        {
            DeleteAtEnd();
        }
        else if (position >= count)
        {
            throw new NullReferenceException("No se puede hacer eso");
        }
        else
        {
            Node aux = head;
            int i = 0;
            while (i < position - 1)
            {
                i++;
                aux = aux.Next;

            }
            Node NewFuture = aux.Next.Next;
            aux.Next = null;
            aux.Next = NewFuture;
            NewFuture.Previous = aux;
            count--;

        }
    }

    public void ModifyAtStart(T value)
    {
        if (head == null)
        {
            throw new NullReferenceException("No hay nada que modificar");
        }
        else
        {
            head.Value = value;
        }
    }

    public void ModifyAtEnd(T value)
    {
        if (head == null)
        {
            throw new NullReferenceException("No hay nada que modificar");
        }
        else if (count == 1)
        {
            ModifyAtStart(value);
        }
        else
        {
            Node aux = SearchLastNode();
            aux.Value = value;
        }
    }

    public void ModifyAtPosition(T value, int position)
    {
        if (position == 0)
        {
            ModifyAtStart(value);
        }
        else if (position == count - 1)
        {
            ModifyAtEnd(value);
        }
        else if (position >= count)
        {
            throw new NullReferenceException("No puede hacer eso");
        }
        else
        {
            Node aux = head;
            int i = 0;
            while (i < position)
            {
                i++;
                aux = aux.Next;
            }
            aux.Value = value;
        }
    }

    public T GetValueAtStart()
    {
        return head.Value;
    }
    public T GetValueAtEnd()
    {
        Node aux = SearchLastNode();
        return aux.Value;
    }
    public T GetValueAtPosition(int position)
    {
        if (position == 0)
        {
            return GetValueAtStart();
        }
        else if (position == count - 1)
        {
            return GetValueAtEnd();
        }
        else if (position >= count)
        {
            throw new NullReferenceException("No puede hacer eso");
        }
        else
        {
            Node aux = head;
            int i = 0;
            while (i < position)
            {
                aux = aux.Next;
                i++;
            }
            return aux.Value;
        }


    }
    public Node SearchLastNode()
    {
        if (head == null)
        {
            throw new Exception("No hay elementos en la lista");
        }
        Node aux = head;
        while (aux.Next != null)
        {
            aux = aux.Next;
        }
        return aux;
    }
}