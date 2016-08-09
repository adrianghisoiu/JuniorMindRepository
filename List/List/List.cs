using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        T[] listObject = new T[1];
        int count = 0;

        public T this[int index]
        {
            get
            {
                return listObject[index]; 
            }

            set
            {
                listObject[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            ResizeOfList();
            listObject[count] = item;
            count++;
        }

        private void ResizeOfList()
        {
            if (listObject.Length - 1 == count)
                Array.Resize(ref listObject, listObject.Length * 2);
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++) 
                if (listObject[i].Equals(item))
                    return true;
                return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException();

            ArgumentRangeException(arrayIndex);

            if (array.Length > count - arrayIndex)
                throw new ArgumentException();

            int j = arrayIndex;
            for(int i = 0; i < count; i++)
            {
                array.SetValue(listObject[i],j);
                j++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return listObject[i];
        }

        public int IndexOf(T item)
        {
            int index = 0;
            for(int i = 0; i < count; i++)
            {
                if(listObject[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Insert(int index, T item)
        {
            ResizeOfList();
            for (int i = listObject.Length - 1; i > index; i--)
            {
                listObject[i] = listObject[i - 1];
            }
            listObject[index] = item;
            count++;
        }

        public bool Remove(T item)
        {
            if(Contains(item))
            {
                RemoveAt(IndexOf(item));
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            ArgumentRangeException(index);

            if (index < listObject.Length)
            {
                for (int i = index; i < count - 1; i++)
                {
                    listObject[i] = listObject[i + 1];
                }
                count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ArgumentRangeException(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();
        }

    }
}
