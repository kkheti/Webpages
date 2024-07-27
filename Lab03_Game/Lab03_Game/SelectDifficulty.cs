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
    public partial class SelectDifficulty : Form
    {
        public int Choice
        {
            get
            {
                return DiffLevel;
            }
        }
        public SelectDifficulty()
        {
            InitializeComponent();
        }
        int DiffLevel;
        private void UI_Level_Radio(object sender, EventArgs e)
        {
            if(UI_Easy_Radio.Checked)
            {
                DiffLevel = 3;
            }
            if(UI_Medium_Radio.Checked)
            {
                DiffLevel = 4;
            }
            if(UI_Difficulty_Radio.Checked)
            {
                DiffLevel = 5;
            }
        }

        private void UI_OK_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
