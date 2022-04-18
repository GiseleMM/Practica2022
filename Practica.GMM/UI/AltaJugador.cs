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
    public partial class AltaJugador : Form
    {
        Jugador jugadorCargado;
        public AltaJugador()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txb_nombre.Text;//capturo los datos del textbox
            string posicion = this.txb_posicion.Text;
            int.TryParse(this.txb_dni.Text, out int dni);
            int.TryParse(this.txb_goles.Text, out int goles);
            if(dni==0 || goles==0)
            {
                jugadorCargado = new Jugador(nombre, posicion);

            }
            else
            {
                jugadorCargado = new Jugador(nombre, posicion, dni, goles);
            }
            this.DialogResult = DialogResult.OK;// se creo jugador retorno  OK
  
       
        }
        //Metodo para retornar el jugador
        public Jugador GetJugador()// IMPORTANTE>>>me saltaba error por que NO cambie a public la clase
        {
            return this.jugadorCargado;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
