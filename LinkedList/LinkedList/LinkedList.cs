﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        int count;

   
        public LinkedList()
        {
            head = new Node<T>(default(T));
            head.Next = head;
            head.Previous = head;
            this.count = 0;
        }
   
        public void Add(T item)
        {
            AddLast(item);
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);

            newNode.Next = head;
            newNode.Previous = head.Previous;
            head.Previous.Next = newNode;
            head.Previous = newNode;
            count++;
        }

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);

            newNode.Next = head.Next;
            newNode.Previous = head;
            head.Next = newNode;
            head.Previous.Previous = newNode;
            count++;
        }

        public void RemoveLast()
        {
            head.Previous = head.Previous.Previous;
            head.Previous.Next = head;
            count--;
        }

        public void RemoveFirst()
        {
            head.Next = head.Next.Next;
            head.Next.Previous = head;
            count--;
        }

        public void RemoveNode(Node<T> node)
        {
            Node<T> current = head.Next;
            while(current!=head)
            {
                if(current.Equals(node))
                {
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                }
                current = current.Next;
            }
        }

        public bool Find(Node<T> node)
        {
            Node<T> current = head.Next;
            while (!current.Equals(head))
            {
                if (current.Equals(node))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var node = head.Next;
            while (node!=head)
            {
                yield return node.Data;
                node = node.Next;                   
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
