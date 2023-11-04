using System.Collections;

namespace LinkedList;

public class LinkedList<T>
{
    private class LinkedListNode<T>
    {
        
        public T data;
        public LinkedListNode<T> Next;
        public static LinkedListNode<T> operator ++(LinkedListNode<T> node) => node?.Next;
        public LinkedListNode(T data)
        {
            this.data = data;
            Next = null;
        }

        public LinkedListNode(T data, LinkedListNode<T> next)
        {
            this.data = data;
            Next = next;
        }
    }
    public int Count { get; private set; }
    private LinkedListNode<T> _head;
    public LinkedList()
    {
        _head = null;
        Count = 0;
        
    }
    
    public void Print()
    {
        if (Count == 0)
        {
            Console.WriteLine("No Element");
            return;
        }
        var tmpHead = _head;
        while (tmpHead != null)
        {
            Console.Write($"{tmpHead.data}->");
            tmpHead = tmpHead++;
        }

        Console.WriteLine();
    }

    public void Add(T data)
    {
        LinkedListNode<T> node = new LinkedListNode<T>(data);
       
        if (Count == 0)
        {
            _head = node;
            node.Next = null;
            Count++;
            return;

        }
        var tmpNode = _head;
        while (tmpNode++ != null)
        {
            tmpNode = tmpNode++;
        }
        tmpNode.Next = node;
        Count++;
    }

    public void Delete(T data)
    {
        if (Count == 0)
        {
            throw new Exception("No Elements in Linked List");
        }

        LinkedListNode<T> tmpHead = _head;
        LinkedListNode<T> tmp = null;
        while (!tmpHead.data.Equals(data))
        {
            tmp = tmpHead;
            tmpHead = tmpHead++;
        }

        if (tmp is null)
        {
            _head = _head++;
            Count--;
            return;
        }
        tmp.Next = tmpHead++;
        Count--;
    }

 
}