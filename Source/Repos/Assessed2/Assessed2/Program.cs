using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessed2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(4);

            BinTree binTree = new BinTree(root);
            binTree.InsertItem(3);
            binTree.InsertItem(7);
            binTree.InsertItem(1);
            binTree.InsertItem(5);
            binTree.InsertItem(9);
            binTree.InOrder();
            Console.WriteLine();
            binTree.PreOrder();
            Console.WriteLine();
            binTree.PostOrder();
            Console.WriteLine();

            if (!binTree.Contains(10))
            {
                Console.WriteLine("The binary tree does not contain this item");
            }
            else
            {
                Console.WriteLine("The binary tree contains this item");
            }

            if (!binTree.Contains(4))
            {
                Console.WriteLine("The binary tree does not contain this item");
            }
            else
            {
                Console.WriteLine("The binary tree contains this item");
            }

            Console.ReadKey();
        }
    }
}
