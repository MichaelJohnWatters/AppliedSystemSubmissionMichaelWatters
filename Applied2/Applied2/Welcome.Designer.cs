namespace Applied2
{
    partial class Welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtWelcome = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtWelcome
            // 
            this.rtxtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtWelcome.Location = new System.Drawing.Point(0, 0);
            this.rtxtWelcome.Name = "rtxtWelcome";
            this.rtxtWelcome.ReadOnly = true;
            this.rtxtWelcome.Size = new System.Drawing.Size(557, 285);
            this.rtxtWelcome.TabIndex = 0;
            this.rtxtWelcome.Text = "Michael John Watters \n\nApplied Systems Submission\n\nWebsite: michaeljohnwatters.co" +
    ".uk\n\nEmail: mjwatters@outlook.com\n\nMobile: 07805704485";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxtWelcome);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(557, 285);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtWelcome;
    }
}
