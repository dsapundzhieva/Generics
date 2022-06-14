using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            this.Data = new List<T>();
        }

        private List<T> Data { get; set; }

        public int Count => this.Data.Count;



        public void Add(T element)
        {
            this.Data.Add(element);
        }

        public T Remove()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("The box is empty");
            }
            var lastElement = this.Data[this.Data.Count - 1];
            this.Data.RemoveAt(this.Data.Count - 1);
            return lastElement;

        }
    }
}
