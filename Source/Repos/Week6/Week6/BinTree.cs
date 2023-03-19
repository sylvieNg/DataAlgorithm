using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
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

        public int Count()
        {
            return count(root);
        }

        private int count(Node tree)
        {
            if (tree == null)
                return 0;
            return count(tree.Left) + count(tree.Right) + 1;
        }

        //public void Insert(int item)  //starts recursive inOrder at root node
        //{
        //    insertItem(root, item); //call recursive at the top of the tree
        //}

        //private void insertItem(Node root, int key)
        //{
        //    //Create new node
        //    Node newnode = new Node(key);
        //    //use to tranverse from root to child node
        //    Node x = root;
        //    Node y = null;

        //    while (x != null)
        //    {
        //        y = x;
        //        if (key < x.Data)
        //            x = x.Left;
        //        else
        //            x = x.Right;
        //    }

        //    //The new node is the root node
        //    if (y == null)
        //    {
        //        root = newnode;
        //    }
        //    else if (key < y.Data)
        //    {
        //        y.Left = newnode;
        //    }
        //    else
        //    {
        //        y.Right = newnode;
        //    }
        //}

        public int Height()
        {
            return height(root);
        }

        private int height(Node tree)
        {
            if (tree == null)
                return 0;
            return Math.Max(count(tree.Left), count(tree.Right)) + 1;
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

        public void RemoveItem(int item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(int item, ref Node tree)
        {
            if (tree == null) //if tree is null, no need to delete
                return;
            else if (tree.Right == null && tree.Left == null) //if the tree does not have child node, then delete the only root
            {
                tree = null;
            }
            else if (tree.Left != null && tree.Right != null) //
            {
                var maxNode = FindMax(tree.Right);
                //copy the value
                tree.Data = maxNode.Data;
                removeItem(maxNode.Data, ref tree.Right);
            }
            else //if the tree only have one child
            {
                Node child = tree.Left != null ? tree.Left : tree.Right;
                tree = child;
            }
        }

        private Node FindMax(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }
    }
}
