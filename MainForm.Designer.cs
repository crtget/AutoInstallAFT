namespace AutoInstallAFT
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectPath = new System.Windows.Forms.Button();
            this.unzip = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(13, 42);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(329, 21);
            this.pathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "安装目录(请选择根目录/盘符)";
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(348, 39);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(35, 23);
            this.selectPath.TabIndex = 2;
            this.selectPath.Text = "...";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // unzip
            // 
            this.unzip.Location = new System.Drawing.Point(13, 70);
            this.unzip.Name = "unzip";
            this.unzip.Size = new System.Drawing.Size(75, 23);
            this.unzip.TabIndex = 3;
            this.unzip.Text = "安装";
            this.unzip.UseVisualStyleBackColor = true;
            this.unzip.Click += new System.EventHandler(this.Unzip_Click);
            // 
            // logBox
            // 
            this.logBox.AllowDrop = true;
            this.logBox.Location = new System.Drawing.Point(12, 99);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(364, 93);
            this.logBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 204);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.unzip);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathBox);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Auto Install AFT 本程序免费，禁止售卖";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Button unzip;
        private System.Windows.Forms.TextBox logBox;
    }
}

