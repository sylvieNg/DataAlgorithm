using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(6);
            root.Left = new Node(3);
            root.Right = new Node(8);
            root.Left.Left = new Node(1);
            root.Left.Right = new Node(5);
            root.Right.Right = new Node(9);

            BinTree binTree = new BinTree(root);
            binTree.InsertItem(30);
            binTree.InOrder();
            int treeCount = binTree.Count();
            Console.WriteLine("TreeCount: " + treeCount);
            Console.WriteLine("TreeHeight: " + binTree.Height());

            Console.ReadKey();
        }
    }
}
