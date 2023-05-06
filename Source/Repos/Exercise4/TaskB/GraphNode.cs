using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB
{
    internal class GraphNode
    {
        private string name; // data stored in the node. 

        private LinkedList<string> adjList; // list of the names of the nodes that are adjacent


        // constructor of a GraphNode (pass the name of the node to be constructed)
        public GraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        // set and get the data stored in the node 
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //add edge from this node to the node "to"; 
        // it is a *directed* graph. 
        public void AddEdge(GraphNode to)
        {
            if (to == null)
            {
                return;
            }
            if (!adjList.Any(name => name.Equals(to.Name, StringComparison.OrdinalIgnoreCase)))
            {
                adjList.AddLast(to.Name);
            }
        }


        // return the adjacent list of the node
        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }
    }
}
