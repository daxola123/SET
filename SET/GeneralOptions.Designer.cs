namespace SET
{
    partial class GeneralOptions
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
            this.genOptionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genOptionsLabel
            // 
            this.genOptionsLabel.AutoSize = true;
            this.genOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.genOptionsLabel.Location = new System.Drawing.Point(50, 23);
            this.genOptionsLabel.Name = "genOptionsLabel";
            this.genOptionsLabel.Size = new System.Drawing.Size(250, 37);
            this.genOptionsLabel.TabIndex = 0;
            this.genOptionsLabel.Text = "General Options";
            // 
            // GeneralOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(348, 300);
            this.Controls.Add(this.genOptionsLabel);
            this.Name = "GeneralOptions";
            this.Text = "GeneralOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genOptionsLabel;
    }
}