namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                messageTextBox.ForeColor = Color.Red;
            }
            else
            {
                messageTextBox.ForeColor = Color.Black;
            }
        }
    }
}