using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_TaskC
{
    internal class Node
    {
        private string data;
        public Node Left, Right;

        public Node(string data)
        {
            this.data = data;
            this.Left = null;
            this.Right = null;
        }
        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.Left = left;
            this.Right = right;
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
