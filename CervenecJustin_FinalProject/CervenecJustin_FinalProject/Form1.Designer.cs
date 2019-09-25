namespace CervenecJustin_FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInfo = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(96, 742);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(202, 31);
            this.textInfo.TabIndex = 1;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(75, 812);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(145, 75);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random Math Facts";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(78, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(520, 329);
            this.listBox1.TabIndex = 3;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(140, 678);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 31);
            this.textNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.textInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textNumber;
    }
}

