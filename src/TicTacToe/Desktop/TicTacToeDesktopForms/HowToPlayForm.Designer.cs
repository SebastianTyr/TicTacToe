namespace TicTacToeDesktopForms
{
    partial class HowToPlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayForm));
            this.howLabel = new System.Windows.Forms.Label();
            this.howLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // howLabel
            // 
            this.howLabel.AutoSize = true;
            this.howLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howLabel.Location = new System.Drawing.Point(13, 20);
            this.howLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howLabel.Name = "howLabel";
            this.howLabel.Size = new System.Drawing.Size(0, 20);
            this.howLabel.TabIndex = 0;
            // 
            // howLabel1
            // 
            this.howLabel1.AutoSize = true;
            this.howLabel1.Location = new System.Drawing.Point(13, 64);
            this.howLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howLabel1.Name = "howLabel1";
            this.howLabel1.Size = new System.Drawing.Size(0, 20);
            this.howLabel1.TabIndex = 1;
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 123);
            this.Controls.Add(this.howLabel1);
            this.Controls.Add(this.howLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HowToPlayForm";
            this.Text = "HowToPlayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label howLabel;
        private System.Windows.Forms.Label howLabel1;
    }
}