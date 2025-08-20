using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectos
{
    public partial class Form1 : Form
    {
        int contaa = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {

            double peso;
            double altura;


            if (!double.TryParse(Tbpeso.Text, out peso) || peso <= 0)
            {
                MessageBox.Show("Ingrese un peso válido (número positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!double.TryParse(Tbaltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Ingrese una altura válida (número positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double imc = peso / (altura * altura);


            string clasificacion;
            if (imc < 16)
                clasificacion = "Delgadez Severa";
            else if (imc > 16 && imc < 18.5 )
                clasificacion = "Delgadez moderada";
            else if (imc > 18.5 && imc < 25)
                clasificacion = "Peso Normal ";
            else if (imc > 25 && imc < 30)
                clasificacion = "Sobrepeso";
            else if (imc > 30 && imc < 35)
                clasificacion = "Obesidad Grado 1";
            else if (imc >35 && imc < 40)
                clasificacion = "Obesidad Grado 2";
            else
                clasificacion = "Obesidad Grado 3";

            MessageBox.Show($"Su IMC es: {imc:F2}\nClasificación: {clasificacion}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tbpeso.Text = "";
            Tbaltura.Text = "";
        }
        
        private void contador_Click(object sender, EventArgs e)
        {


            contaa++;

            click.Text = contaa.ToString();

        }

        

        private void conv_Click(object sender, EventArgs e)
        {

            double valor;

          
            if (!string.IsNullOrWhiteSpace(Fah.Text) && double.TryParse(faren.Text, out valor))
            {
                double celsius = (valor - 32) * 5 / 9;
                celci.Text = celsius.ToString("F2");
            }
            
            else if (!string.IsNullOrWhiteSpace(celci.Text) && double.TryParse(celci.Text, out valor))
            {
                double fahrenheit = (valor * 9 / 5) + 32;
                faren.Text = fahrenheit.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido en uno de los campos.");
            }



        }

       
    }
}
