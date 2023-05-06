using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class GraphNode
    {
        private int id; // data stored in the node. 

        private LinkedList<int> adjList; // list of the IDs of the nodes that are adjacent


        // constructor of a GraphNode (pass the id of the node to be constructed)
        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        // set and get the data stored in the node 
        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        //add edge from this node to the node "to"; 
        // it is a *directed* graph. 
        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }


        // return the adjacent list of the node
        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }
    }
}
