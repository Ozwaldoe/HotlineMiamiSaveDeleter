using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace Save_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // delete
        {
            File.Delete(findText);
        }

        static string username()
        {
            return Environment.UserName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter your save location in the box below";
        }

        public string findText
        {
            get { return textBox2.Text; }
        }
    }
}