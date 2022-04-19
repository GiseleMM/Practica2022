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

        //propiedad para devolver un jugador
        public Jugador Jugador// equivalente al get jugador
        {
            get
            {
                return jugadorCargado;

            }
        }


        public AltaJugador()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txb_nombre.Text;//capturo los datos del textbox
            //string posicion = this.txb_posicion.Text;
            // Ponemos un Combo BOx CArgado con los valores del enumerado para eso en el formulario en la parte blanca clik
            // y se produce el evento LOad Le decimos q this.cbx_posicion.DataSource= Enum.GetValue(hjjjla)
            //Luego en propiedades de diseño del combo box lo cambiamos DROPDOWNSTYLE a  DROPDOWNSLIST para que no se pueda modificar

            EPosiciones posicionSeleccionada = (EPosiciones)this.cbx_posicion.SelectedItem;// casteo  lo del comboBox a EpOsiocion
            MessageBox.Show(posicionSeleccionada.ToString());// recupero nombre de un elemento del el enumerado
            int pos = (int)posicionSeleccionada;// lo casteo a int obtengo del enuemrado su parte numerica
            MessageBox.Show(pos.ToString());// lo  muestro como string con el ToString
 
            int.TryParse(this.txb_dni.Text, out int dni);
            int.TryParse(this.txb_goles.Text, out int goles);
            if(dni==0 || goles==0)
            {
                
                // o si es string la posicion en la definicion de la clase puedo hacerlo posicionSeleccionada.ToString()
                // de este  modo la hago mas flexible  Yo al enuemrado solo lo manejaria en el formulario
                
               jugadorCargado = new Jugador(nombre, posicionSeleccionada);

            }
            else
            {
                jugadorCargado = new Jugador(nombre, posicionSeleccionada, dni, goles);
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

        private void AltaJugador_Load(object sender, EventArgs e)
        {
            // vamos a intentar que el combo Box se carge con
            // las opciones de los enumerados
            this.cbx_posicion.DataSource = Enum.GetValues(typeof(EPosiciones));
            // de Este Objeto, el comboBox la Fuente de Dato del combo box
            // sea de los Ennumerados que hay en todo el codigo , vamos a obtener
            // el valor de los enumerados del tipo Eposicion
        }
    }
}
