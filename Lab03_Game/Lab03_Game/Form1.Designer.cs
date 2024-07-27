namespace Lab03_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.UI_Play_btn = new System.Windows.Forms.Button();
            this.UI_Animation_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Show_Score_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Play_btn
            // 
            this.UI_Play_btn.Location = new System.Drawing.Point(342, 301);
            this.UI_Play_btn.Name = "UI_Play_btn";
            this.UI_Play_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Play_btn.TabIndex = 5;
            this.UI_Play_btn.Text = "Play";
            this.UI_Play_btn.UseVisualStyleBackColor = true;
            this.UI_Play_btn.Click += new System.EventHandler(this.UI_Play_btn_Click);
            // 
            // UI_Animation_Cbx
            // 
            this.UI_Animation_Cbx.AutoSize = true;
            this.UI_Animation_Cbx.Location = new System.Drawing.Point(316, 218);
            this.UI_Animation_Cbx.Name = "UI_Animation_Cbx";
            this.UI_Animation_Cbx.Size = new System.Drawing.Size(168, 20);
            this.UI_Animation_Cbx.TabIndex = 4;
            this.UI_Animation_Cbx.Text = "Show Animation Speed";
            this.UI_Animation_Cbx.UseVisualStyleBackColor = true;
            this.UI_Animation_Cbx.UseWaitCursor = true;
            this.UI_Animation_Cbx.CheckedChanged += new System.EventHandler(this.UI_Animation_Cbx_CheckedChanged);
            // 
            // UI_Show_Score_Cbx
            // 
            this.UI_Show_Score_Cbx.AutoSize = true;
            this.UI_Show_Score_Cbx.Location = new System.Drawing.Point(316, 127);
            this.UI_Show_Score_Cbx.Name = "UI_Show_Score_Cbx";
            this.UI_Show_Score_Cbx.Size = new System.Drawing.Size(101, 20);
            this.UI_Show_Score_Cbx.TabIndex = 3;
            this.UI_Show_Score_Cbx.Text = "Show Score";
            this.UI_Show_Score_Cbx.UseVisualStyleBackColor = true;
            this.UI_Show_Score_Cbx.CheckedChanged += new System.EventHandler(this.UI_Show_Score_Cbx_CheckedChanged);
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Play_btn);
            this.Controls.Add(this.UI_Animation_Cbx);
            this.Controls.Add(this.UI_Show_Score_Cbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Play_btn;
        private System.Windows.Forms.CheckBox UI_Animation_Cbx;
        private System.Windows.Forms.CheckBox UI_Show_Score_Cbx;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

