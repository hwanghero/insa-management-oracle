namespace insa_project
{
    partial class ipr_main
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
            this.main = new System.Windows.Forms.Panel();
            this.side = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AutoSize = true;
            this.main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main.Location = new System.Drawing.Point(-1, 0);
            this.main.Margin = new System.Windows.Forms.Padding(4);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1318, 712);
            this.main.TabIndex = 0;
            // 
            // side
            // 
            this.side.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.side.Location = new System.Drawing.Point(1319, 0);
            this.side.Margin = new System.Windows.Forms.Padding(4);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(326, 708);
            this.side.TabIndex = 1;
            // 
            // ipr_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1644, 709);
            this.Controls.Add(this.side);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ipr_main";
            this.Text = "ipr_main";
            this.Load += new System.EventHandler(this.ipr_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel side;
    }
}