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
    public partial class MenuPrincipal : Form
    {
        private string usuario;
        Alumno[] listaAlumnos;
        
        //public MenuPrincipal()  lo convierto a uso interno por eso lo pongo privado
        private MenuPrincipal()
        {
            InitializeComponent();
            listaAlumnos = new Alumno[3];//instansio array
            Cargar();
            

        }
        public MenuPrincipal(string usuario):this()// para inicilizar componentes, podria tambie incializara los commponentes y borara elde arriba pero es mejor REuTILIZAR Codigo
        {
            this.usuario = usuario;//para que pueda dar la bienvenida a usuario
        }
        private void Cargar()
        {
            listaAlumnos[0] = new Alumno("Gisele", "Gomez");
            listaAlumnos[1] = new Alumno("Miguel", "Perez");
            //listaAlumnos[2] = new Alumno("Sebas", "Aranda");
        }
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lb_welcome.Text = "Welcome " + this.usuario;
            for (int i=0;i<listaAlumnos.Length;i++)
            {
                if(listaAlumnos[i]!=null)
                {
                    this.rtb_informacion.Text += listaAlumnos[i].MostrarAlumno() + "\n";
                    //con esto vemos la informacion de los alumnos cargados
                }
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //levanto un formulario 
            AltaAlumno frmAltaAlumno = new AltaAlumno();//instancio un objeto del tipo alta alumno
                                                        //frmAltaAlumno.Show(); esto muestra el otro formulario
                                                        //pero esto no cierra cuando le ponemos aceptar por lo que usamos
                                                        // showDialog 
                                                        //if( frmAltaAlumno.ShowDialog()==
                                                        //   DialogResult.OK)con esto se va a abrir y espera la respuesta
                                                        // DialogResul es un ENUMERADOS son valores predefinidos
                                                        //entonces si mellega a venir de  respuesta del otro formulario
                                                        // ejecuto el metodo GETAlumno
            DialogResult resultado = frmAltaAlumno.ShowDialog();
            if(resultado==DialogResult.OK)
            {
                // buscar metodoq que busque el lugar libre
                //listaAlumnos[2]=frmAltaAlumno.GetAlumno();// lo asigno a la posicion q este libre
                int indiceLibre = PosicionLibre();
                if(indiceLibre!=-1)
                {
                    listaAlumnos[indiceLibre] = frmAltaAlumno.GetAlumno();//aasigno el alumno
                    this.rtb_informacion.Text += frmAltaAlumno.GetAlumno().MostrarAlumno() + "\n";
                    //o 
                    //this.rtb_informacion.Text += listaAlumnos[indiceLibre].MostrarAlumno() + "\n";
                }
                else
                {
                    MessageBox.Show("No hay mas lugar");
                }
            }
           else
            {
                MessageBox.Show("Carga cancelada");
            }
           /*
            * pasos: 1 instanciar el formulario
            * 2 metodo showDialog (NO el SHOW por que nos deja usar
            * dos o 3 formularios al mismo tiempo esto lo bloquea) lo abre pero se queda esperando algo
            * del otro formulario que me da la señal de q ya teminamos
            * de usarlo y devuelve el resulatdo
            * 3  si el dialogoResul me da ok voy a recuperar ese alumno 
            * con el metodo GetALumno
            */
           
        }
        private int PosicionLibre()//busca una posicion libre en el array
        {
            for(int i =0; i<listaAlumnos.Length;i++)
            {
                if(listaAlumnos[i]==null)
                {
                    return i;
                }
            }
            return -1;// no hay posicon libre
        }
    }
}
