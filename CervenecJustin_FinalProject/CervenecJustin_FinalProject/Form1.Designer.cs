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
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRandomTrivia = new System.Windows.Forms.Button();
            this.btnRandomDate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.groupBoxTools.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(404, 762);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(166, 31);
            this.textInfo.TabIndex = 1;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(75, 680);
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
            this.listBox1.Location = new System.Drawing.Point(75, 298);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(520, 329);
            this.listBox1.TabIndex = 3;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(404, 680);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 31);
            this.textNumber.TabIndex = 4;
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.menuStrip2);
            this.groupBoxTools.Location = new System.Drawing.Point(75, 198);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(403, 94);
            this.groupBoxTools.TabIndex = 5;
            this.groupBoxTools.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Azure;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 27);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(397, 40);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRandomTrivia
            // 
            this.btnRandomTrivia.Location = new System.Drawing.Point(75, 781);
            this.btnRandomTrivia.Name = "btnRandomTrivia";
            this.btnRandomTrivia.Size = new System.Drawing.Size(145, 75);
            this.btnRandomTrivia.TabIndex = 7;
            this.btnRandomTrivia.Text = "Ramdom Trivia";
            this.btnRandomTrivia.UseVisualStyleBackColor = true;
            this.btnRandomTrivia.Click += new System.EventHandler(this.btnRandomTrivia_Click);
            // 
            // btnRandomDate
            // 
            this.btnRandomDate.Location = new System.Drawing.Point(75, 880);
            this.btnRandomDate.Name = "btnRandomDate";
            this.btnRandomDate.Size = new System.Drawing.Size(145, 75);
            this.btnRandomDate.TabIndex = 8;
            this.btnRandomDate.Text = "Random Date";
            this.btnRandomDate.UseVisualStyleBackColor = true;
            this.btnRandomDate.Click += new System.EventHandler(this.btnRandomDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(414, 852);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 75);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(75, 986);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(145, 75);
            this.btnYear.TabIndex = 10;
            this.btnYear.Text = "Random Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRandomDate);
            this.Controls.Add(this.btnRandomTrivia);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnRandomTrivia;
        private System.Windows.Forms.Button btnRandomDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnYear;
    }
}

