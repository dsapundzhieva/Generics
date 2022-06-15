using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box(List<T> elements)
        {
            Elements = elements;
        }
        public Box(T element)
        {
            this.Element = element;
        }

        public T Element { get; set; }

        public List<T> Elements { get; set; }

        public void Swap<T>(List<T> data, int idx1, int idx2)
        {
            var firstValue = data[idx1];
            data[idx1] = data[idx2];
            data[idx2] = firstValue;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in Elements)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }
    }
}
