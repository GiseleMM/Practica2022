using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericosConWForm;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioGenerico<Animal> a = new FormularioGenerico<Animal>();// creo forrmulario para alta animal
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioGenerico<Flor> f = new FormularioGenerico<Flor>();//creo formulario para alta flor
            f.ShowDialog();
        }


        //METODO GENERICO EN UNA CLASE NO GENERICA
        public T MiMetodoGenerico<T>(T elemento)
        {
            return elemento;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string saludo=this.MiMetodoGenerico<String>("BIENVENIDO GENERICS");
            string saludo = this.MiMetodoGenerico<int>(33).ToString();
            MessageBox.Show(saludo,"Clase NO GENERICA usa Metodo Generics",MessageBoxButtons.OK,MessageBoxIcon.Hand);

        }
    }
}
