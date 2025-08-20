using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        int intentos = 0;

     
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = ctUsuario.Text;
            string clave = ctClave.Text;

            if (usuario == "admin" && clave == "admin123")
            {
                MessageBox.Show("Bienvenido al Sistema: " + usuario);
               
            }
            else
            {
                intentos++;
                int intentosRestantes = 3 - intentos;

                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Usuario o clave incorrectos. Te quedan: " + intentosRestantes + " intento(s).");
                }
                else
                {
                    MessageBox.Show("Has excedido el número de intentos.");
                    Close(); 
                }
            }
        }

        
    }
}
