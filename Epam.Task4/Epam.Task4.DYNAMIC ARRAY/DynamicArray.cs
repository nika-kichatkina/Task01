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
        public DynamicArray()
        {
            this.Capacity = 8;
            this.MyArray = new T[this.Capacity];
            this.Length = 0;
        }

        public DynamicArray(int n)
        {
            this.Capacity = n;
            this.MyArray = new T[this.Capacity];
            this.Length = 0;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            this.Capacity = collection.Count();
            this.MyArray = new T[this.Capacity];
            this.Length = this.MyArray.Length;

            int i = 0;
            foreach (var item in collection)
            {
                this.MyArray[i] = item;
                i++;
            }
        }

        public int Length
        {
            get;
            protected set;
        }

        public int Capacity
        {
            get;
            set;
        }

        protected T[] MyArray
        {
            get;
            set;
        }

        public virtual T this[int index]
        {
            get
            {
                return this.MyArray[index];
            }

            set
            {
                if (index < 0 || index > this.Length)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }

                this.MyArray[index] = value;
            }
        }

        public void Add(T elem)
        {
            if (this.Capacity == this.Length)
            {
                this.Capacity *= 2;
                T[] newArray = new T[this.Capacity];

                int i = 0;
                foreach (var item in this.MyArray)
                {
                    newArray[i] = item;
                    i++;
                }

                this.MyArray = new T[this.Capacity];
                this.MyArray = newArray;
            }

            this.MyArray[this.Length] = elem;
            this.Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            this.Capacity = collection.Count() + this.Length;
            T[] newArray = new T[this.Capacity];

            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this.MyArray[i];
            }

            foreach (var item in collection)
            {
                newArray[this.Length] = item;
                this.Length++;
            }

            this.MyArray = new T[this.Capacity];
            this.MyArray = newArray;
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
                newArray[i] = this.MyArray[i];
            }

            for (int i = delI + 1, j = 0; i < this.Length; j++, i++)
            {
                newArray[delI + j] = this.MyArray[i];
            }

            this.Length--;
            this.MyArray = newArray;
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
                newArray = this.MyArray;
                this.Capacity *= 2;

                this.MyArray = new T[this.Capacity];
                for (int i = 0; i < newArray.Length; i++)
                {
                    this.MyArray[i] = newArray[i];
                }
            }

            T[] newArray1 = new T[this.Capacity];

            for (int i = 0; i < pasteI; i++)
            {
                newArray1[i] = this.MyArray[i];
            }

            newArray1[pasteI] = elem;

            for (int i = pasteI, j = 0; i < this.Length; j++, i++)
            {
                newArray1[(pasteI + 1) + j] = this.MyArray[i];
            }

            this.Length++;
            this.MyArray = newArray1;
            return true;
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)

            {
                yield return this.MyArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
            {
                yield return this.MyArray[i];
            }
        }
    }
}
