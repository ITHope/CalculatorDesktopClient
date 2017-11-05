using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Threading;

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

        private void btnRes_ClickAsync(object sender, EventArgs e)
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
                    tbCalc.Text = CalcAsync(-Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).Result.ToString();
                else
                    tbCalc.Text = CalcAsync(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).Result.ToString();


                //if (formula.StartsWith("-"))
                //    tbCalc.Text = Calculator.Calc(-Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();
                //else
                //    tbCalc.Text = Calculator.Calc(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();

            }

        }

        public async Task<int> CalcAsync(int a1, int a2, char op)
        {
			int res = 0;
			try
			{
				var request = "http://localhost:8090/?num1=" + a1 + "&num2=" + a2 + "&op=" + op;
				using (HttpClient client = new HttpClient())
				{
					using (HttpResponseMessage response = await client.GetAsync(request))
					{
						using (HttpContent content = response.Content)
						{
							string result = await content.ReadAsStringAsync();
							if (result != null && result.Length >= 50)
							{
								Console.WriteLine(result.Substring(0, 50) + "...");
							}
						}
					}
				}
			}
			catch
			{
				tbCalc.Text += "connection failed";
			}
			return 213;
        }



    }
}
