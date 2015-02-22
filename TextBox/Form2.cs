using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name =your name\r\n";
            output += "Address =your address\r\n";
            output += "Occupation =Only `Programmer` allowed \r\n";
            output += "Age =your age\r\n";
            this.textBoxOutput.Text = output;



        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name:" + textBoxName.Text + "\r\n";
            output += "Address:" + textBoxAddress.Text + "\r\n";
            output += "Occupation:" + textBoxOccupation.Text + "\r\n";
            output += "Age:" + textBoxAge.Text + "\r\n";

            textBoxOutput.Text = output;


        }

        private void txtBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void ValidateOk()
        {
            this.buttonOK.Enabled = (textBoxName.BackColor != Color.Red
                && textBoxAddress.BackColor != Color.Red
                && textBoxOccupation.BackColor != Color.Red
                && textBoxAge.BackColor != Color.Red);
        }

        private void textBoxOccupation_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "Programmer" || tb.Text.Length == 0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else 
            {
                tb.BackColor = Color.Red;
            }
            ValidateOk();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
