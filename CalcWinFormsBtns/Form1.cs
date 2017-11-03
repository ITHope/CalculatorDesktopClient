using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinFormsBtns
{
    public partial class FormCalcBtns : Form
    {
        public FormCalcBtns()
        {
            InitializeComponent();
        }


        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbCalc.Text += btn.Text;
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            tbCalc.Text += btn.Text;

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            string formula = tbCalc.Text;
            char op = '.';

            foreach(char c in formula)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                    op = c;
            }
            string[] parts = formula.Split(op);
            if (op != '.' && parts.Length == 2)
            {
                if (formula.StartsWith("-"))
                    tbCalc.Text = Calculator.Calc(-Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();
                else
                    tbCalc.Text = Calculator.Calc(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();

            }

        }
    }
}
