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
    public partial class FormLevel1 : Form
    {
        public FormLevel1()
        {
            InitializeComponent();
            
        }
        private void StartGame()
        {
            Point point = labelStatrt.Location;
            point.Offset(labelStatrt.Width / 2, labelStatrt.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.playStart();
        }
        private void FinishGame()
        {
            this.DialogResult = DialogResult.OK;
        }
        private void RestartGame()
        {
            Sound.playFail();
            DialogResult dr = MessageBox.Show("Дыдыцццц!/nПродолжим?",
                "Проиграл", 
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                StartGame();
            else
                this.DialogResult = DialogResult.Abort;

        }
        private void LabelStatrt_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            StartGame();
        }

        private void labelFinsh_MouseEnter(object sender, EventArgs e)
        {
            FinishGame();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            RestartGame();
        }

        
    }
}
