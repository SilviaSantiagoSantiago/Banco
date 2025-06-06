using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form3 : Form
    {
        private CuentaJR cuenta;
        public Form3()
        {
            InitializeComponent();
            cuenta = new CuentaJR();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            this.nombre.Text = cuenta.Nombre;
            this.cuent.Text = cuenta.NumCuenta;
            saldo.Text = "$ " + cuenta.Saldo;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposito_Click(object sender, EventArgs e)
        {
            if (cantidad.Text != "")
            {
                try
                {
                    bool resultado = cuenta.Deposito(float.Parse(cantidad.Text));
                    if (resultado)
                    {
                        saldo.Text = "$ " + cuenta.Saldo;
                        cantidad.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Depósito no permitido. Revisa el límite de $5000 o saldo máximo $35000.");
                        cantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Cantidad inválida.");
                    cantidad.Text = "";
                }
            }
        }

        private void retiro_Click(object sender, EventArgs e)
        {
            if (cantidad.Text != "")
            {
                try
                {
                    bool resultado = cuenta.Retiro(float.Parse(cantidad.Text));
                    if (resultado)
                    {
                        saldo.Text = "$ " + cuenta.Saldo;
                        cantidad.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Retiro no permitido. Máximo $5000 o saldo insuficiente.");
                        cantidad.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Cantidad inválida.");
                    cantidad.Text = "";
                }
            }
        }

        private void estado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Estado());
        }


    }
}
