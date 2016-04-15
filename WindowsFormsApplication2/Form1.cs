using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OriginVal = 0;
        private double CurrentVal = 0;


        private void btnOrgin_Click(object sender, EventArgs e)
        {
            CurrentVal = OriginVal = double.Parse(txtOrigin.Text);

            lblTotal.Text = "初始值：" + OriginVal + "\r\n";
            lblDetail.Text = "初始值：" + CurrentVal + "\r\n";
        }

        private void btnGongZi_Click(object sender, EventArgs e)
        {
            var p1 = double.Parse(txt1.Text);
            var f = 4630.1 + 200 - p1;

            double v = Math.Round((8721.40 + f * 2 - 0.13), 2);
            txt2.Text = v.ToString();

            display(v);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var v = double.Parse(txtInput.Text);
            
            display(v);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            var v = double.Parse(txtOutput.Text)*(-1);
            
            display(v);
        }
        private void display(double addVal)
        {
            CurrentVal += addVal;
            lblTotal.Text = CurrentVal.ToString();
            lblDetail.Text += string.Format("{0}{1}元，余额{2}\r\n", addVal > 0 ? "收入" : "支出", Math.Abs(addVal), CurrentVal);
        }
    }
}
