using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Principal : Form
    {
        List<Jugador> listaJugadores;//Creo lista
        public Principal()
        {
            InitializeComponent();
            listaJugadores = new List<Jugador>();
        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)//EVENTOS
        {
            // abro un formulario donde . Instancio un nuevo formulario
            //cargo los datos de un jugador 
            // preguntar si lla terminaste con el form con el DialogResult
            //lo van a devolver a este formulario
            // si el dialogResult da OK traer el jugador
            // y lo  van agregar a una lista de jugadores que deberia estar es esta clase 
            // cuando vuelva va a ser de jugador.Add()
            //listaJugadores.Add(Agrego el jugador nuevo)

            AltaJugador frmJugador = new AltaJugador();//instacio formulario de alta 
            DialogResult resultado = frmJugador.ShowDialog();// modal espera respuesta
            if (resultado == DialogResult.OK)
            {
                //listaJugadores.Add(frmJugador.GetJugador());cargo en la lista
                //MessageBox.Show($"jugador cargado en lista: {"\n"}{frmJugador.GetJugador().MostrarJUgador()}");
                //this.rtb_mostrarJugadores.Text += frmJugador.GetJugador().MostrarJUgador()+"\n";
                listaJugadores.Add(frmJugador.Jugador);// uso la propiedad para   obtener el jugador del formulario de Alta 
                this.rtb_mostrarJugadores.Text += frmJugador.Jugador.MostrarJUgador()+ "\n";
               
                //this.rtb_informacion.Text += listaAlumnos[indiceLibre].MostrarAlumno() + "\n";
              
              
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }


        }
    }
}
