using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericList<T> where T: IComparable<T>
    {
        private int capacity = 1;

        private T[] elements;
        private int count;

        public GenericList()
        {
            this.elements = new T[this.Capacity];
        }

        public int Capacity
        {
            set { this.capacity = value; }
            get { return this.capacity; }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T[] Elements
        {
            get
            {
                return this.elements;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = this.elements[index];
                return result;
            }
            set
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }

                this.elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (count == this.Elements.Length-1)
            {
                this.Capacity *= 2;
                T[] newArr = new T[this.Capacity];
                Array.Copy(this.Elements, 0, newArr, 0, this.Count);
                this.elements = newArr;
            }

            this.elements[count] = element;
            count++;
        }

        public void Show(int index)
        {
            if (index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format("{0} is out of Elements' range.", this.Elements.Length));
            }

            Console.WriteLine("[{0}] = {1}", index , this.elements[index]);
        }

        public void RemoveAt(int index)
        {
            if (index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format("{0} is out of Elements' range.", index));
            }

            count--;
            Array.Copy(this.elements, index + 1, this.elements, index, this.Count - index);
        }

        public void Insert(T element,int index)
        {
            if (index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format("{0} is out of Elements' range.", index));
            }

            count++;
            Array.Copy(this.elements, index, this.elements, index+1, this.Count - index -1);
            this.elements[index] = element;
        }

        public void Clear()
        {
            this.count = 0;
            this.elements = new T[this.capacity];
        }

        public override string ToString()
        {
            string result = String.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                result += String.Format("element[{0}] = {1}\n",i, Elements[i]);
            }
            
            return result;

        }

        //Methods
        public void Min()
        {
            T min = Elements[0];

            for (int i = 1; i < this.Count; i++)
            {

                if (Elements[i].CompareTo(min) <1)
                {
                    min = this.Elements[i];
                }
            }

            Console.WriteLine("Минимална стойност: {0}",min);
        }

        public void Max()
        {
            T max = Elements[0];

            for (int i = 1; i < this.Count; i++)
            {

                if (Elements[i].CompareTo(max) >= 1)
                {
                    max = this.Elements[i];
                }
            }

            Console.WriteLine("Максимална стойност: {0}", max);
        }

    }
}
