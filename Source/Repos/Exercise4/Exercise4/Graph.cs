using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
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


        // Add a new node (with the specific id) to the graph. Use the constructor of graphnode
        // "AddLast" adds the constructed graphnode to the list of all nodes.
        // May also use "AddFirst" - as long as the new node is added to the list of the nodes 
        // it does not matter where it is added (first or last)
        public void AddNode(int id)
        {
            nodes.AddLast(new GraphNode(id));
        }


        //Return the graphnode with the specific id passed as input argument
        public GraphNode GetNodeByID(int id)
        {
            //Search through the list of all nodes in the graph for the node with the specific id
            foreach (GraphNode n in nodes)
            {
                // found the node n with the specific id; return n
                if (id == n.ID)
                    return n;
            }
            // the node has not been found (no node with the specific id is present in the graph)
            return null;
        }


        // add a directed edge between node with id= "from" and the node with id= "to" 
        public void AddEdge(int from, int to)
        {
            // get the graphnode that corresponds to the node with id = from

            GraphNode n1 = GetNodeByID(from);

            // get the graphnode that corresponds to the node with id = to

            GraphNode n2 = GetNodeByID(to);

            // add a directed edge going from node n1 to node 2 
            //(use the AddEdge method defined in the class GraphNode)

            n1.AddEdge(n2);
            edgeCount++;
        }

        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            return nodes.Count;
        }

        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {

            return edgeCount;

        }
    }
}
