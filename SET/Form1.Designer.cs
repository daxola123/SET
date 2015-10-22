namespace SET
{
    partial class Form1
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
            this.pressMeButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pressMeButton
            // 
            this.pressMeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pressMeButton.Location = new System.Drawing.Point(620, 355);
            this.pressMeButton.Name = "pressMeButton";
            this.pressMeButton.Size = new System.Drawing.Size(75, 23);
            this.pressMeButton.TabIndex = 0;
            this.pressMeButton.Text = "Press Me";
            this.pressMeButton.UseVisualStyleBackColor = true;
            this.pressMeButton.Click += new System.EventHandler(this.pressMeButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(22, 13);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(646, 319);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 390);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.pressMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pressMeButton;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

