namespace AutoInstallAFT
{
    partial class FastSegaTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.setini = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址:";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(15, 29);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(347, 21);
            this.ipBox.TabIndex = 1;
            // 
            // setini
            // 
            this.setini.Location = new System.Drawing.Point(15, 84);
            this.setini.Name = "setini";
            this.setini.Size = new System.Drawing.Size(75, 23);
            this.setini.TabIndex = 2;
            this.setini.Text = "设置";
            this.setini.UseVisualStyleBackColor = true;
            this.setini.Click += new System.EventHandler(this.Setini_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(347, 21);
            this.textBox2.TabIndex = 3;
            // 
            // FastSegaTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 115);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.setini);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label1);
            this.Name = "FastSegaTools";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FastSegaTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button setini;
        private System.Windows.Forms.TextBox textBox2;
    }
}