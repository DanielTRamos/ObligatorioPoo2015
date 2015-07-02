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
        FabricaDeEquipos ISEF = new FabricaDeEquipos();


        public Torneo()
        {
            InitializeComponent();
            listaDeEquipos = new ArrayList();
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

               
        private void CargarJugador(IJugador js)
        {
            foreach (IEquipo e in listaDeEquipos)
            {
                e.AdquirirJugador(js);
            }
        }

       
        // ---------------  Barra de MENU:
        /// <summary>
        /// Barra de menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // -----------------Botones:
        private void button4_Click(object sender, EventArgs e)// ---------  AYUDA
        {
            this.Close();
        }

        private void Btn_Opciones_Click(object sender, EventArgs e) // -------- OPCIONES
        {
            ISEF.CargarEquipos();

        }

        private void btn_salir_Click(object sender, EventArgs e) // ---------  SALIR
        {
            this.Close();
        }

        private void Btn_CargarJugadores_Click(object sender, EventArgs e)
        {
            potrero.CargarJugadores();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)// --------    UEFA
        {
            Console.WriteLine("START!!!!");
            Equipo cnf = new Equipo("Nacional"); // luego se crea lector como en el caso de jugador.
            listaDeEquipos.Add(cnf);
            Console.WriteLine("NACIONAL");
        }

    }
}
