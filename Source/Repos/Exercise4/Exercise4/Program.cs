using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);

            Console.WriteLine("Total number of nodes: " + graph.NumNodesGraph());

            Console.WriteLine("Total number of edges: " + graph.NumEdgesGraph());

            Console.ReadKey();
        }
    }
}
