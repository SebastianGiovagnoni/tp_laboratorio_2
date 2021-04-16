using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculaora
{
    public partial class FormCalculadora : Form
    {
        bool flag = true;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            flag = true;
            lblDecOBin.Text = "DEC";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
            lblDecOBin.Text = "DEC";
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.operar(num1, num2, operador);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                lblResultado.Text = "Valor Inválido";
            }
            else
            {
                if (flag)
                {
                    lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
                    lblDecOBin.Text = "BIN";
                    flag = false;
                }
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                lblResultado.Text = "Valor Inválido";
            }
            else
            {
                if (flag)
                {
                    lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
                    lblDecOBin.Text = "BIN";
                    flag = false;
                }
            }
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
