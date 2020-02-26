using System;
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
            StartLevel1();
        }
        
        private void StartLevel1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
                StartLevel2();
        }

        private void StartLevel2()
        {
            throw new NotImplementedException();
        }
    }
}
