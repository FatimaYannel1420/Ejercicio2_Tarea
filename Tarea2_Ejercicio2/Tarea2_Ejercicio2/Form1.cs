using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txt_IPARCIAL.Text);
            decimal num2 = Convert.ToDecimal(txt_IIPARCIAL.Text);
            decimal num3 = Convert.ToDecimal(txt_IIIPARCIAL.Text);
            decimal num4 = Convert.ToDecimal(txt_IVPARCIAL.Text);

            decimal total = await calcularAsinc(num1, num2, num3, num4);
            MessageBox.Show("El Promedio es: " + total+"%");
        }
        //Metodo Asincrono
        private async Task<decimal> calcularAsinc(decimal n1, decimal n2, decimal n3, decimal n4) {
            decimal suma = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return suma;

            
            
        }
    }
}
