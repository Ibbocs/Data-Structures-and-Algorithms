using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structures_and_Algorithms
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class SinglyLinkedList<L>
    {
        
        private Node<L> head;
        private Node<L> tail;

        public void PrintList()
        {
            Node<L> current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }

        public void PrintTail()
        {
            Node<L> tailNode = tail;
            Console.WriteLine(tailNode.Data);
        }


        public void InsertAtBegin(L data)
        {
            Node<L> newNode = new Node<L>(data);

            if (head == null)
            {
                // Liste boşsa hem head hem de tail yeni düğümü gösterir
                head = newNode;
                tail = newNode;
            }
            else
            {
                // Yeni düğümü listenin başına ekleyin
                newNode.Next = head;
                head = newNode;
            }

        }

        public void InsertAtEnd(L data)
        {
            Node<L> newNode = new Node<L>(data);
            tail = newNode;

            Node<L> current = head;

            if (current == null)
            {
                head = newNode;
                //tail = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

        }

        public void InsertAfterNode(Node<L> list, L data)
        {
            if (list.Next == null)
            {
                InsertAtEnd(data);
                return;
            }

            Node<L> newNode = new Node<L>(data);
            Node<L> current = head;

            while (current != null && current != list)
            {
                current = current.Next;
            }

            if (current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            else
            {
                throw new ArgumentNullException(nameof(current));
               // throw new InvalidOperationException("Belirtilen düğüm listeye ait değil.");
            }
           
        }


        public Node<L> MyNext
        {
            get 
            {
                Node<L> node = head;

                while (node != null)
                {
                    if (node.Next is not null)
                    {
                        node = node.Next;
                    }
                }

                return node;

            }
        }

        public Node<L> Next(int key)
        {
            int count = 0;
            Node<L> node = head;

            while (node != null && count <key)
            {
                if (node.Next is not null)
                {
                    node = node.Next;
                }

                count++;
                
            }

            return node;
        }

        public Node<L> GetNodeAtIndex(int index)
        {
            int count = 0;
            Node<L> current = head;

            while (current != null && count < index)
            {
                current = current.Next;
                count++;
            }

            return current;
        }

    }
}
