using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysLinked
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Text = richTextBox1.Text;/* en esta parte nos permite ingresar
            cualquier texto para mantener nuestro estado actualizado cual FB o Twitter*/
            richTextBox1.Text = "";
            string[] datos = { label2.Text};
            using (StreamWriter outputfile = new StreamWriter("C: \\Users\\Diego Morales\\Desktop\\Tareas\\Progra Avanzada\\Primer proyecto\\Estado.txt"))
            {
                foreach (string dato in datos)
                {
                    outputfile.WriteLine(dato);
                }
            }

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objform = new Form1();
            this.Close();
            objform.Show();
        }

        private void messengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Messenger chat = new Messenger();
            chat.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
