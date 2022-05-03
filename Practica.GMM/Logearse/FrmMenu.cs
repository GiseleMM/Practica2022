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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //public FrmMenu(string nombreUsuario):this()
        //{
        //    this.lb_Mensaje.Text = this.lb_Mensaje.Text + "" + nombreUsuario;
        //}

        public void ActualizarMensaje(string nombreUsuario)
        {
            this.lb_Mensaje.Text = this.lb_Mensaje.Text +" "+ nombreUsuario;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // para no permitir que el usuario cierre el form
            //if(e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //}
            Application.Exit();
        }

        private void bt_agragar_Click(object sender, EventArgs e)
        {
            this.lbx_listBox.Items.Add("Agrego algo a listBox");
        }
    }
}
