using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Int32.Parse(tbA.Text);
            int a2 = Int32.Parse(tbB.Text);
            char o = tbOp.Text[0];

            tbRes.Text = Calculator.Calc(a1, a2, o).ToString();
            
        }
    }
}
