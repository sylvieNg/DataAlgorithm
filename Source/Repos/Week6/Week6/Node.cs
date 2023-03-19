using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class Node
    {
        private int data;
        public Node Left, Right;

        public Node(int data)
        {
            this.data = data;
            this.Left = null;
            this.Right = null;
        }
        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.Left = left;
            this.Right = right;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
