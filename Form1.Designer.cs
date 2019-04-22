namespace Clicker_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_1_point = new System.Windows.Forms.Button();
            this.score_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_10_point = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.clicks_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.show_clicks_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.moveText_label = new System.Windows.Forms.Label();
            this.movingText_Timer = new System.Windows.Forms.Timer(this.components);
            this.changeText_timer = new System.Windows.Forms.Timer(this.components);
            this.enterACheatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetYourGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_1_point
            // 
            this.btn_1_point.BackColor = System.Drawing.Color.Black;
            this.btn_1_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_point.ForeColor = System.Drawing.Color.White;
            this.btn_1_point.Location = new System.Drawing.Point(16, 156);
            this.btn_1_point.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1_point.Name = "btn_1_point";
            this.btn_1_point.Size = new System.Drawing.Size(432, 28);
            this.btn_1_point.TabIndex = 0;
            this.btn_1_point.Text = "1";
            this.btn_1_point.UseVisualStyleBackColor = false;
            this.btn_1_point.Click += new System.EventHandler(this.btn_1_point_Click);
            // 
            // score_textBox
            // 
            this.score_textBox.BackColor = System.Drawing.Color.White;
            this.score_textBox.Enabled = false;
            this.score_textBox.ForeColor = System.Drawing.Color.White;
            this.score_textBox.Location = new System.Drawing.Point(110, 82);
            this.score_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.score_textBox.Name = "score_textBox";
            this.score_textBox.Size = new System.Drawing.Size(176, 22);
            this.score_textBox.TabIndex = 1;
            this.score_textBox.Text = "0";
            this.score_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE: ";
            // 
            // btn_10_point
            // 
            this.btn_10_point.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_10_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10_point.ForeColor = System.Drawing.Color.White;
            this.btn_10_point.Location = new System.Drawing.Point(16, 237);
            this.btn_10_point.Name = "btn_10_point";
            this.btn_10_point.Size = new System.Drawing.Size(86, 27);
            this.btn_10_point.TabIndex = 3;
            this.btn_10_point.Text = "10";
            this.btn_10_point.UseVisualStyleBackColor = false;
            this.btn_10_point.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unlock at 1000 points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unlock at 3000 points";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(16, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "50";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unlock at 8000 points";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(16, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "100";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Purchase?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Purchase?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Purchase?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Purchase?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Unlock at 500   points";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Clicks per sec: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unlock 1 at 250  points, Owned: ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(302, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "+ +";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clicks_label
            // 
            this.clicks_label.AutoSize = true;
            this.clicks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicks_label.Location = new System.Drawing.Point(263, 394);
            this.clicks_label.Name = "clicks_label";
            this.clicks_label.Size = new System.Drawing.Size(33, 18);
            this.clicks_label.TabIndex = 17;
            this.clicks_label.Text = "0 :(";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(298, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "CLICKS: ";
            // 
            // show_clicks_label
            // 
            this.show_clicks_label.AutoSize = true;
            this.show_clicks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.show_clicks_label.Location = new System.Drawing.Point(396, 82);
            this.show_clicks_label.Name = "show_clicks_label";
            this.show_clicks_label.Size = new System.Drawing.Size(21, 24);
            this.show_clicks_label.TabIndex = 20;
            this.show_clicks_label.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatsToolStripMenuItem,
            this.saveCurrentProgressToolStripMenuItem,
            this.resetYourGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.enterACheatToolStripMenuItem});
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cheatsToolStripMenuItem.Text = "Cheats";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_cheat);
            // 
            // moveText_label
            // 
            this.moveText_label.AutoSize = true;
            this.moveText_label.BackColor = System.Drawing.Color.Transparent;
            this.moveText_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveText_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveText_label.Location = new System.Drawing.Point(9, 35);
            this.moveText_label.Name = "moveText_label";
            this.moveText_label.Size = new System.Drawing.Size(103, 24);
            this.moveText_label.TabIndex = 22;
            this.moveText_label.Text = "Go Go Go";
            // 
            // movingText_Timer
            // 
            this.movingText_Timer.Enabled = true;
            this.movingText_Timer.Interval = 5;
            this.movingText_Timer.Tick += new System.EventHandler(this.movingText_Timer_Tick);
            // 
            // changeText_timer
            // 
            this.changeText_timer.Enabled = true;
            this.changeText_timer.Interval = 7000;
            this.changeText_timer.Tick += new System.EventHandler(this.changeText_timer_Tick);
            // 
            // enterACheatToolStripMenuItem
            // 
            this.enterACheatToolStripMenuItem.Name = "enterACheatToolStripMenuItem";
            this.enterACheatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterACheatToolStripMenuItem.Text = "Enter a cheat";
            // 
            // saveCurrentProgressToolStripMenuItem
            // 
            this.saveCurrentProgressToolStripMenuItem.Name = "saveCurrentProgressToolStripMenuItem";
            this.saveCurrentProgressToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.saveCurrentProgressToolStripMenuItem.Text = "Save current progress";
            // 
            // resetYourGameToolStripMenuItem
            // 
            this.resetYourGameToolStripMenuItem.Name = "resetYourGameToolStripMenuItem";
            this.resetYourGameToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.resetYourGameToolStripMenuItem.Text = "Reset your game";
            this.resetYourGameToolStripMenuItem.Click += new System.EventHandler(this.resetYourGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 464);
            this.Controls.Add(this.moveText_label);
            this.Controls.Add(this.show_clicks_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clicks_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_10_point);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_textBox);
            this.Controls.Add(this.btn_1_point);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Clicks n clicks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1_point;
        private System.Windows.Forms.TextBox score_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_10_point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label clicks_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label show_clicks_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label moveText_label;
        private System.Windows.Forms.Timer movingText_Timer;
        private System.Windows.Forms.Timer changeText_timer;
        private System.Windows.Forms.ToolStripMenuItem enterACheatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetYourGameToolStripMenuItem;
    }
}

