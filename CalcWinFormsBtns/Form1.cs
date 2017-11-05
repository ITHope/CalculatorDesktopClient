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
        HttpClient client;
        Thread thread;
        string ip;

        public FormCalcBtns()
        {
            client = new HttpClient();
            thread = new Thread(GetAnswer);
            ip = "http://localhost:8080/";
            if (thread.IsAlive == false)
                thread.Start();

            InitializeComponent();
        }

        private async void GetAnswer()
        {
            while (true)
            {
                try
                {
                    string response = await client.GetStringAsync(ip + "?check=true");
                    string[] param = response.Split('=');
                    if (param[0] == "res")
                        tbCalc.Text = param[1];
                    else
                        tbCalc.Text = param[0];
                }
                catch (Exception e)
                {
                    tbCalc.Text = e.ToString();
                }
                Thread.Sleep(500);
            }
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
                    tbCalc.Text = CalcAsync(-Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();
                else
                    tbCalc.Text = CalcAsync(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();


                //if (formula.StartsWith("-"))
                //    tbCalc.Text = Calculator.Calc(-Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();
                //else
                //    tbCalc.Text = Calculator.Calc(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();

            }

        }

        public async void CalcAsync(int a1, int a2, char op)
        {
            try
            {
                var response = await client.PostAsync(ip, new StringContent("num1=" + a1 + "&num2=" + a2 + "op=" + op));
                string content = await response.Content.ReadAsStringAsync();
                if (content == "received")
                    tbCalc.Text = "received";
            }
            catch
            {
                tbCalc.Text += "connection failed";
            }
        }



    }
}
