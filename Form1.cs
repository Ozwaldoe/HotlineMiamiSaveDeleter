using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Text;

namespace Save_Delete
{
    public partial class Form1 : Form
    {

        private string text = "\"steam_autocloud.vdf\"" + "\n{\n" + "    \"accountid\"" + "   \"69420\"" + "\n}"; // 

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // delete
        {
            string steamshitpath = findPath.Remove(54);
            string steampathapi = steamshitpath + @"\steam_autocloud.vdf";
            File.Delete(steampathapi);
            File.Delete(findPath);

            using (StreamWriter sw = File.CreateText(steampathapi)) {
                sw.WriteLine(text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // info box
        {
            textBox1.Text = "enter your save location in the box below";
        }

        public string findPath // finds the info inputted to the text box
        {
            get { return textBox2.Text; }
        }

        private void button1_Click(object sender, EventArgs e) // button to set the default path
        {
            defaultPath();
        }

        public void defaultPath() // sets the default path
        {
            string name = Environment.UserName;
            textBox2.Text = @$"C:\Users\{name}\Documents\My Games\HotlineMiami\SaveData.sav";
        }

        private void button3_Click(object sender, EventArgs e) // Load Path
        {
            string textFile = Environment.CurrentDirectory + @"/Config/Path.txt";
            string text = File.ReadAllText(textFile);
            textBox2.Text = text;
        }
    }
}