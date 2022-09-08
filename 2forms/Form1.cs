using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2forms
{
    public partial class Form1 : Form
    {
        Form2 form;
        public Form1()
        {
            InitializeComponent();
            form = new Form2();
            form.Show();
            form.f = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.textBox1.Text = textBox1.Text;
        }
    }
}
