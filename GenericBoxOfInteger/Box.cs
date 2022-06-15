using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public T Element { get; set; }

        public Box(T element)
        {
            this.Element = element;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Element}";
        }
    }
}
