﻿namespace YahtzeeTeerling
{
    partial class YahtzeeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(54, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Werp alles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(195, 115);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(99, 23);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset game";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Visible = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button1);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(373, 150);
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_reset;
    }
}
