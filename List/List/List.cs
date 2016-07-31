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
        T[] listObject = new T[0];
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
            Array.Resize(ref listObject, listObject.Length + 1);
            listObject[count] = item;
            count++;
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
            Array.Resize(ref listObject, listObject.Length + 1);
            for (int i = listObject.Length - 1; i > index; i--)
            {
                listObject[i] = listObject[i - 1];
            }
            listObject[index] = item;
            count++;
        }

        public bool Remove(T item)
        {
            RemoveAt(IndexOf(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            if(index>=0 && index < count)
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
    }
}
