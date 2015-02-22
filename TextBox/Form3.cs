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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name:" + textBoxName.Text + "\r\n";
            output += "Address:" + textBoxAddress.Text + "\r\n";
            output += "Occupation:" + (string)(checkBoxProgrammer.Checked?"Programmer":"Not a programmer")+ "\r\n";
            output += "Sex:" + (string)(radioButtonFemale.Checked ? "Famale" : "Male") + "\r\n";

            output += "Age:" + textBoxAge.Text + "\r\n";

            textBoxOutput.Text = output;


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOccupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
