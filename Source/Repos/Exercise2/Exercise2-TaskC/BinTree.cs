using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise2_TaskC
{
    internal class BinTree
    {
        private Node root; //member - top of the tree

        public BinTree() //create an empty tree - 
        {   //root must be set by insertItem
            root = null;
        }
        public BinTree(Node root) //create a tree with a node as the root
        {
            this.root = root;
        }

        public void InsertItem(string item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(string item, ref Node tree)
        {
            if (tree == null)
                tree = new Node(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public string Longest()
        {
            return longestItem(root);
        }

        public static string longestItem(Node tree)
        {

            if (tree == null)
            {
                return "";
            }

            string max = tree.Data;
            string currentLeft = longestItem(tree.Left);
            string currentRight = longestItem(tree.Right);

            if (currentLeft.Length > max.Length)
            {
                max = currentLeft;
            }
            if (currentRight.Length > max.Length)
            {
                max = currentRight;
            }
            return max;
        }

        public string Ancestor(string node1, string node2)
        {
            Node ancestor = findAncestor(root, node1, node2);
            return ancestor.Data;
        }

        public static Node findAncestor(Node tree, string n1, string n2)
        {

            if (tree == null)
            {
                return null;
            }

            if (tree.Data == n1 || tree.Data == n2)
            {
                return tree;
            }

            Node leftNode = findAncestor(tree.Left, n1, n2);
            Node rightNode = findAncestor(tree.Right, n1, n2);

            if (leftNode == null)
                return rightNode;
            if (rightNode == null)
                return leftNode;
            return tree;
        }
    }
}
