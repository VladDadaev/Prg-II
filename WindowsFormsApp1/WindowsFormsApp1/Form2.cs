using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string surname = textBox3.Text;
            int age = int.Parse(textBox4.Text);
            string country = textBox2.Text;
            string city = textBox3.Text;
            string street = textBox3.Text;
            int house = int.Parse(textBox4.Text);
        }
    }
}
        