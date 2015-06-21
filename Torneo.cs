using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioPoo2015
{
    public partial class Torneo : Form
    {
        public Torneo()
        {
            InitializeComponent();
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("START!!!!");
            Equipo cnf = new Equipo("Nacional");
            cnf.conformacion2();
        }

       private void button1_Click(object sender, EventArgs e)
       {
           ManejadorArchivos lector = new ManejadorArchivos();
           lector.Leer("C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/test.txt");
       }
    }
}
