using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObligatorioPoo2015
{
    public partial class Inicial : Form
    {
        Torneo uefa = new Torneo();


        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void Btn_CrearUEFA_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            Hide();
            timer1.Stop();
            uefa.Show();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            
        }

      

       

    }
}
