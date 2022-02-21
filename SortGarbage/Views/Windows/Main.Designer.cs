
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.ButtonScores = new System.Windows.Forms.Button();
            this.ButtonEndGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.Location = new System.Drawing.Point(464, 157);
            this.ButtonStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(216, 120);
            this.ButtonStartGame.TabIndex = 1;
            this.ButtonStartGame.Text = "Rozpocznij gre";
            this.ButtonStartGame.UseVisualStyleBackColor = true;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // ButtonScores
            // 
            this.ButtonScores.Location = new System.Drawing.Point(464, 315);
            this.ButtonScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonScores.Name = "ButtonScores";
            this.ButtonScores.Size = new System.Drawing.Size(216, 122);
            this.ButtonScores.TabIndex = 2;
            this.ButtonScores.Text = "Historia wyników";
            this.ButtonScores.UseVisualStyleBackColor = true;
            this.ButtonScores.Click += new System.EventHandler(this.ButtonScores_Click);
            // 
            // ButtonEndGame
            // 
            this.ButtonEndGame.Location = new System.Drawing.Point(464, 483);
            this.ButtonEndGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEndGame.Name = "ButtonEndGame";
            this.ButtonEndGame.Size = new System.Drawing.Size(216, 122);
            this.ButtonEndGame.TabIndex = 3;
            this.ButtonEndGame.Text = "Zakończ gre";
            this.ButtonEndGame.UseVisualStyleBackColor = true;
            this.ButtonEndGame.Click += new System.EventHandler(this.ButtonEndGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(373, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonEndGame);
            this.Controls.Add(this.ButtonScores);
            this.Controls.Add(this.ButtonStartGame);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Sortowanie smieci";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ButtonScores;
        private System.Windows.Forms.Button ButtonEndGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

