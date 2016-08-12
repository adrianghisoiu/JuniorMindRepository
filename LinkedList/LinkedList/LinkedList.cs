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
   
        public void AddFirstItem(T item)
        {
            head = new Node<T>(item);
        }

        public void AddLast(T item)
        {
            if (head == null)
                this.AddFirstItem(item);
            else
            {
                Node<T> newNode = new Node<T>(item);
                head.Next = newNode;
                newNode.Previous = head;
                newNode.Next = head.Previous;
            }
             ++count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = head;
            while (node != null)
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
