namespace GUITask
{
    partial class CheckedListBoxTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxItem = new System.Windows.Forms.CheckedListBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxItem
            // 
            this.checkedListBoxItem.FormattingEnabled = true;
            this.checkedListBoxItem.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxItem.Name = "checkedListBoxItem";
            this.checkedListBoxItem.Size = new System.Drawing.Size(274, 404);
            this.checkedListBoxItem.TabIndex = 0;
            this.checkedListBoxItem.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxItem_ItemCheck);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 15;
            this.listBoxDisplay.Location = new System.Drawing.Point(431, 12);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(300, 409);
            this.listBoxDisplay.TabIndex = 1;
            // 
            // CheckedListBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.checkedListBoxItem);
            this.Name = "CheckedListBoxTest";
            this.Text = "CheckedListBox Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxItem;
        private System.Windows.Forms.ListBox listBoxDisplay;
    }
}