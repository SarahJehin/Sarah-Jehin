namespace YahtzeeTeerling
{
    partial class ScorebordView
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
            this.label_score = new System.Windows.Forms.Label();
            this.label_score_waarde = new System.Windows.Forms.Label();
            this.label_highscore = new System.Windows.Forms.Label();
            this.label_highscore_waarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(4, 4);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(49, 17);
            this.label_score.TabIndex = 0;
            this.label_score.Text = "Score:";
            // 
            // label_score_waarde
            // 
            this.label_score_waarde.AutoSize = true;
            this.label_score_waarde.Location = new System.Drawing.Point(7, 25);
            this.label_score_waarde.Name = "label_score_waarde";
            this.label_score_waarde.Size = new System.Drawing.Size(18, 17);
            this.label_score_waarde.TabIndex = 1;
            this.label_score_waarde.Text = "\"\"";
            // 
            // label_highscore
            // 
            this.label_highscore.AutoSize = true;
            this.label_highscore.Location = new System.Drawing.Point(7, 46);
            this.label_highscore.Name = "label_highscore";
            this.label_highscore.Size = new System.Drawing.Size(72, 17);
            this.label_highscore.TabIndex = 2;
            this.label_highscore.Text = "Highscore";
            // 
            // label_highscore_waarde
            // 
            this.label_highscore_waarde.AutoSize = true;
            this.label_highscore_waarde.Location = new System.Drawing.Point(10, 67);
            this.label_highscore_waarde.Name = "label_highscore_waarde";
            this.label_highscore_waarde.Size = new System.Drawing.Size(18, 17);
            this.label_highscore_waarde.TabIndex = 3;
            this.label_highscore_waarde.Text = "\"\"";
            // 
            // ScorebordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_highscore_waarde);
            this.Controls.Add(this.label_highscore);
            this.Controls.Add(this.label_score_waarde);
            this.Controls.Add(this.label_score);
            this.Name = "ScorebordView";
            this.Load += new System.EventHandler(this.ScorebordView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_score_waarde;
        private System.Windows.Forms.Label label_highscore;
        private System.Windows.Forms.Label label_highscore_waarde;
    }
}
