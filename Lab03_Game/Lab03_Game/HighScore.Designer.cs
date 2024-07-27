namespace Lab03_Game
{
    partial class HighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Name_tbx = new System.Windows.Forms.TextBox();
            this.UI_OK_btn = new System.Windows.Forms.Button();
            this.UI_Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // UI_Name_tbx
            // 
            this.UI_Name_tbx.Location = new System.Drawing.Point(116, 95);
            this.UI_Name_tbx.Name = "UI_Name_tbx";
            this.UI_Name_tbx.Size = new System.Drawing.Size(175, 22);
            this.UI_Name_tbx.TabIndex = 1;
            // 
            // UI_OK_btn
            // 
            this.UI_OK_btn.Location = new System.Drawing.Point(48, 157);
            this.UI_OK_btn.Name = "UI_OK_btn";
            this.UI_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_btn.TabIndex = 2;
            this.UI_OK_btn.Text = "OK";
            this.UI_OK_btn.UseVisualStyleBackColor = true;
            this.UI_OK_btn.Click += new System.EventHandler(this.UI_OK_btn_Click);
            // 
            // UI_Cancel_btn
            // 
            this.UI_Cancel_btn.Location = new System.Drawing.Point(205, 157);
            this.UI_Cancel_btn.Name = "UI_Cancel_btn";
            this.UI_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_btn.TabIndex = 3;
            this.UI_Cancel_btn.Text = "Cancel";
            this.UI_Cancel_btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_btn.Click += new System.EventHandler(this.UI_Cancel_btn_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 259);
            this.Controls.Add(this.UI_Cancel_btn);
            this.Controls.Add(this.UI_OK_btn);
            this.Controls.Add(this.UI_Name_tbx);
            this.Controls.Add(this.label1);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Name_tbx;
        private System.Windows.Forms.Button UI_OK_btn;
        private System.Windows.Forms.Button UI_Cancel_btn;
    }
}