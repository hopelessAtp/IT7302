namespace TextBoxControl
{
    partial class Form4
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
            this.checkedListBoxPossibleValues = new System.Windows.Forms.CheckedListBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxPossibleValues
            // 
            this.checkedListBoxPossibleValues.FormattingEnabled = true;
            this.checkedListBoxPossibleValues.Items.AddRange(new object[] {
            "one ",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten"});
            this.checkedListBoxPossibleValues.Location = new System.Drawing.Point(29, 35);
            this.checkedListBoxPossibleValues.Name = "checkedListBoxPossibleValues";
            this.checkedListBoxPossibleValues.Size = new System.Drawing.Size(120, 228);
            this.checkedListBoxPossibleValues.TabIndex = 0;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(201, 126);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 12;
            this.listBoxSelected.Location = new System.Drawing.Point(312, 35);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(131, 232);
            this.listBoxSelected.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 404);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.checkedListBoxPossibleValues);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPossibleValues;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.ListBox listBoxSelected;
    }
}