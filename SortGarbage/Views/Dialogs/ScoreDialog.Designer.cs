namespace SortGarbage.Views.Dialogs
{
    partial class ScoreDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreDialog));
            this.button1 = new System.Windows.Forms.Button();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.totalMovesLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(26, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalScoreLabel.Location = new System.Drawing.Point(106, 95);
            this.totalScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(109, 40);
            this.totalScoreLabel.TabIndex = 1;
            this.totalScoreLabel.Text = "Wynik: ";
            // 
            // totalMovesLabel
            // 
            this.totalMovesLabel.AutoSize = true;
            this.totalMovesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalMovesLabel.Location = new System.Drawing.Point(106, 152);
            this.totalMovesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalMovesLabel.Name = "totalMovesLabel";
            this.totalMovesLabel.Size = new System.Drawing.Size(99, 40);
            this.totalMovesLabel.TabIndex = 2;
            this.totalMovesLabel.Text = "Ruchy:";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTimeLabel.Location = new System.Drawing.Point(107, 205);
            this.totalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(81, 40);
            this.totalTimeLabel.TabIndex = 3;
            this.totalTimeLabel.Text = "Czas:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(263, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 108);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nie zapisuj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "{{UserName}} gratulacje!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.totalMovesLabel);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreDialog";
            this.Text = "ScoreDialog";
            this.Load += new System.EventHandler(this.ScoreDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label totalMovesLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}