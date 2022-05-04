using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaLaLibreria;

namespace LaLibreria
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor("Rosa");

        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            this.lst_Stock.Items.Add(p1);
            this.lst_Stock.Items.Add(p2);
            this.lst_Stock.Items.Add(p3);
            this.lst_Stock.Items.Add(p4);
            this.lst_Stock.Items.Add(p5);


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cerrar formulario?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_verInforme_Click(object sender, EventArgs e)
        {
            rtb_Informe.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
           // bool pudoVender;
      
            Publicacion publicacion = (Publicacion)lst_Stock.SelectedItem;
            if ((publicacion is not null) && (vendedor + publicacion))
            {
                //pudoVender = vendedor + publicacion;
                //  if (pudoVender)
                //{
                MessageBox.Show("Venta realizada");
                //}

            }
            else
            {
                MessageBox.Show("Venta no realizada");
            }
        }

        //private void lst_Stock_SelectedIndexChanged(object sender, EventArgs e)
        //{
         
        //}
    }
}
