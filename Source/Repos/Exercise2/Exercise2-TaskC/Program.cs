using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_TaskC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("hello");

            BinTree binTree = new BinTree(root);
            binTree.InsertItem("from");
            binTree.InsertItem("done");
            binTree.InsertItem("ants");
            binTree.InsertItem("joinnnn");
            binTree.InsertItem("idea");
            binTree.InsertItem("lime");
            binTree.InsertItem("waif");

            Console.WriteLine("Longest word: " + binTree.Longest());
            Console.WriteLine("Ancestor word: " + binTree.Ancestor("done", "lime"));

            Console.ReadKey();
        }
    }
}
