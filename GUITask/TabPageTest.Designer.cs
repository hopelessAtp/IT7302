namespace GUITask
{
    partial class TabPageTest
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageColor = new System.Windows.Forms.TabPage();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.tabPageSize = new System.Windows.Forms.TabPage();
            this.radioButtonSize20 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize16 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize12 = new System.Windows.Forms.RadioButton();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.radioButtonGoodbye = new System.Windows.Forms.RadioButton();
            this.radioButtonHello = new System.Windows.Forms.RadioButton();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageColor.SuspendLayout();
            this.tabPageSize.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageColor);
            this.tabControl.Controls.Add(this.tabPageSize);
            this.tabControl.Controls.Add(this.tabPageMessage);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 333);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageColor
            // 
            this.tabPageColor.Controls.Add(this.radioButtonGreen);
            this.tabPageColor.Controls.Add(this.radioButtonRed);
            this.tabPageColor.Controls.Add(this.radioButtonBlack);
            this.tabPageColor.Location = new System.Drawing.Point(4, 25);
            this.tabPageColor.Name = "tabPageColor";
            this.tabPageColor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageColor.Size = new System.Drawing.Size(513, 304);
            this.tabPageColor.TabIndex = 0;
            this.tabPageColor.Text = "Color";
            this.tabPageColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(14, 131);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(68, 19);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(14, 85);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(52, 19);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(14, 45);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(68, 19);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
            // 
            // tabPageSize
            // 
            this.tabPageSize.Controls.Add(this.radioButtonSize20);
            this.tabPageSize.Controls.Add(this.radioButtonSize16);
            this.tabPageSize.Controls.Add(this.radioButtonSize12);
            this.tabPageSize.Location = new System.Drawing.Point(4, 25);
            this.tabPageSize.Name = "tabPageSize";
            this.tabPageSize.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSize.Size = new System.Drawing.Size(417, 189);
            this.tabPageSize.TabIndex = 1;
            this.tabPageSize.Text = "Size";
            this.tabPageSize.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize20
            // 
            this.radioButtonSize20.AutoSize = true;
            this.radioButtonSize20.Location = new System.Drawing.Point(14, 139);
            this.radioButtonSize20.Name = "radioButtonSize20";
            this.radioButtonSize20.Size = new System.Drawing.Size(92, 19);
            this.radioButtonSize20.TabIndex = 2;
            this.radioButtonSize20.TabStop = true;
            this.radioButtonSize20.Text = "20 point";
            this.radioButtonSize20.UseVisualStyleBackColor = true;
            this.radioButtonSize20.CheckedChanged += new System.EventHandler(this.radioButtonSize20_CheckedChanged);
            // 
            // radioButtonSize16
            // 
            this.radioButtonSize16.AutoSize = true;
            this.radioButtonSize16.Location = new System.Drawing.Point(14, 89);
            this.radioButtonSize16.Name = "radioButtonSize16";
            this.radioButtonSize16.Size = new System.Drawing.Size(92, 19);
            this.radioButtonSize16.TabIndex = 1;
            this.radioButtonSize16.TabStop = true;
            this.radioButtonSize16.Text = "16 point";
            this.radioButtonSize16.UseVisualStyleBackColor = true;
            this.radioButtonSize16.CheckedChanged += new System.EventHandler(this.radioButtonSize16_CheckedChanged);
            // 
            // radioButtonSize12
            // 
            this.radioButtonSize12.AutoSize = true;
            this.radioButtonSize12.Location = new System.Drawing.Point(14, 43);
            this.radioButtonSize12.Name = "radioButtonSize12";
            this.radioButtonSize12.Size = new System.Drawing.Size(92, 19);
            this.radioButtonSize12.TabIndex = 0;
            this.radioButtonSize12.TabStop = true;
            this.radioButtonSize12.Text = "12 point";
            this.radioButtonSize12.UseVisualStyleBackColor = true;
            this.radioButtonSize12.CheckedChanged += new System.EventHandler(this.radioButtonSize12_CheckedChanged);
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.radioButtonGoodbye);
            this.tabPageMessage.Controls.Add(this.radioButtonHello);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 25);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessage.Size = new System.Drawing.Size(417, 189);
            this.tabPageMessage.TabIndex = 2;
            this.tabPageMessage.Text = "Message";
            this.tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // radioButtonGoodbye
            // 
            this.radioButtonGoodbye.AutoSize = true;
            this.radioButtonGoodbye.Location = new System.Drawing.Point(14, 113);
            this.radioButtonGoodbye.Name = "radioButtonGoodbye";
            this.radioButtonGoodbye.Size = new System.Drawing.Size(92, 19);
            this.radioButtonGoodbye.TabIndex = 1;
            this.radioButtonGoodbye.TabStop = true;
            this.radioButtonGoodbye.Text = "Goodbye!";
            this.radioButtonGoodbye.UseVisualStyleBackColor = true;
            this.radioButtonGoodbye.CheckedChanged += new System.EventHandler(this.radioButtonGoodbye_CheckedChanged);
            // 
            // radioButtonHello
            // 
            this.radioButtonHello.AutoSize = true;
            this.radioButtonHello.Location = new System.Drawing.Point(14, 63);
            this.radioButtonHello.Name = "radioButtonHello";
            this.radioButtonHello.Size = new System.Drawing.Size(76, 19);
            this.radioButtonHello.TabIndex = 0;
            this.radioButtonHello.TabStop = true;
            this.radioButtonHello.Text = "Hello!";
            this.radioButtonHello.UseVisualStyleBackColor = true;
            this.radioButtonHello.CheckedChanged += new System.EventHandler(this.radioButtonHello_CheckedChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelAbout);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(417, 189);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(6, 44);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(0, 15);
            this.labelAbout.TabIndex = 0;
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(154, 269);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(0, 15);
            this.labelDisplay.TabIndex = 1;
            // 
            // TabPageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 357);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.tabControl);
            this.Name = "TabPageTest";
            this.Text = "TabPage Test";
            this.tabControl.ResumeLayout(false);
            this.tabPageColor.ResumeLayout(false);
            this.tabPageColor.PerformLayout();
            this.tabPageSize.ResumeLayout(false);
            this.tabPageSize.PerformLayout();
            this.tabPageMessage.ResumeLayout(false);
            this.tabPageMessage.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageColor;
        private System.Windows.Forms.TabPage tabPageSize;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonSize20;
        private System.Windows.Forms.RadioButton radioButtonSize16;
        private System.Windows.Forms.RadioButton radioButtonSize12;
        private System.Windows.Forms.RadioButton radioButtonGoodbye;
        private System.Windows.Forms.RadioButton radioButtonHello;
        private System.Windows.Forms.Label labelAbout;
    }
}