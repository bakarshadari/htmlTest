using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int startNumber = int.Parse(textBox1.Text);
            int EndNumber = int.Parse(textBox2.Text);
            for(startNumber=1; startNumber>=EndNumber;startNumber++)
            {

                listBox1.Items.Add(startNumber);
                

            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
