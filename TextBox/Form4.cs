﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (checkedListBoxPossibleValues.CheckedItems.Count > 0)
            {
                listBoxSelected.Items.Clear();

                foreach (string item in checkedListBoxPossibleValues.CheckedItems)
                {
                    listBoxSelected.Items.Add(item.ToString());
                }
            }
            for (int i = 0; i < checkedListBoxPossibleValues.Items.Count; i++)
                checkedListBoxPossibleValues.SetItemChecked(i, false);
        }
    }
}
