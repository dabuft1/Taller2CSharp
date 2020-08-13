using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDeEdad
{
    public partial class Escolar : Form
    {
        public Escolar()
        {
            InitializeComponent();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Debe diligenciar el campo", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
            else
            {
                double valor, descuento, valorFinal;
                valor = double.Parse(txtValor.Text);

                if (valor <= 100000)
                {
                    lblValorTotal.Text = Convert.ToString(valor);
                    label3.Visible = true;
                    lblValorTotal.Visible = true;
                }
                else if (valor > 100000 && valor <= 300000)
                {
                    descuento = valor * 0.10;
                    valorFinal = valor - descuento;
                    lblValorTotal.Text = Convert.ToString(valorFinal);
                    label3.Visible = true;
                    lblValorTotal.Visible = true;
                }
                else
                {
                    descuento = valor * 0.15;
                    valorFinal = valor - descuento;
                    lblValorTotal.Text = Convert.ToString(valorFinal);
                    label3.Visible = true;
                    lblValorTotal.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Empty;
            txtValor.Focus();
            label3.Visible = false;
            lblValorTotal.Visible = false;
        }
    }
}