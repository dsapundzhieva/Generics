using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    internal class Box<T>
    {
        public T Property { get; set; }

        public Box(T property)
        {
            this.Property = property;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Property}";
        }
    }
}
