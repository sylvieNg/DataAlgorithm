using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        Dictionary<int, Student> universityDic; //member
        public Form1()
        {
            universityDic = new Dictionary<int, Student>();
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            Student student = new Student(id, name, true);

            universityDic[student.Id] = student;

            //Clear the text box value
            textBoxId.Text = null;
            textBoxName.Text = null;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxSearch.Text);
            universityDic.Remove(id);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxSearch.Text);
            if (universityDic.ContainsKey(id))
            {
                Student student = universityDic[id];
                listBoxStudent.Items.Clear();
                listBoxStudent.Items.Add(student.Name + " - " + student.Status.ToString());
            }
            else
            {
                listBoxStudent.Items.Clear();
                listBoxStudent.Items.Add("Student Not found!!!");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxSearch.Text);
            if (universityDic.ContainsKey(id))
            {
                Student student = universityDic[id];
                student.Status = !student.Status;
                listBoxStudent.Items.Clear();
                listBoxStudent.Items.Add(student.Name + " - " + student.Status.ToString());
            }
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxStudent.Items.Clear();
            foreach (KeyValuePair<int, Student> student in universityDic)
            {
                if (student.Value.Status == true)
                {
                    Student s = universityDic[student.Key];
                    listBoxStudent.Items.Add(s.Id + " - " + s.Name);
                }
            }
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            listBoxStudent.Items.Clear();
            foreach (KeyValuePair<int, Student> student in universityDic)
            {
                if (student.Value.Name == name)
                {
                    Student s = universityDic[student.Key];
                    listBoxStudent.Items.Add(s.Id + " - " + s.Status);
                }
            }
        }
    }
}
