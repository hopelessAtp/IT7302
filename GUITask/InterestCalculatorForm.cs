using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITask
{
    public partial class InterestCalculatorForm : Form
    {
        public InterestCalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal principal;
            double rate;
            int year;
            decimal amount;
            string output;

            principal = Convert.ToDecimal(textBoxPrincipal.Text);
            rate = Convert.ToDouble(textBoxInterest.Text);
            year = Convert.ToInt32(numericUpDownYears.Value);
            output = "Year\tAmount on Deposit\r\n";

            for (int i = 1; i <= year; i++)
            {
                amount = principal * ((decimal)Math.Pow((1 + rate / 100), i));
                output += (i + "\t" + string.Format("{0:C}", amount) + "\r\n");
            }
            textBoxDisplay.Text = output;
        }
    }
}
