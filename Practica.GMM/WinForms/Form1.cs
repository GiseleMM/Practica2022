using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        /*Partial: indica que esta clase  tiene otra parte, 
         * que se encuentra dividida en 2 partes
          por un lado esta donde voy a escribir los metodos y sobrecargas 
          por el otro lo que se escribe de forma automatica es  la dispocion de los
        objetos con sus caracteristica visual*/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // asocie al click este  metodo 
            // no sirve console por q NO hay consola
            //MessageBox.Show("Primer mensaje");
            //Todo:1 -Detectar el texto del textBox
            string mensaje=this.txb_igresoDatos.Text;// uso  this por que estoy dentro de la clase
            //Todo:2 -Remplazar el texto en el label
            this.lb_texto.Text = mensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton 2");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("MouseHover al boton 2");
        }
    }
}
