namespace TicTacToeDesktopForms
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oGrzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jakGraćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.PlayerOneScoreLabel = new System.Windows.Forms.Label();
            this.PlayerTwoScoreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.WyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.NowaGraToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oGrzeToolStripMenuItem,
            this.jakGraćToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oGrzeToolStripMenuItem
            // 
            this.oGrzeToolStripMenuItem.Name = "oGrzeToolStripMenuItem";
            this.oGrzeToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.oGrzeToolStripMenuItem.Text = "O grze";
            this.oGrzeToolStripMenuItem.Click += new System.EventHandler(this.OGrzeToolStripMenuItem_Click);
            // 
            // jakGraćToolStripMenuItem
            // 
            this.jakGraćToolStripMenuItem.Name = "jakGraćToolStripMenuItem";
            this.jakGraćToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.jakGraćToolStripMenuItem.Text = "Jak Grać";
            this.jakGraćToolStripMenuItem.Click += new System.EventHandler(this.JakGraćToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 135);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.AutoSize = true;
            this.PlayerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneLabel.Location = new System.Drawing.Point(26, 48);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(126, 36);
            this.PlayerOneLabel.TabIndex = 10;
            this.PlayerOneLabel.Text = "Gracz 1";
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.AutoSize = true;
            this.PlayerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoLabel.Location = new System.Drawing.Point(363, 48);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(126, 36);
            this.PlayerTwoLabel.TabIndex = 11;
            this.PlayerTwoLabel.Text = "Gracz 2";
            // 
            // PlayerOneScoreLabel
            // 
            this.PlayerOneScoreLabel.AutoSize = true;
            this.PlayerOneScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneScoreLabel.Location = new System.Drawing.Point(219, 48);
            this.PlayerOneScoreLabel.Name = "PlayerOneScoreLabel";
            this.PlayerOneScoreLabel.Size = new System.Drawing.Size(32, 36);
            this.PlayerOneScoreLabel.TabIndex = 12;
            this.PlayerOneScoreLabel.Text = "0";
            // 
            // PlayerTwoScoreLabel
            // 
            this.PlayerTwoScoreLabel.AutoSize = true;
            this.PlayerTwoScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoScoreLabel.Location = new System.Drawing.Point(263, 48);
            this.PlayerTwoScoreLabel.Name = "PlayerTwoScoreLabel";
            this.PlayerTwoScoreLabel.Size = new System.Drawing.Size(32, 36);
            this.PlayerTwoScoreLabel.TabIndex = 13;
            this.PlayerTwoScoreLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(243, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // WyjścieToolStripMenuItem
            // 
            this.WyjścieToolStripMenuItem.Name = "WyjścieToolStripMenuItem";
            this.WyjścieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.WyjścieToolStripMenuItem.Text = "Wyjście";
            this.WyjścieToolStripMenuItem.Click += new System.EventHandler(this.WyjścieToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(180, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 135);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(348, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 135);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 135);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(180, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 135);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(348, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 135);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 389);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 135);
            this.button7.TabIndex = 20;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(180, 389);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 135);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(347, 389);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(162, 135);
            this.button9.TabIndex = 22;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 540);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerTwoScoreLabel);
            this.Controls.Add(this.PlayerOneScoreLabel);
            this.Controls.Add(this.PlayerTwoLabel);
            this.Controls.Add(this.PlayerOneLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "Kółko i krzyżyk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oGrzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jakGraćToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.Label PlayerOneScoreLabel;
        private System.Windows.Forms.Label PlayerTwoScoreLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem WyjścieToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

