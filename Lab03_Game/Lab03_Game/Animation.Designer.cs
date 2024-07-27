namespace Lab03_Game
{
    partial class Animation
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
            this.UI_Max_val = new System.Windows.Forms.Label();
            this.UI_Min_val = new System.Windows.Forms.Label();
            this.UI_TrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Max_val
            // 
            this.UI_Max_val.AutoSize = true;
            this.UI_Max_val.Location = new System.Drawing.Point(631, 206);
            this.UI_Max_val.Name = "UI_Max_val";
            this.UI_Max_val.Size = new System.Drawing.Size(53, 16);
            this.UI_Max_val.TabIndex = 5;
            this.UI_Max_val.Text = "2000ms";
            // 
            // UI_Min_val
            // 
            this.UI_Min_val.AutoSize = true;
            this.UI_Min_val.Location = new System.Drawing.Point(53, 206);
            this.UI_Min_val.Name = "UI_Min_val";
            this.UI_Min_val.Size = new System.Drawing.Size(39, 16);
            this.UI_Min_val.TabIndex = 4;
            this.UI_Min_val.Text = "10ms";
            // 
            // UI_TrackBar
            // 
            this.UI_TrackBar.Location = new System.Drawing.Point(55, 136);
            this.UI_TrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_TrackBar.Maximum = 200;
            this.UI_TrackBar.Name = "UI_TrackBar";
            this.UI_TrackBar.Size = new System.Drawing.Size(607, 56);
            this.UI_TrackBar.TabIndex = 3;
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Max_val);
            this.Controls.Add(this.UI_Min_val);
            this.Controls.Add(this.UI_TrackBar);
            this.Name = "Animation";
            this.Text = "Animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Animation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Max_val;
        private System.Windows.Forms.Label UI_Min_val;
        private System.Windows.Forms.TrackBar UI_TrackBar;
    }
}