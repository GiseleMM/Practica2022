using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logearse
{
    public partial class FormLogearse : Form
    {
        public FormLogearse()
        {
            InitializeComponent();
        }

        private void btn_logearse_Click(object sender, EventArgs e)
        {
            //EVENTO la accion que voy a realizar si el usuario hace un click
            //si  borro esto y voy a l formulario, automaticamente se rompe por que el click de ese boton no se encuentra  pero esta 
            // en el Form.Desing, tengo que borrarolo ahi tambien

            if (this.txb_usuario.Text == "gisele" && this.txb_clave.Text == "6666")
            {
                // Con sobreescitura de constructor  >>>FrmMenu menuPrincipal = new FrmMenu(this.txb_usuario.Text);//creo obj del tipo menu que en crealidad es un formulario
                // aca esta creado el formulario pero no se muestra

                //Con metodo Actualizar mensaje 
                FrmMenu menuPrincipal = new FrmMenu();
                menuPrincipal.ActualizarMensaje(this.txb_usuario.Text); 
                menuPrincipal.Show();// muestro el menu
               
                this.Hide(); //oculto este formulario

                MessageBox.Show("Usuario logeado");
            }
            else
            {
                MessageBox.Show("Invalido usuario/clave");
                this.txb_usuario.Text = string.Empty;//vacio los campos
                this.txb_clave.Text = "";
            }

        }
    }
}
