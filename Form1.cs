using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_de_3_números
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double numero_1, numero_2, numero_3, promedio;
            string condicion;

            numero_1 = double.Parse(txtnumero1.Text);
            numero_2 = double.Parse(txtnumero2.Text);
            numero_3 = double.Parse(txtnumero3.Text);


            
            promedio =(numero_1 + numero_2 + numero_3) / 3;

            if (promedio <=14)
            {

                condicion = "No Aprobado";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion1.Text = condicion;
            }else if (promedio > 15 && promedio <= 20)
            {
                condicion = "Aprobado";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion1.Text = condicion;
            }
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtnumero3.Clear();
            txtpromedio.Clear();
            txtcondicion1.Clear();
            txtnumero1.Focus();

        }
    }
}
