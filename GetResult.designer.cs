namespace Dashboard
{
    partial class GetResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetResult));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.lb_VotingResult = new System.Windows.Forms.Label();
            this.btn_President = new System.Windows.Forms.Button();
            this.btn_Secretary = new System.Windows.Forms.Button();
            this.btn_Committee = new System.Windows.Forms.Button();
            this.btn_winners = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_winSecretary = new System.Windows.Forms.Button();
            this.btn_winCommittee = new System.Windows.Forms.Button();
            this.lb_output2 = new System.Windows.Forms.Label();
            this.lb_output3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 978);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(303, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 622);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 622);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 356);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-4, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 9);
            this.label2.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1857, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 38);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lb_VotingResult
            // 
            this.lb_VotingResult.AutoSize = true;
            this.lb_VotingResult.BackColor = System.Drawing.Color.Transparent;
            this.lb_VotingResult.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VotingResult.Location = new System.Drawing.Point(614, 14);
            this.lb_VotingResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_VotingResult.Name = "lb_VotingResult";
            this.lb_VotingResult.Size = new System.Drawing.Size(433, 63);
            this.lb_VotingResult.TabIndex = 2;
            this.lb_VotingResult.Text = "VOTING RESULT";
            this.lb_VotingResult.Click += new System.EventHandler(this.lb_VotingResult_Click);
            // 
            // btn_President
            // 
            this.btn_President.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_President.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_President.Location = new System.Drawing.Point(472, 130);
            this.btn_President.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_President.Name = "btn_President";
            this.btn_President.Size = new System.Drawing.Size(230, 60);
            this.btn_President.TabIndex = 3;
            this.btn_President.Text = "PRESIDENT";
            this.btn_President.UseVisualStyleBackColor = false;
            this.btn_President.Click += new System.EventHandler(this.btn_President_Click);
            // 
            // btn_Secretary
            // 
            this.btn_Secretary.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Secretary.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Secretary.Location = new System.Drawing.Point(957, 130);
            this.btn_Secretary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Secretary.Name = "btn_Secretary";
            this.btn_Secretary.Size = new System.Drawing.Size(230, 60);
            this.btn_Secretary.TabIndex = 4;
            this.btn_Secretary.Text = "SECREARY";
            this.btn_Secretary.UseVisualStyleBackColor = false;
            this.btn_Secretary.Click += new System.EventHandler(this.btn_Secretary_Click);
            // 
            // btn_Committee
            // 
            this.btn_Committee.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Committee.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Committee.Location = new System.Drawing.Point(1459, 130);
            this.btn_Committee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Committee.Name = "btn_Committee";
            this.btn_Committee.Size = new System.Drawing.Size(230, 60);
            this.btn_Committee.TabIndex = 5;
            this.btn_Committee.Text = "COMMITTEE";
            this.btn_Committee.UseVisualStyleBackColor = false;
            this.btn_Committee.Click += new System.EventHandler(this.btn_Committee_Click);
            // 
            // btn_winners
            // 
            this.btn_winners.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_winners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_winners.Location = new System.Drawing.Point(418, 827);
            this.btn_winners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_winners.Name = "btn_winners";
            this.btn_winners.Size = new System.Drawing.Size(230, 62);
            this.btn_winners.TabIndex = 6;
            this.btn_winners.Text = "Who is\r\nThe Presedent";
            this.btn_winners.UseVisualStyleBackColor = false;
            this.btn_winners.Click += new System.EventHandler(this.btn_winners_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.BackColor = System.Drawing.Color.Red;
            this.lb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_output.Location = new System.Drawing.Point(376, 678);
            this.lb_output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(0, 29);
            this.lb_output.TabIndex = 7;
            this.lb_output.Click += new System.EventHandler(this.lb_output_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DodgerBlue;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(707, 249);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number Of Votes";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(867, 474);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_winSecretary
            // 
            this.btn_winSecretary.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_winSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_winSecretary.Location = new System.Drawing.Point(918, 827);
            this.btn_winSecretary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_winSecretary.Name = "btn_winSecretary";
            this.btn_winSecretary.Size = new System.Drawing.Size(230, 62);
            this.btn_winSecretary.TabIndex = 9;
            this.btn_winSecretary.Text = "Who is\r\nThe Secretary";
            this.btn_winSecretary.UseVisualStyleBackColor = false;
            this.btn_winSecretary.Click += new System.EventHandler(this.btn_winSecretary_Click);
            // 
            // btn_winCommittee
            // 
            this.btn_winCommittee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_winCommittee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_winCommittee.Location = new System.Drawing.Point(1427, 827);
            this.btn_winCommittee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_winCommittee.Name = "btn_winCommittee";
            this.btn_winCommittee.Size = new System.Drawing.Size(230, 62);
            this.btn_winCommittee.TabIndex = 10;
            this.btn_winCommittee.Text = "Who is\r\nThe Committee";
            this.btn_winCommittee.UseVisualStyleBackColor = false;
            this.btn_winCommittee.Click += new System.EventHandler(this.btn_winCommittee_Click);
            // 
            // lb_output2
            // 
            this.lb_output2.AutoSize = true;
            this.lb_output2.BackColor = System.Drawing.Color.Red;
            this.lb_output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_output2.Location = new System.Drawing.Point(702, 678);
            this.lb_output2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_output2.Name = "lb_output2";
            this.lb_output2.Size = new System.Drawing.Size(0, 29);
            this.lb_output2.TabIndex = 11;
            // 
            // lb_output3
            // 
            this.lb_output3.AutoSize = true;
            this.lb_output3.BackColor = System.Drawing.Color.Red;
            this.lb_output3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_output3.Location = new System.Drawing.Point(1005, 678);
            this.lb_output3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_output3.Name = "lb_output3";
            this.lb_output3.Size = new System.Drawing.Size(0, 29);
            this.lb_output3.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(15, 903);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15);
            this.button5.Size = new System.Drawing.Size(288, 75);
            this.button5.TabIndex = 7;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(15, 581);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15);
            this.button4.Size = new System.Drawing.Size(288, 75);
            this.button4.TabIndex = 6;
            this.button4.Text = "Nominees";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 506);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15);
            this.button3.Size = new System.Drawing.Size(288, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "Result";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 431);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15);
            this.button2.Size = new System.Drawing.Size(288, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vote";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 356);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15);
            this.button1.Size = new System.Drawing.Size(288, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GetResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1911, 978);
            this.Controls.Add(this.lb_output3);
            this.Controls.Add(this.lb_output2);
            this.Controls.Add(this.btn_winCommittee);
            this.Controls.Add(this.btn_winSecretary);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_winners);
            this.Controls.Add(this.btn_Committee);
            this.Controls.Add(this.btn_Secretary);
            this.Controls.Add(this.btn_President);
            this.Controls.Add(this.lb_VotingResult);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GetResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_VotingResult;
        private System.Windows.Forms.Button btn_President;
        private System.Windows.Forms.Button btn_Secretary;
        private System.Windows.Forms.Button btn_Committee;
        private System.Windows.Forms.Button btn_winners;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_winSecretary;
        private System.Windows.Forms.Button btn_winCommittee;
        private System.Windows.Forms.Label lb_output2;
        private System.Windows.Forms.Label lb_output3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

