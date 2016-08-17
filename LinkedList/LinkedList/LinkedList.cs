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
            ExceptionForNullNode(item);

            Node<T> newNode = new Node<T>(item);

            newNode.Next = head;
            newNode.Previous = head.Previous;
            head.Previous.Next = newNode;
            head.Previous = newNode;
            count++;
        }

        public void AddFirst(T item)
        {
            ExceptionForNullNode(item);

            Node<T> newNode = new Node<T>(item);

            newNode.Next = head.Next;
            newNode.Previous = head;
            head.Next = newNode;
            head.Next.Previous = newNode;
            count++;
        }

        public void RemoveLast()
        {
            InvalidExceptionForRemove();
            head.Previous = head.Previous.Previous;
            head.Previous.Next = head;
            count--;
        }

        public void RemoveFirst()
        {
            InvalidExceptionForRemove();
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

        public Node<T> LastNode()
        {
            return head.Previous;
        }

        public Node<T> FirstNode()
        {
            return head.Next;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            var node = head.Next;
            while (node != head)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        public IEnumerator<T> GetReverseEnumerator()
        {
            var node = head.Previous;
            while(node != head)
            {
                yield return node.Data;
                node = node.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //exceptions
        private void InvalidExceptionForRemove()
        {
            if (head.Next == head)
                throw new InvalidOperationException();
        }

        private void ExceptionForNullNode(T item)
        {
            if (item == null)
                throw new ArgumentNullException();
        }
    }
}
