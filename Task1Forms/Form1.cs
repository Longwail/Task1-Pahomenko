using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a, b, c;
            a = AnumericUpDown.Value;
            b = BnumericUpDown.Value;
            c = CnumericUpDown.Value;

            if (a < b + c && b < a + c && c < a + b)
                MessageBox.Show("Существует");
            else
                MessageBox.Show("Не существует");
        }
    }
}
