
namespace SortGarbage
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.ButtonScores = new System.Windows.Forms.Button();
            this.ButtonEndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(268, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(278, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Sortowanie smieci";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.Location = new System.Drawing.Point(325, 94);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(151, 72);
            this.ButtonStartGame.TabIndex = 1;
            this.ButtonStartGame.Text = "Rozpocznij Gre";
            this.ButtonStartGame.UseVisualStyleBackColor = true;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // ButtonScores
            // 
            this.ButtonScores.Location = new System.Drawing.Point(325, 189);
            this.ButtonScores.Name = "ButtonScores";
            this.ButtonScores.Size = new System.Drawing.Size(151, 73);
            this.ButtonScores.TabIndex = 2;
            this.ButtonScores.Text = "Historia wynikow";
            this.ButtonScores.UseVisualStyleBackColor = true;
            this.ButtonScores.Click += new System.EventHandler(this.ButtonScores_Click);
            // 
            // ButtonEndGame
            // 
            this.ButtonEndGame.Location = new System.Drawing.Point(325, 290);
            this.ButtonEndGame.Name = "ButtonEndGame";
            this.ButtonEndGame.Size = new System.Drawing.Size(151, 73);
            this.ButtonEndGame.TabIndex = 3;
            this.ButtonEndGame.Text = "Zakoncz gre";
            this.ButtonEndGame.UseVisualStyleBackColor = true;
            this.ButtonEndGame.Click += new System.EventHandler(this.ButtonEndGame_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonEndGame);
            this.Controls.Add(this.ButtonScores);
            this.Controls.Add(this.ButtonStartGame);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Main";
            this.Text = "Sortowanie smieci";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ButtonScores;
        private System.Windows.Forms.Button ButtonEndGame;
    }
}

