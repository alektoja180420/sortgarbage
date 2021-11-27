
namespace SortGarbage.Views
{
    partial class GameView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaperButton = new System.Windows.Forms.Button();
            this.GlassButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PaperContainerPictureBox = new System.Windows.Forms.PictureBox();
            this.GlassContainerPictureBox = new System.Windows.Forms.PictureBox();
            this.BioContainerPictureBox = new System.Windows.Forms.PictureBox();
            this.PlasticContainerPictureBox = new System.Windows.Forms.PictureBox();
            this.SettingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperContainerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassContainerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BioContainerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlasticContainerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.SettingsPanel.Controls.Add(this.TimerLabel);
            this.SettingsPanel.Controls.Add(this.EndGameButton);
            this.SettingsPanel.Location = new System.Drawing.Point(13, 2);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(775, 32);
            this.SettingsPanel.TabIndex = 0;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerLabel.Location = new System.Drawing.Point(20, 4);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(64, 25);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "mm:ss";
            // 
            // EndGameButton
            // 
            this.EndGameButton.Location = new System.Drawing.Point(631, 4);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(141, 23);
            this.EndGameButton.TabIndex = 0;
            this.EndGameButton.Text = "Zakoncz gre";
            this.EndGameButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PaperButton);
            this.panel1.Controls.Add(this.GlassButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PaperContainerPictureBox);
            this.panel1.Controls.Add(this.GlassContainerPictureBox);
            this.panel1.Controls.Add(this.BioContainerPictureBox);
            this.panel1.Controls.Add(this.PlasticContainerPictureBox);
            this.panel1.Location = new System.Drawing.Point(13, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 397);
            this.panel1.TabIndex = 1;
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(480, 151);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 7;
            this.PaperButton.Text = "Papier";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // GlassButton
            // 
            this.GlassButton.Location = new System.Drawing.Point(480, 97);
            this.GlassButton.Name = "GlassButton";
            this.GlassButton.Size = new System.Drawing.Size(75, 23);
            this.GlassButton.TabIndex = 6;
            this.GlassButton.Text = "Szkło";
            this.GlassButton.UseVisualStyleBackColor = true;
            this.GlassButton.Click += new System.EventHandler(this.GlassButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Plastik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaperContainerPictureBox
            // 
            this.PaperContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PaperContainerPictureBox.Image")));
            this.PaperContainerPictureBox.Location = new System.Drawing.Point(666, 239);
            this.PaperContainerPictureBox.Name = "PaperContainerPictureBox";
            this.PaperContainerPictureBox.Size = new System.Drawing.Size(106, 158);
            this.PaperContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaperContainerPictureBox.TabIndex = 3;
            this.PaperContainerPictureBox.TabStop = false;
            // 
            // GlassContainerPictureBox
            // 
            this.GlassContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GlassContainerPictureBox.Image")));
            this.GlassContainerPictureBox.Location = new System.Drawing.Point(666, 3);
            this.GlassContainerPictureBox.Name = "GlassContainerPictureBox";
            this.GlassContainerPictureBox.Size = new System.Drawing.Size(106, 137);
            this.GlassContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlassContainerPictureBox.TabIndex = 2;
            this.GlassContainerPictureBox.TabStop = false;
            // 
            // BioContainerPictureBox
            // 
            this.BioContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BioContainerPictureBox.Image")));
            this.BioContainerPictureBox.Location = new System.Drawing.Point(0, 239);
            this.BioContainerPictureBox.Name = "BioContainerPictureBox";
            this.BioContainerPictureBox.Size = new System.Drawing.Size(130, 155);
            this.BioContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BioContainerPictureBox.TabIndex = 1;
            this.BioContainerPictureBox.TabStop = false;
            // 
            // PlasticContainerPictureBox
            // 
            this.PlasticContainerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlasticContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlasticContainerPictureBox.Image")));
            this.PlasticContainerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PlasticContainerPictureBox.Name = "PlasticContainerPictureBox";
            this.PlasticContainerPictureBox.Size = new System.Drawing.Size(775, 397);
            this.PlasticContainerPictureBox.TabIndex = 0;
            this.PlasticContainerPictureBox.TabStop = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "GameView";
            this.Text = "GameView";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaperContainerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassContainerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BioContainerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlasticContainerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PaperContainerPictureBox;
        private System.Windows.Forms.PictureBox GlassContainerPictureBox;
        private System.Windows.Forms.PictureBox BioContainerPictureBox;
        private System.Windows.Forms.PictureBox PlasticContainerPictureBox;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button GlassButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}