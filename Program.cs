using System;
using System.Reflection;

public class LinkedList
{
    public class Node
    {
        public char x;
        public Node next;
        public Node(char x)
        {
            this.x = x;
            this.next = null;
        }
    }
    public static Node head;
    public static Node tail;
    public static int size;
    /// <summary>
    /// just a method to print our LinkedList
    /// </summary>
    public void Print()  //O(n)
    {
        if (head == null)
        {
            Console.WriteLine("LL is empty");
            return;
        }
        //storing head in a temporary node
        Node temp = head;
        //this loop will work till temporary point towards next
        while (temp != null)
        {
            Console.Write(temp.x + "->");
            temp = temp.next; //once the data will be printed temporary will point towards the next node
        }
        Console.WriteLine("null");
    }
    /// <summary>
    /// a method to add a node in the beginning of the list, set as private because it will be used in Add method
    /// </summary>
    /// <param name="x"></param>
    private void AddFirst(char x)  //O(1)
    {
        //making a new node
        Node newNode = new Node(x);
        size++;
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
    }
    /// <summary>
    /// a method to add a Node at a specific index
    /// </summary>
    /// <param name="idx"></param>
    /// <param name="x"></param>
    public void Add(int idx, char x) //O(n)
    {
        if (idx == 0)
        {
            AddFirst(x);//calling AddFirst method  to add an element at the 0th index(at first place)
            return;
        }
        Node newNode = new Node(x);
        size++;
        Node temp = head; //making a temporary node and iterating it till a Node before the node at index idx 
        int i = 0;
        while (i < idx - 1)
        {
            temp = temp.next;
            i++;
        }
        // i = idx-1; temp -> prev
        newNode.next = temp.next;
        temp.next = newNode;
    }
    /// <summary>
    /// a method to remove an element at a specific index
    /// </summary>
    /// <param name="n"></param>
    public void Remove(int n) //O(n)
    {
        //calculate size
        int sz = 0;
        Node temp = head;
        while (temp != null)
        {
            temp = temp.next;
            sz++;
        }
        //if we have to remove the first node
        if (n == sz)
        {
            head = head.next; //removing head
            return;
        }
        //as n from the end  is equal to size-n+1 from the start, but we have to find a node one previous to the element that needs to be remove
        //so we will iterate till size-n
        //and to make that node points to the Node one after the node to be removed, the node which we want to delete will be garbage collected 
        int i = 1;
        int iToFind = sz - n;
        Node prev = head;
        while (i < iToFind)
        {
            prev = prev.next;
            i++;
        }
        prev.next = prev.next.next;
        return;
    }
    /// <summary>
    /// a method for getting an element by passing index as an argument
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public char Get(int index) //O(n)
    {
        if (index < 0 || index > size)
        {
            throw new IndexOutOfRangeException("Index " + index + " is out of bounds.");
        }
        Node temp = head;
        for (int i = 0; i < index; i++)
        {
            temp = temp.next;
        }

        return temp.x;
    }
    /// <summary>
    /// a method to set an element at a specific index
    /// </summary>
    /// <param name="index"></param>
    /// <param name="x"></param>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public void Set(int index, char x) //O(n)
    {
        if (head == null)
        {
            throw new IndexOutOfRangeException("List is empty");
        }
        Node temp = head;
        for (int i = 0; i < index; i++)
        {
            if (temp.next == null)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            temp = temp.next;
        }
        temp.x = x;
    }
}
class CodeTest
{
    public static void Main(String[] args)
    {
        LinkedList ll = new LinkedList();
        ll.Add(0, 'a');
        ll.Add(1, 'b');
        ll.Add(2, 'a');
        ll.Add(3, 'c');
        ll.Print();
        ll.Remove(3);
        ll.Print();
        Console.WriteLine(ll.Get(1));
        ll.Set(2, 'e');
        ll.Print();
        ll.Set(2, 'f');
        ll.Print();
    }
}
