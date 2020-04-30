using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP14EJ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario establezco la imagen a null.
            pcbTriangulo.Image = null;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            bool datosvalidos = (txtLado1.Text != "" && txtLado2.Text != "" && txtLado3.Text != "");

            // solo compruebo que las cajas no estén vacías.
            if (datosvalidos)
            {

                // Convierto las cajas de texto en números 
                double lado1 = Double.Parse(txtLado1.Text);
                double lado2 = Double.Parse(txtLado2.Text);
                double lado3 = Double.Parse(txtLado3.Text);

                // Creo el objeto triángulo
                Triangulo tri = new Triangulo(lado1, lado2, lado3);

                if (tri.EsEquilatero())
                {
                    pcbTriangulo.Image = AP14EJ02.Properties.Resources.equilatero;
                }
                else if (tri.EsEscaleno())
                {
                    pcbTriangulo.Image = AP14EJ02.Properties.Resources.escaleno;
                }
                else
                {
                    pcbTriangulo.Image = AP14EJ02.Properties.Resources.isosceles;
                }

            }
        }

    }
}

