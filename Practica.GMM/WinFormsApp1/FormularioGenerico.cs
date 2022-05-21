using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericosConWForm
{
    public partial class FormularioGenerico<T> : Form
    {
        public FormularioGenerico()
        {
            InitializeComponent();
            int i = 40;

            foreach (var item in typeof(T).GetProperties())// retorna todas(Coleccion) las propiedades del tipo T
            {
                Label l = new Label();/*GENERO CONTROLES de manera dinamica*/
                TextBox t = new TextBox();
                l.Name = item.Name;// a mis controles se lo asigno a la propiedades
                t.Name = item.Name;
                l.Text = item.Name + ":";
                l.Location = new Point(20, i);/* ubico en el formulario*/
                t.Location= new Point(150, i);
                i += 40;
                this.Controls.Add(l);/*agrego  a coleccion de controles*/
                this.Controls.Add(t);



            }

        }
  

    }
}
