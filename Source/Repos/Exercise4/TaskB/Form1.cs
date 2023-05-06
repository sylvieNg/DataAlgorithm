using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskB
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph(); //member
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (graph.AddNode(name))
            {
                Names.Items.Add(name);
            }
            else
            {
                MessageBox.Show("This name already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Clear the text box value
            textBoxName.Text = null;
        }

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            string nameFrom = textBoxEdgeFrom.Text;
            string nameTo = textBoxEdgeTo.Text;
            graph.AddEdge(nameFrom, nameTo);
        }

        private void buttonFindAdjacent_Click(object sender, EventArgs e)
        {
            DirectFriends.Items.Clear();
            string specificName = textBoxSpecificName.Text;
            LinkedList<string> listOfDirectNames= graph.DisplayAdjNodes(specificName);
            foreach (string name in listOfDirectNames)
            {
                DirectFriends.Items.Add(name);
            }
            //Clear the text box value
            textBoxSpecificName.Text = null;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            graph.RemoveNode(name);
            LinkedList<GraphNode> nodes = graph.DisplayAllNodes();
            Names.Items.Clear();
            foreach (GraphNode node in nodes)
            {
                Names.Items.Add(node.Name);
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            string name = textBoxFriends.Text;
            LinkedList<GraphNode> friends = graph.GetDirectAndIndirectFriends(name);
            DirectFriends.Items.Clear();
            foreach (GraphNode friend in friends)
            {
                DirectFriends.Items.Add(friend.Name);
            }
        }
    }
}
