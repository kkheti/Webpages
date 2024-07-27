
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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get
            {
                return UI_Name_tbx.Text;
            }
        }

        private void UI_OK_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            UI_Name_tbx.Clear();
        }

        private void UI_Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
