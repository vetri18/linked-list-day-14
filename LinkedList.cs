using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        Node head;
        Node current;
        public void Add(int data)
        {
            Node node = new Node(data);
            //no first node added to list
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //head is asigned to new node
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("{0} data is inserted ", node.data);
        }

        public void Append(int data)
        {
            Node node = new Node(data);
            //no first node added to list
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
                //assigning node to temp->next
                temp.next = node;
            }
            Console.WriteLine("{0} data is inserted ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}