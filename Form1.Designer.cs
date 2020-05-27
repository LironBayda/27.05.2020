namespace remmberTheNumbers
{
    partial class RemmberTheNumbersForm
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.highScore = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(161, 50);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(51, 20);
            this.num1.TabIndex = 0;
            this.num1.Text = "label1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(266, 50);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(51, 20);
            this.num2.TabIndex = 1;
            this.num2.Text = "label2";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.Location = new System.Drawing.Point(376, 50);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(51, 20);
            this.num3.TabIndex = 2;
            this.num3.Text = "label3";
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.Location = new System.Drawing.Point(475, 50);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(51, 20);
            this.num4.TabIndex = 3;
            this.num4.Text = "label4";
            // 
            // num5
            // 
            this.num5.AutoSize = true;
            this.num5.Location = new System.Drawing.Point(578, 50);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(51, 20);
            this.num5.TabIndex = 4;
            this.num5.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.ListBoxTextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.ListBoxTextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(346, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.ListBoxTextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(452, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.ListBoxTextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(558, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.ListBoxTextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(292, 138);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 34);
            this.start.TabIndex = 10;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(380, 138);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 34);
            this.finish.TabIndex = 11;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.menuToolStripMenuItem.Text = "&Geme";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 20;
            this.scoreListBox.Location = new System.Drawing.Point(90, 228);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(590, 104);
            this.scoreListBox.TabIndex = 14;
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.highScore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.highScore.Location = new System.Drawing.Point(95, 189);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(126, 25);
            this.highScore.TabIndex = 15;
            this.highScore.Text = "High Score:";
            this.highScore.Click += new System.EventHandler(this.highScore_Click);
            // 
            // RemmberTheNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.scoreListBox);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "RemmberTheNumbersForm";
            this.Text = "Remmber The Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Label highScore;
    }
}

