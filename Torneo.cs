using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ObligatorioPoo2015
{
    public partial class Torneo : Form
    {
        private ArrayList listaDeEquipos;
        EscuelaDeJugadores potrero = new EscuelaDeJugadores();


        public Torneo()
        {
            InitializeComponent();
            listaDeEquipos = new ArrayList();
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("START!!!!");
            Equipo cnf = new Equipo("Nacional"); // luego se crea lector como en el caso de jugador.
            listaDeEquipos.Add(cnf);
            Console.WriteLine("NACIONAL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            potrero.CargarJugadores();
        }


        private void CargarJugador(IJugador js)
        {
            foreach (IEquipo e in listaDeEquipos)
            {
                e.AdquirirJugador(js);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (IEquipo eq in listaDeEquipos)
            {

                eq.presentarJugadores();
            }



        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IJugador Atacante = potrero.BrindarDelantero();
            Atacante.Presentarse();


        }
    }
}
