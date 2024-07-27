using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Game
{
    public delegate void ScoreClosing();
    public partial class Score : Form
    {
        public ScoreClosing ScoreFormClose = null;
        public Score()
        {
            InitializeComponent();
        }
        
        public string ScoreVal
        {
            set
            {
                UI_Score_lbl.Text = value;
            }
        }


        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                ScoreFormClose();
                e.Cancel = true;
            }
           
            Hide();
        }

        private void Score_Load(object sender, EventArgs e)
        {
           // UI_Score_lbl.Text = MainOb.SendScore.ToString();
        }
    }
}
