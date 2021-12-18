
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
            this.movesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.garbageButton2 = new SortGarbage.Views.CustomControls.GarbageButton();
            this.garbageButton1 = new SortGarbage.Views.CustomControls.GarbageButton();
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
            this.SettingsPanel.Controls.Add(this.movesLabel);
            this.SettingsPanel.Controls.Add(this.scoreLabel);
            this.SettingsPanel.Controls.Add(this.userNameLabel);
            this.SettingsPanel.Controls.Add(this.TimerLabel);
            this.SettingsPanel.Controls.Add(this.EndGameButton);
            this.SettingsPanel.Location = new System.Drawing.Point(13, 2);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(775, 32);
            this.SettingsPanel.TabIndex = 0;
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movesLabel.Location = new System.Drawing.Point(485, 4);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(87, 25);
            this.movesLabel.TabIndex = 4;
            this.movesLabel.Text = "Ruchy: 0 ";
            this.movesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(338, 4);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(78, 25);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLabel.Location = new System.Drawing.Point(172, 4);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 25);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "userName";
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
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.garbageButton2);
            this.panel1.Controls.Add(this.garbageButton1);
            this.panel1.Controls.Add(this.PaperContainerPictureBox);
            this.panel1.Controls.Add(this.GlassContainerPictureBox);
            this.panel1.Controls.Add(this.BioContainerPictureBox);
            this.panel1.Controls.Add(this.PlasticContainerPictureBox);
            this.panel1.Location = new System.Drawing.Point(13, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 397);
            this.panel1.TabIndex = 1;
            // 
            // garbageButton2
            // 
            this.garbageButton2.BackColor = System.Drawing.Color.Transparent;
            this.garbageButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("garbageButton2.BackgroundImage")));
            this.garbageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton2.FlatAppearance.BorderSize = 0;
            this.garbageButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garbageButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.garbageButton2.Location = new System.Drawing.Point(253, 14);
            this.garbageButton2.Name = "garbageButton2";
            this.garbageButton2.Size = new System.Drawing.Size(75, 57);
            this.garbageButton2.TabIndex = 9;
            this.garbageButton2.TabStop = false;
            this.garbageButton2.UseVisualStyleBackColor = false;
            this.garbageButton2.Click += new System.EventHandler(this.garbageButton2_Click);
            this.garbageButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton2_MouseUp);
            // 
            // garbageButton1
            // 
            this.garbageButton1.BackColor = System.Drawing.Color.Transparent;
            this.garbageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("garbageButton1.BackgroundImage")));
            this.garbageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garbageButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.garbageButton1.Location = new System.Drawing.Point(143, 14);
            this.garbageButton1.Name = "garbageButton1";
            this.garbageButton1.Size = new System.Drawing.Size(104, 58);
            this.garbageButton1.TabIndex = 8;
            this.garbageButton1.TabStop = false;
            this.garbageButton1.UseVisualStyleBackColor = false;
            this.garbageButton1.Click += new System.EventHandler(this.garbageButton1_Click);
            this.garbageButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton1_MouseUp);
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
            this.PaperContainerPictureBox.Click += new System.EventHandler(this.PaperContainerPictureBox_Click);
            // 
            // GlassContainerPictureBox
            // 
            this.GlassContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GlassContainerPictureBox.Image")));
            this.GlassContainerPictureBox.Location = new System.Drawing.Point(669, 3);
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
            this.BioContainerPictureBox.Click += new System.EventHandler(this.BioContainerPictureBox_Click);
            // 
            // PlasticContainerPictureBox
            // 
            this.PlasticContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlasticContainerPictureBox.Image")));
            this.PlasticContainerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PlasticContainerPictureBox.Name = "PlasticContainerPictureBox";
            this.PlasticContainerPictureBox.Size = new System.Drawing.Size(131, 168);
            this.PlasticContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
        private CustomControls.GarbageButton garbageButton1;
        private CustomControls.GarbageButton garbageButton2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label movesLabel;
    }
}