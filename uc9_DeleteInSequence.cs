using System;
using System.Collections.Generic;
using System.Text;

namespace day14_LinkedList
{
    class uc9_DeleteInSequence
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddFirst(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void AddLast(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public int Length()
        {
            Node temp;
            int Count = 0;
            temp = this.head;
            while (temp != null)
            {
                Count++;
                temp = temp.next;
            }
            return Count;
        }

        public void AddAfter(int Ploc, int data)
        {
            Node temp;
            Node p;
            int loc = Ploc, i = 1;
            int leng = this.Length();
            if (loc > leng)
            {
                Console.WriteLine("Invalid Location");
                Console.WriteLine("Current list having ", leng);
            }
            else
            {
                p = this.head;
                while (i < loc)
                {
                    p = p.next;
                    i++;
                }
                Node node = new Node(data);
                temp = node;
                temp.next = p.next;
                Console.WriteLine("{0} inserted into after {1} linked list", node.data, p.data);
                p.next = temp;
            }
        }
        public void Pop()
        {
            Node temp;
            if (this.head == null)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                temp = this.head;
                Console.WriteLine(temp.data);
                head = head.next;
                temp.next = null;
            }
        }
        public void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Node secondLast = head;
                Node temp = head;
                while (temp.next != null)
                {
                    secondLast = temp;
                    temp = temp.next;
                }
                Console.WriteLine(secondLast.data);
                temp.next = null;
            }
        }

        public void Find(int value)
        {
            Node temp = head;
            int count = 0;

            while (temp.data != value)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine(value + " index value is " + count);
        }
        public void InsertAfter(int refData, int data)
        {
            Node p = this.head;
            Node temp;

            while (p.data != refData)
            {
                p = p.next;
            }
            Node node = new Node(data);
            temp = node;
            temp.next = p.next;
            p.next = node.next;
            Console.WriteLine("{0} inserted into after {1} linked list", node.data, p.data);
            p.next = node.next;
        }
        public void remove(int value)
        {
            Node p = this.head;
            Node temp;
            Node sLValue = head;

            while (p.data != value)
            {
                sLValue = p;
                p = p.next;
            }
            temp=p.next;
            sLValue.next = p.next;
            Console.WriteLine(p.data + " is removed");
            p.next = null;
        }
    }
}
