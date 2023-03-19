using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed2
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

        public void InOrder()  //starts recursive inOrder at root node
        {
            inOrder(root); //call recursive at the top of the tree
        }

        private void inOrder(Node tree)
        {
            if (tree != null)  //not empty
            {
                inOrder(tree.Left);
                Console.Write(tree.Data + ",");
                inOrder(tree.Right);
            }
        }

        public void PreOrder()  //starts recursive inOrder at root node
        {
            preOrder(root); //call recursive at the top of the tree
        }

        public void preOrder(Node tree)
        {
            if (tree != null)
            {
                Console.Write("{0} ", tree.Data);
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        public void PostOrder()  //starts recursive inOrder at root node
        {
            postOrder(root); //call recursive at the top of the tree
        }

        public void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write("{0} ", tree.Data);
            }
        }

        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
                tree = new Node(item);

            else if (item < tree.Data)
                insertItem(item, ref tree.Left);

            else if (item > tree.Data)
                insertItem(item, ref tree.Right);
        }

        public bool Contains(int item)
        {
            return containItem(item, ref root);
        }

        public static bool containItem(int item, ref Node tree)
        {
            if (tree == null)
                return false;
            if (tree.Data == item)
                return true;
            if (item < tree.Data)
                return containItem(item, ref tree.Left);
            else
                return containItem(item, ref tree.Right);
        }
    }
}
