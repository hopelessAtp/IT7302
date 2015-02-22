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
    public partial class CheckedListBoxTest : Form
    {
        public CheckedListBoxTest()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
            {
                checkedListBoxItem.Items.Add("Student" + i.ToString());//这里要改
            }
        }

        private void checkedListBoxItem_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBoxItem.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
                listBoxDisplay.Items.Add(item);
            else
                listBoxDisplay.Items.Remove(item);
        }
    }
}
