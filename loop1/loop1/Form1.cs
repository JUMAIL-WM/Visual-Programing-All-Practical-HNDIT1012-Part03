using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButtonClick.Click += ButtonClick_Click;
        }

        private void ButtonClick_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            listBox1.Items.Clear();

            for (int a = 1; a <= 10; a++)
            {
                listBox1.Items.Add(a + " x " + num1 + " = " + a * num1);
            }
        }
    }
}
