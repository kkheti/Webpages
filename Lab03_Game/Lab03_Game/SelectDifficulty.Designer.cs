namespace Lab03_Game
{
    partial class SelectDifficulty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Difficulty_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Medium_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Easy_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Cancel_btn = new System.Windows.Forms.Button();
            this.UI_OK_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Difficulty_Radio);
            this.groupBox1.Controls.Add(this.UI_Medium_Radio);
            this.groupBox1.Controls.Add(this.UI_Easy_Radio);
            this.groupBox1.Location = new System.Drawing.Point(263, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(233, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // UI_Difficulty_Radio
            // 
            this.UI_Difficulty_Radio.AutoSize = true;
            this.UI_Difficulty_Radio.Location = new System.Drawing.Point(16, 198);
            this.UI_Difficulty_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Difficulty_Radio.Name = "UI_Difficulty_Radio";
            this.UI_Difficulty_Radio.Size = new System.Drawing.Size(77, 20);
            this.UI_Difficulty_Radio.TabIndex = 2;
            this.UI_Difficulty_Radio.TabStop = true;
            this.UI_Difficulty_Radio.Text = "Difficulty";
            this.UI_Difficulty_Radio.UseVisualStyleBackColor = true;
            this.UI_Difficulty_Radio.CheckedChanged += new System.EventHandler(this.UI_Level_Radio);
            // 
            // UI_Medium_Radio
            // 
            this.UI_Medium_Radio.AutoSize = true;
            this.UI_Medium_Radio.Location = new System.Drawing.Point(16, 114);
            this.UI_Medium_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Medium_Radio.Name = "UI_Medium_Radio";
            this.UI_Medium_Radio.Size = new System.Drawing.Size(76, 20);
            this.UI_Medium_Radio.TabIndex = 1;
            this.UI_Medium_Radio.TabStop = true;
            this.UI_Medium_Radio.Text = "Medium";
            this.UI_Medium_Radio.UseVisualStyleBackColor = true;
            this.UI_Medium_Radio.CheckedChanged += new System.EventHandler(this.UI_Level_Radio);
            // 
            // UI_Easy_Radio
            // 
            this.UI_Easy_Radio.AutoSize = true;
            this.UI_Easy_Radio.Location = new System.Drawing.Point(16, 43);
            this.UI_Easy_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Easy_Radio.Name = "UI_Easy_Radio";
            this.UI_Easy_Radio.Size = new System.Drawing.Size(59, 20);
            this.UI_Easy_Radio.TabIndex = 0;
            this.UI_Easy_Radio.TabStop = true;
            this.UI_Easy_Radio.Text = "Easy";
            this.UI_Easy_Radio.UseVisualStyleBackColor = true;
            this.UI_Easy_Radio.CheckedChanged += new System.EventHandler(this.UI_Level_Radio);
            // 
            // UI_Cancel_btn
            // 
            this.UI_Cancel_btn.Location = new System.Drawing.Point(463, 366);
            this.UI_Cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Cancel_btn.Name = "UI_Cancel_btn";
            this.UI_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_btn.TabIndex = 7;
            this.UI_Cancel_btn.Text = "Cancel";
            this.UI_Cancel_btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_btn.Click += new System.EventHandler(this.UI_Cancel_btn_Click);
            // 
            // UI_OK_btn
            // 
            this.UI_OK_btn.Location = new System.Drawing.Point(279, 366);
            this.UI_OK_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_OK_btn.Name = "UI_OK_btn";
            this.UI_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_btn.TabIndex = 6;
            this.UI_OK_btn.Text = "ok";
            this.UI_OK_btn.UseVisualStyleBackColor = true;
            this.UI_OK_btn.Click += new System.EventHandler(this.UI_OK_btn_Click);
            // 
            // SelectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_Cancel_btn);
            this.Controls.Add(this.UI_OK_btn);
            this.Name = "SelectDifficulty";
            this.Text = "SelectDifficulty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Difficulty_Radio;
        private System.Windows.Forms.RadioButton UI_Medium_Radio;
        private System.Windows.Forms.RadioButton UI_Easy_Radio;
        private System.Windows.Forms.Button UI_Cancel_btn;
        private System.Windows.Forms.Button UI_OK_btn;
    }
}