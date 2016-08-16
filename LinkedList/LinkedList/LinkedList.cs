using System;
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
