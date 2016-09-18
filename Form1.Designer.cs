namespace Simon
{
    partial class Simon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simon));
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.roundNumberText = new System.Windows.Forms.Label();
            this.RoundNumberSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Salmon;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Red.Location = new System.Drawing.Point(20, 18);
            this.Red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(303, 251);
            this.Red.TabIndex = 0;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.SkyBlue;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Blue.Location = new System.Drawing.Point(333, 18);
            this.Blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(303, 251);
            this.Blue.TabIndex = 1;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.SpringGreen;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Green.Location = new System.Drawing.Point(20, 278);
            this.Green.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(303, 251);
            this.Green.TabIndex = 2;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Moccasin;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yellow.Location = new System.Drawing.Point(333, 278);
            this.Yellow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(303, 251);
            this.Yellow.TabIndex = 3;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(513, 583);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(124, 35);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // roundNumberText
            // 
            this.roundNumberText.AutoSize = true;
            this.roundNumberText.Location = new System.Drawing.Point(12, 583);
            this.roundNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundNumberText.Name = "roundNumberText";
            this.roundNumberText.Size = new System.Drawing.Size(67, 20);
            this.roundNumberText.TabIndex = 5;
            this.roundNumberText.Text = "Round:";
            // 
            // RoundNumberSet
            // 
            this.RoundNumberSet.AutoSize = true;
            this.RoundNumberSet.Location = new System.Drawing.Point(12, 608);
            this.RoundNumberSet.Name = "RoundNumberSet";
            this.RoundNumberSet.Size = new System.Drawing.Size(19, 20);
            this.RoundNumberSet.TabIndex = 6;
            this.RoundNumberSet.Text = "0";
            // 
            // Simon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 636);
            this.Controls.Add(this.RoundNumberSet);
            this.Controls.Add(this.roundNumberText);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 675);
            this.MinimumSize = new System.Drawing.Size(675, 675);
            this.Name = "Simon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.Simon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label roundNumberText;
        private System.Windows.Forms.Label RoundNumberSet;
    }
}

