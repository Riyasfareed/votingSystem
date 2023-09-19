namespace Dashboard
{
    partial class CandidateProfile
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
            this.positiontxt = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // positiontxt
            // 
            this.positiontxt.Location = new System.Drawing.Point(173, 275);
            this.positiontxt.Name = "positiontxt";
            this.positiontxt.Size = new System.Drawing.Size(100, 22);
            this.positiontxt.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(52, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(52, 281);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(55, 16);
            this.position.TabIndex = 5;
            this.position.Text = "Position";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(173, 88);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 8;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // CandidateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.position);
            this.Controls.Add(this.name);
            this.Controls.Add(this.positiontxt);
            this.Name = "CandidateProfile";
            this.Text = "CandidateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox positiontxt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.TextBox nametxt;
    }
}