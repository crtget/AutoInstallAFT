﻿namespace AutoInstallAFT
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.setini = new System.Windows.Forms.Button();
            this.subnetBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iplistBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(13, 13);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(71, 12);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "服务器地址:";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(15, 29);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(347, 21);
            this.serverBox.TabIndex = 1;
            this.serverBox.Leave += new System.EventHandler(this.serverBox_Leave);
            // 
            // setini
            // 
            this.setini.Location = new System.Drawing.Point(15, 184);
            this.setini.Name = "setini";
            this.setini.Size = new System.Drawing.Size(75, 23);
            this.setini.TabIndex = 3;
            this.setini.Text = "设置";
            this.setini.UseVisualStyleBackColor = true;
            this.setini.Click += new System.EventHandler(this.Setini_Click);
            // 
            // subnetBox
            // 
            this.subnetBox.Location = new System.Drawing.Point(15, 112);
            this.subnetBox.Name = "subnetBox";
            this.subnetBox.Size = new System.Drawing.Size(347, 21);
            this.subnetBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "本机IP地址:";
            // 
            // iplistBox
            // 
            this.iplistBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iplistBox.FormattingEnabled = true;
            this.iplistBox.Location = new System.Drawing.Point(15, 74);
            this.iplistBox.Name = "iplistBox";
            this.iplistBox.Size = new System.Drawing.Size(347, 20);
            this.iplistBox.TabIndex = 5;
            this.iplistBox.SelectedIndexChanged += new System.EventHandler(this.iplistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP地址选择:";
            // 
            // FastSegaTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iplistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subnetBox);
            this.Controls.Add(this.setini);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.serverLabel);
            this.MaximizeBox = false;
            this.Name = "FastSegaTools";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastSegaTools";
            this.Load += new System.EventHandler(this.FastSegaTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Button setini;
        private System.Windows.Forms.TextBox subnetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox iplistBox;
        private System.Windows.Forms.Label label1;
    }
}