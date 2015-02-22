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
    public partial class TabPageTest : Form
    {
        public TabPageTest()
        {
            InitializeComponent();
            labelAbout.Text = "Tabs are used to organize controls and\r\nconserve screen space";
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.ForeColor = Color.Black;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.ForeColor = Color.Red;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.ForeColor = Color.Green;
        }

        private void radioButtonSize12_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.Font = new Font(labelDisplay.Font.Name, 12);
        }

        private void radioButtonSize16_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.Font = new Font(labelDisplay.Font.Name, 16);
        }

        private void radioButtonSize20_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.Font = new Font(labelDisplay.Font.Name, 20);
        }

        private void radioButtonHello_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.Text = "Hello!";
        }

        private void radioButtonGoodbye_CheckedChanged(object sender, EventArgs e)
        {
            labelDisplay.Text = "Goodbye!";
        }
    }
}
