using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, p, r;
            a = (double)AnumericUpDown.Value;

            p = (a * a * a) / 2;
            r = a / 2 * Math.Sqrt(3);
            MessageBox.Show($"Радиус равен: {Math.Round(r, 2)}");
        }
    }
}
