using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskB
{
    internal class Graph
    {
        // list of graphnodes in the graph (represents all the nodes present in the graph)
        private LinkedList<GraphNode> nodes;
        private int edgeCount;

        // constructor of a Graph. Construct a graph and set 
        // the list of nodes in the graph to be the empty list;
        // the constructed graph has no nodes
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }


        // Add a new node (with the specific name) to the graph. Use the constructor of graphnode
        // "AddLast" adds the constructed graphnode to the list of all nodes.
        // May also use "AddFirst" - as long as the new node is added to the list of the nodes 
        // it does not matter where it is added (first or last)
        public bool AddNode(string name)
        {
            if (nodes.Any(n => n.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            nodes.AddLast(new GraphNode(name));
            return true;
        }


        //Return the graphnode with the specific name passed as input argument
        public GraphNode GetNodeByID(string name)
        {
            //Search through the list of all nodes in the graph for the node with the specific name
            foreach (GraphNode n in nodes)
            {
                // found the node n with the specific name; return n
                if (name == n.Name)
                    return n;
            }
            // the node has not been found (no node with the specific name is present in the graph)
            return null;
        }


        // add a directed edge between node with name= "from" and the node with name= "to" 
        public void AddEdge(string from, string to)
        {
            // get the graphnode that corresponds to the node with name = from

            GraphNode n1 = GetNodeByID(from);

            // get the graphnode that corresponds to the node with name = to

            GraphNode n2 = GetNodeByID(to);

            // add a directed edge going from node n1 to node 2 
            //(use the AddEdge method defined in the class GraphNode)
            if (n1 == null)
            {
                return;
            }
            n1.AddEdge(n2);
            edgeCount++;
        }

        public LinkedList<string> DisplayAdjNodes(string inputName)
        {
            // Get the GraphNode of the node with name = inputName
            // and store it in the variable n
            GraphNode n = GetNodeByID(inputName);  // needs to be completed; can use GetNodebyID 

            // Get and store in adjl the adjacency list of the node n
            if (n != null)
                return n.GetAdjList(); // needs to be completed; can use GetAdjList
            else
                return new LinkedList<string>();


        }

        public LinkedList<GraphNode> DisplayAllNodes()
        {
            return nodes;
        }

        public void RemoveNode(string name)
        {
            GraphNode nodeToRemove = GetNodeByID(name);
            if (nodeToRemove != null)
            {
                // Remove all edges going to the node to remove
                foreach (GraphNode node in nodes)
                {
                    LinkedList<string> adjList = node.GetAdjList();
                    if (adjList.Contains(name))
                    {
                        adjList.Remove(name);
                        edgeCount--;
                    }
                }
                // Remove the node from the list of nodes
                nodes.Remove(nodeToRemove);
            }
        }

        public LinkedList<GraphNode> GetDirectAndIndirectFriends(string name)
        {
            // Find the starting node with the given name
            GraphNode root = null;
            foreach (GraphNode node in nodes)
            {
                if (node.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    root = node;
                    break;
                }
            }

            //Checking on the person name
            if (root == null)
            {
                MessageBox.Show($"This {name} not exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new LinkedList<GraphNode>();
            }
            else
            {
                LinkedList<GraphNode> reachableNodes = FindChildNodes(root);
                return reachableNodes;
            }
        }

        public LinkedList<GraphNode> FindChildNodes(GraphNode startNode)
        {
            LinkedList<GraphNode> childNodes = new LinkedList<GraphNode>();
            Traverse(startNode, childNodes);
            return childNodes;
        }

        private void Traverse(GraphNode node, LinkedList<GraphNode> childNodes)
        {
            if (!childNodes.Contains(node))
            {
                childNodes.AddLast(node);
                foreach (string neighborName in node.GetAdjList())
                {
                    GraphNode neighbor = GetNodeByID(neighborName);
                    if (neighbor != null)
                    {
                        Traverse(neighbor, childNodes);
                    }
                }
            }
        }
    }
}
