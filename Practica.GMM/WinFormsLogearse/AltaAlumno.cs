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
    public partial class AltaAlumno : Form
    {
        Alumno aux;// quiero devolver para mandarselo a otro formulario 
                   // al igual que un get devuelve un atributo de un objeto ej dni
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Alumno aux;
            string nombre = this.tb_nombre.Text;// tendriamos q pregunatr si  son los 3 distinto de nulll
            string apellido = this.tb_apellido.Text;
            int.TryParse(this.tb_dni.Text, out int dni);
            //if(dni>0) para validar
            string direccion = this.tb_direccion.Text;
            if(string.IsNullOrEmpty(direccion) || dni==0)
            {
                aux = new Alumno(nombre, apellido);
            }
            else
            {
                aux = new Alumno(nombre, apellido, dni, direccion);
            }
            //ahi carge mi alumno , pero este alumno me queda en este formulario,
            // para poder sacarlo lo voy a sacar a Alumno  aux; de este metodo
            // y lo coloco como atributo de la clase 
                
            this.DialogResult = DialogResult.OK;// esto lo toma menu principal  para saber que devolvio el otro form
        }

        public Alumno GetAlumno()// al igual que un getDNi pero en este caso devuelve el alumno cargado
        {
            return this.aux;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;// se devuelve un cancel
        }
    }
}
