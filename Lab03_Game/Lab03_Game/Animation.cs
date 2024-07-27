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
    public delegate void ThreadDelay();
    public partial class Animation : Form
    {
        public ThreadDelay AnimationDelay = null;
        public Animation()
        {
            InitializeComponent();
        }
        
        public int FallDelay
        {
            get
            {
                return UI_TrackBar.Value;
            }
        }

        private void Animation_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                AnimationDelay();
                e.Cancel = true;
            }

            Hide();
        }
    }
}
