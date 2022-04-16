using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLogearse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txb_usuario.Text.ToLower()!="pepe" || this.txb_password.Text!="888N")
            {
                MessageBox.Show("Datos invalidos");
            }
            else
            {
                MessageBox.Show("Usuario logeado");
                this.txb_password.BackColor = Color.Aquamarine;
                this.txb_usuario.BackColor = Color.Aquamarine;
            }
        }

  
    }
}
