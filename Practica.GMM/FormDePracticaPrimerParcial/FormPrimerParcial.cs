using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaPracticaPrimerParcial;

namespace FormDePracticaPrimerParcial
{
    public partial class FormPrimerParcial : Form
    {
        public FormPrimerParcial()
        {
            InitializeComponent();
        }

        private void FormPrimerParcial_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new PersonalMedico("Doctoor", "Milagro", new DateTime(1999, 1, 12), false));
            listBox2.Items.Add(new Paciente("Enfermo","mental","Lomas", new DateTime(2000,3, 20)));
            
        }

        private void button_atender_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is not null && listBox2.SelectedItem is not null)//esto me devuleve un objetc
            {// o listBox.Selec >0
                PersonalMedico medico = listBox1.SelectedItem as PersonalMedico;
                Paciente paciente = listBox2.SelectedItem as Paciente;
                if( medico is not null && paciente is not null)
                {
                    paciente.Diagnostico=(Diagnostico)new Random().Next(0, 3);//no incluye el 3
                    try
                    {
                        Consulta consulta = medico + paciente;// medico mas paciente me rtorna una consulta
                        MessageBox.Show(consulta.ToString());
                    }catch(Exception )
                    {
                        MessageBox.Show("la consulta no se pudo realizar");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un medico y un paciente para seguir");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is not null)// si hay algo seleccionado
            {
                richTextBox1.Text = Persona.FichaPersonal(((PersonalMedico)listBox1.SelectedItem));
            }
        }

        private void FormPrimerParcial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea salir","saliendo de aplicacion ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true; //cancelo el evento que estoy recibiendo como parametro
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
