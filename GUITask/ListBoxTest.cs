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
    public partial class ListBoxTest : Form
    {
        public ListBoxTest()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Add(textBoxInput.Text);
            textBoxInput.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxDisplay.SelectedIndex != -1)
            {
                listBoxDisplay.Items.RemoveAt(listBoxDisplay.SelectedIndex);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
