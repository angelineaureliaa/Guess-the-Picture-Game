using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_tebak_kata_Aurel_Cennia
{
    public partial class FormLevel : Form
    {

        public FormLevel()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            FormPlay formEasy = new FormPlay();
            formEasy.mode = "easy";
            this.Hide();
            formEasy.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            FormPlay formMedium = new FormPlay();
            formMedium.mode = "medium";
            this.Hide();
            formMedium.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            FormPlay formHard = new FormPlay();
            formHard.mode = "hard";
            this.Hide();
            formHard.Show();
        }
    }
}
