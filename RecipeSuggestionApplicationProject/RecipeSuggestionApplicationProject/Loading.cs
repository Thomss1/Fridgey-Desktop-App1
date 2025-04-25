using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeSuggestionApplicationProject
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {

                progressBar1.Value += 2;

                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                HomePage homePage = new HomePage();
                homePage.Show(); 

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

