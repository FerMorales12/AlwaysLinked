using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Esta es la libreria que no permite usar el StreamWriter
using System.Windows.Forms;

namespace AlwaysLinked
{
    public partial class Form1 : Form
    {
        Main principal = new Main();/*Instanciamos la segunda forma para poder 
                                    abrirlo más tarde*/
                                  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "FerMorales";//Declaramos las variables para el incio de sesión
            string password = "sandia.7";
            
            if (textBox1.Text == "FerMorales" && textBox2.Text == "sandia.7")//verificamos que lo que está escrito sea igual
            {                                                                // a lo almacenado en las variables
                principal.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario o contraseña incorrecta");
            string[] datos = { textBox1.Text, textBox2.Text};
            using (StreamWriter outputfile = new StreamWriter("C: \\Users\\Diego Morales\\Desktop\\Tareas\\Progra Avanzada\\Primer proyecto\\Datos.txt")){//en esta parte almacenamos los textos en un archivo txt
                foreach (string dato in datos)
                {
                    outputfile.WriteLine(dato);
                }
            }

                
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
