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
    public partial class Form2 : Form
    {
        private Cuenta_Empresa cuenta;


        public Form2()
        {
            InitializeComponent();
            cuenta = new Cuenta_Empresa();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            nombre.Text = cuenta.Nombre;
            rfc.Text = cuenta.RFC;
            cuent.Text = cuenta.NumCuenta;
            saldo.Text = "$ " + cuenta.Saldo;

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Depósito no permitido.");
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
                        MessageBox.Show("Retiro no permitido. Debes dejar al menos $50 de saldo.");
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
