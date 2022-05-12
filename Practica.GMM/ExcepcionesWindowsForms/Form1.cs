using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionesWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = textBox1.Text;
                int edad = int.Parse(textBox2.Text);
                Usuario usuarioNuevo;
                usuarioNuevo = new Usuario(nom, edad);
                MessageBox.Show($"usuario nuevo {usuarioNuevo.ToString()}");

            }
            catch(FormatException ex)
            {
                MessageBox.Show($">>>>>>catch de FormatException >>>>> {ex.Message}");// mi mensaje + el mensaje de la exception 
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);  esto muestra el mensaje de mi exepecion
                String mensaje = "";
                while( ex.InnerException!=null)// con esto capturo todos los mensaje de las distintas llamadas como solo hay uno el resultado es el mismo
                {
                    mensaje += ex.Message + "\n";
                    ex = ex.InnerException;
                }
                mensaje += ex.Message + "\n";
                MessageBox.Show(mensaje);
            }
        }
    }
}
