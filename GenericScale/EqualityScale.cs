using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        private T Left { get; set; }

        private T Right { get; set; }

        public bool AreEqual()
        {
            bool result = this.Left.Equals(this.Right);
            return result;
        }

    }
}
