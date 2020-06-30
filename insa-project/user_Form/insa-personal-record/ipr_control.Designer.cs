namespace insa_project
{
    partial class ipr_control
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ipr_control));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.insert_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_button
            // 
            this.insert_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert_button.BackgroundImage")));
            this.insert_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insert_button.Location = new System.Drawing.Point(18, 10);
            this.insert_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(38, 36);
            this.insert_button.TabIndex = 6;
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click_1);
            this.insert_button.MouseHover += new System.EventHandler(this.insert_button_MouseHover);
            // 
            // update_button
            // 
            this.update_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_button.BackgroundImage")));
            this.update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_button.Location = new System.Drawing.Point(62, 10);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(39, 36);
            this.update_button.TabIndex = 6;
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            this.update_button.MouseHover += new System.EventHandler(this.insert_button_MouseHover);
            // 
            // delete_button
            // 
            this.delete_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button.BackgroundImage")));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.Location = new System.Drawing.Point(107, 10);
            this.delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(39, 36);
            this.delete_button.TabIndex = 6;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            this.delete_button.MouseHover += new System.EventHandler(this.insert_button_MouseHover);
            // 
            // apply_button
            // 
            this.apply_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apply_button.BackgroundImage")));
            this.apply_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apply_button.Location = new System.Drawing.Point(152, 10);
            this.apply_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(39, 36);
            this.apply_button.TabIndex = 7;
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            this.apply_button.MouseHover += new System.EventHandler(this.insert_button_MouseHover);
            // 
            // cancel_button
            // 
            this.cancel_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_button.BackgroundImage")));
            this.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel_button.Location = new System.Drawing.Point(197, 10);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(39, 36);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            this.cancel_button.MouseHover += new System.EventHandler(this.insert_button_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "인사기본사항",
            "가족사항",
            "학력사항",
            "상벌사항",
            "경력사항",
            "자격면허",
            "외국어"});
            this.comboBox1.Location = new System.Drawing.Point(14, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "선택사원 유지 후 바로가기";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F);
            this.groupBox1.Location = new System.Drawing.Point(253, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 38);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // ipr_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 55);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ipr_control";
            this.Text = "Contorl";
            this.Load += new System.EventHandler(this.Contorl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}