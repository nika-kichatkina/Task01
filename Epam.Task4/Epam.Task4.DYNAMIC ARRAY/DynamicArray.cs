using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DYNAMIC_ARRAY
{
   

    public class DynamicArray<T> : IEnumerable<T>
    {
        T[] array;
        //int Capacity;
        //int Length;

        public DynamicArray()
        {
            Capacity = 8;
            array = new T[Capacity];
            Length = 0;
        }

        public DynamicArray(int n)
        {
            Capacity = n;
            array = new T[Capacity];
            Length = 0;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            Capacity = collection.Count();
            array = new T[Capacity];
            Length = array.Length;

            int i = 0;
            foreach (var item in collection)
            {
                array[i] = item;
                i++;
            }
        }

        public void Add(T elem)
        {
            if (Capacity == Length)
            {
                Capacity *= 2;
                T[] NewArray = new T[Capacity];

                int i = 0;
                foreach (var item in array)
                {
                    NewArray[i] = item;
                    i++;
                }
                array = new T[Capacity];
                array = NewArray;

            }
            array[Length] = elem;
            Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            Capacity = collection.Count() + Length;
            T[] NewArray = new T[Capacity];

            NewArray = array;

            foreach (var item in collection)
            {
                NewArray[Length] = item;
                Length++;
            }

            array = new T[Capacity];
            array = NewArray;
        }

        public bool Remove(int iDel)
        {
            if (iDel < 0 || iDel > Length)
            {
                return false;
            }

            T[] NewArray = new T[Length - 1];
            for (int i = 0; i < iDel; i++)
            {
                NewArray[i] = array[i];
            }

            for (int i = iDel + 1, j = 0; i < Length; j++, i++)
            {
                NewArray[(iDel + 1) + j] = array[i];
            }
            Length--;
            array = NewArray;
            return true;
        }

        public bool Insert(int iPaste, T elem)
        {
            if (iPaste < 0 || iPaste > Length)
            {
                return false;
            }


            if (Capacity == Length)
            {
                Capacity *= 2;
                array = new T[Capacity];
            }

            T[] NewArray = new T[Capacity];

            for (int i = 0; i < iPaste; i++)
            {
                NewArray[i] = array[i];
            }
            NewArray[iPaste] = elem;

            for (int i = iPaste + 1, j = 0; i < Length; j++, i++)
            {
                NewArray[(iPaste + 1) + j] = array[i];
            }

            Length++;
            array = NewArray;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0; i<this.Length;i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
            {
                yield return array[i];
            }
        }

        public int Length
        {
            private set {

                this.Length = value;
            }
            get
            {
                return this.Length;
            }

        }


        public int Capacity
        {
            private set
            {
                this.Length = value;
            }
            get
            {
                return this.Length;
            }
        }

        public T this[int index]
        {
            set {
                if (index<0 || index>Length)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }

    }
}
