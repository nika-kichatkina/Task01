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
        private T[] array;

        public DynamicArray()
        {
            this.Capacity = 8;
            this.array = new T[this.Capacity];
            this.Length = 0;
        }

        public DynamicArray(int n)
        {
            this.Capacity = n;
            this.array = new T[this.Capacity];
            this.Length = 0;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            this.Capacity = collection.Count();
            this.array = new T[this.Capacity];
            this.Length = this.array.Length;

            int i = 0;
            foreach (var item in collection)
            {
                this.array[i] = item;
                i++;
            }
        }

        public int Length
        {
            get;
            private set;
        }

        public int Capacity
        {
            get;
            private set;
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }

            set
            {
                if (index < 0 || index > this.Length)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }

                this.array[index] = value;
            }
        }

        public void Add(T elem)
        {
            if (this.Capacity == this.Length)
            {
                this.Capacity *= 2;
                T[] newArray = new T[this.Capacity];

                int i = 0;
                foreach (var item in this.array)
                {
                    newArray[i] = item;
                    i++;
                }

                this.array = new T[this.Capacity];
                this.array = newArray;
            }

            this.array[this.Length] = elem;
            this.Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            this.Capacity = collection.Count() + this.Length;
            T[] newArray = new T[this.Capacity];

            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            foreach (var item in collection)
            {
                newArray[this.Length] = item;
                this.Length++;
            }

            this.array = new T[this.Capacity];
            this.array = newArray;
        }

        public bool Remove(int delI)
        {
            if (delI < 0 || delI > this.Length)
            {
                return false;
            }

            T[] newArray = new T[this.Length - 1];
            for (int i = 0; i < delI; i++)
            {
                newArray[i] = this.array[i];
            }

            for (int i = delI + 1, j = 0; i < this.Length; j++, i++)
            {
                newArray[delI + j] = this.array[i];
            }

            this.Length--;
            this.array = newArray;
            return true;
        }

        public bool Insert(int pasteI, T elem)
        {
            if (pasteI < 0 || pasteI > this.Length)
            {
                return false;
            }

            if (this.Capacity == this.Length)
            {
                T[] newArray = new T[this.Capacity];
                newArray = this.array;
                this.Capacity *= 2;

                this.array = new T[this.Capacity];
                for (int i = 0; i < newArray.Length; i++)
                {
                    this.array[i] = newArray[i];
                }
            }

            T[] newArray1 = new T[this.Capacity];

            for (int i = 0; i < pasteI; i++)
            {
                newArray1[i] = this.array[i];
            }

            newArray1[pasteI] = elem;

            for (int i = pasteI, j = 0; i < this.Length; j++, i++)
            {
                newArray1[(pasteI + 1) + j] = this.array[i];
            }

            this.Length++;
            this.array = newArray1;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)

            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
            {
                yield return this.array[i];
            }
        }
    }
}
