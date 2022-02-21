﻿
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
            this.garbageButton5 = new SortGarbage.Views.CustomControls.GarbageButton();
            this.garbageButton4 = new SortGarbage.Views.CustomControls.GarbageButton();
            this.garbageButton3 = new SortGarbage.Views.CustomControls.GarbageButton();
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
            this.SettingsPanel.Location = new System.Drawing.Point(19, 3);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1107, 53);
            this.SettingsPanel.TabIndex = 0;
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movesLabel.Location = new System.Drawing.Point(693, 7);
            this.movesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(131, 40);
            this.movesLabel.TabIndex = 4;
            this.movesLabel.Text = "Ruchy: 0 ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(483, 7);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(125, 40);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Wynik: 0";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLabel.Location = new System.Drawing.Point(246, 7);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(147, 40);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "userName";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerLabel.Location = new System.Drawing.Point(29, 7);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(97, 40);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "mm:ss";
            // 
            // EndGameButton
            // 
            this.EndGameButton.Location = new System.Drawing.Point(901, 7);
            this.EndGameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(201, 38);
            this.EndGameButton.TabIndex = 0;
            this.EndGameButton.Text = "Zakończ gre";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.garbageButton5);
            this.panel1.Controls.Add(this.garbageButton4);
            this.panel1.Controls.Add(this.garbageButton3);
            this.panel1.Controls.Add(this.garbageButton2);
            this.panel1.Controls.Add(this.garbageButton1);
            this.panel1.Controls.Add(this.PaperContainerPictureBox);
            this.panel1.Controls.Add(this.GlassContainerPictureBox);
            this.panel1.Controls.Add(this.BioContainerPictureBox);
            this.panel1.Controls.Add(this.PlasticContainerPictureBox);
            this.panel1.Location = new System.Drawing.Point(19, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 662);
            this.panel1.TabIndex = 1;
            // 
            // garbageButton5
            // 
            this.garbageButton5.AssignedGarbage = null;
            this.garbageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton5.DefaultLocation = new System.Drawing.Point(485, 265);
            this.garbageButton5.FlatAppearance.BorderSize = 0;
            this.garbageButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garbageButton5.Location = new System.Drawing.Point(660, 437);
            this.garbageButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garbageButton5.Name = "garbageButton5";
            this.garbageButton5.Size = new System.Drawing.Size(229, 200);
            this.garbageButton5.TabIndex = 12;
            this.garbageButton5.TabStop = false;
            this.garbageButton5.UseVisualStyleBackColor = true;
            this.garbageButton5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton5_MouseUp);
            // 
            // garbageButton4
            // 
            this.garbageButton4.AssignedGarbage = null;
            this.garbageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton4.DefaultLocation = new System.Drawing.Point(140, 274);
            this.garbageButton4.FlatAppearance.BorderSize = 0;
            this.garbageButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garbageButton4.Location = new System.Drawing.Point(214, 457);
            this.garbageButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garbageButton4.Name = "garbageButton4";
            this.garbageButton4.Size = new System.Drawing.Size(229, 200);
            this.garbageButton4.TabIndex = 11;
            this.garbageButton4.TabStop = false;
            this.garbageButton4.UseVisualStyleBackColor = true;
            this.garbageButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton4_MouseUp);
            // 
            // garbageButton3
            // 
            this.garbageButton3.AssignedGarbage = null;
            this.garbageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton3.DefaultLocation = new System.Drawing.Point(316, 136);
            this.garbageButton3.FlatAppearance.BorderSize = 0;
            this.garbageButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garbageButton3.Location = new System.Drawing.Point(451, 227);
            this.garbageButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garbageButton3.Name = "garbageButton3";
            this.garbageButton3.Size = new System.Drawing.Size(229, 200);
            this.garbageButton3.TabIndex = 10;
            this.garbageButton3.TabStop = false;
            this.garbageButton3.UseVisualStyleBackColor = true;
            this.garbageButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton3_MouseUp);
            // 
            // garbageButton2
            // 
            this.garbageButton2.AssignedGarbage = null;
            this.garbageButton2.BackColor = System.Drawing.Color.Transparent;
            this.garbageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton2.DefaultLocation = new System.Drawing.Point(480, 1);
            this.garbageButton2.FlatAppearance.BorderSize = 0;
            this.garbageButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garbageButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.garbageButton2.Location = new System.Drawing.Point(631, 5);
            this.garbageButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garbageButton2.Name = "garbageButton2";
            this.garbageButton2.Size = new System.Drawing.Size(229, 200);
            this.garbageButton2.TabIndex = 9;
            this.garbageButton2.TabStop = false;
            this.garbageButton2.UseVisualStyleBackColor = false;
            this.garbageButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton2_MouseUp);
            // 
            // garbageButton1
            // 
            this.garbageButton1.AssignedGarbage = null;
            this.garbageButton1.BackColor = System.Drawing.Color.Transparent;
            this.garbageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.garbageButton1.DefaultLocation = new System.Drawing.Point(150, 1);
            this.garbageButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garbageButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.garbageButton1.Location = new System.Drawing.Point(214, 2);
            this.garbageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garbageButton1.Name = "garbageButton1";
            this.garbageButton1.Size = new System.Drawing.Size(229, 200);
            this.garbageButton1.TabIndex = 8;
            this.garbageButton1.TabStop = false;
            this.garbageButton1.UseVisualStyleBackColor = false;
            this.garbageButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbageButton1_MouseUp);
            // 
            // PaperContainerPictureBox
            // 
            this.PaperContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PaperContainerPictureBox.Image")));
            this.PaperContainerPictureBox.Location = new System.Drawing.Point(901, 338);
            this.PaperContainerPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaperContainerPictureBox.Name = "PaperContainerPictureBox";
            this.PaperContainerPictureBox.Size = new System.Drawing.Size(201, 323);
            this.PaperContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaperContainerPictureBox.TabIndex = 3;
            this.PaperContainerPictureBox.TabStop = false;
            // 
            // GlassContainerPictureBox
            // 
            this.GlassContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GlassContainerPictureBox.Image")));
            this.GlassContainerPictureBox.Location = new System.Drawing.Point(901, 5);
            this.GlassContainerPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GlassContainerPictureBox.Name = "GlassContainerPictureBox";
            this.GlassContainerPictureBox.Size = new System.Drawing.Size(206, 323);
            this.GlassContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GlassContainerPictureBox.TabIndex = 2;
            this.GlassContainerPictureBox.TabStop = false;
            // 
            // BioContainerPictureBox
            // 
            this.BioContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BioContainerPictureBox.Image")));
            this.BioContainerPictureBox.Location = new System.Drawing.Point(6, 338);
            this.BioContainerPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BioContainerPictureBox.Name = "BioContainerPictureBox";
            this.BioContainerPictureBox.Size = new System.Drawing.Size(186, 318);
            this.BioContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BioContainerPictureBox.TabIndex = 1;
            this.BioContainerPictureBox.TabStop = false;
            // 
            // PlasticContainerPictureBox
            // 
            this.PlasticContainerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlasticContainerPictureBox.Image")));
            this.PlasticContainerPictureBox.Location = new System.Drawing.Point(4, 5);
            this.PlasticContainerPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlasticContainerPictureBox.Name = "PlasticContainerPictureBox";
            this.PlasticContainerPictureBox.Size = new System.Drawing.Size(187, 323);
            this.PlasticContainerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlasticContainerPictureBox.TabIndex = 0;
            this.PlasticContainerPictureBox.TabStop = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private CustomControls.GarbageButton garbageButton5;
        private CustomControls.GarbageButton garbageButton4;
        private CustomControls.GarbageButton garbageButton3;
    }
}