using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int num1, num2;
            num1 = generator.Next(1, 1001);
            num2 = generator.Next(1, 1001);
            lblAdd.Visible = true;
            lblAdd.Text = num1 + " + " + num2 + " = " + (num1 + num2);
            btnAdd.Enabled = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int num1, num2;
            num1 = generator.Next(1, 1001);
            num2 = generator.Next(1, 1001);
            lblSubtract.Visible = true;
            lblSubtract.Text = num1 + " - " + num2 + " = " + (num1 - num2);
            btnSubtract.Enabled = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int num1, num2;
            num1 = generator.Next(1, 101);
            num2 = generator.Next(1, 101);
            lblTimes.Visible = true;
            lblTimes.Text = num1 + " × " + num2 + " = " + (num1 * num2);
            btnMultiply.Enabled = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            double num1, num2;
            num1 = generator.Next(1, 101);
            num2 = generator.Next(1, 101);
            lblDivide.Visible = true;
            lblDivide.Text = num1 + " ÷ " + num2 + " = " + Math.Round((num1 / num2), 3);
            btnDivide.Enabled = false;
        }
    }
}
