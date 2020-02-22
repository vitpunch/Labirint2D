using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soundEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (soundEnabled.Checked)
            {
                soundEnabled.Text = "звук включен";
                Sound.soundOn();
            }
            else
            {
                soundEnabled.Text = "звука нетути";
                Sound.soundOff();
            }
            Sound.playKey();
                
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Sound.playStart();
        }
    }
}
