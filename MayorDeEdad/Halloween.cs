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
    public partial class Halloween : Form
    {
        public Halloween()
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

                if (valor <= 30000)
                {
                    lblValorTotal.Text = Convert.ToString(valor);
                    label3.Visible = true;
                    lblValorTotal.Visible = true;
                }
                else if (valor > 30000   && valor <= 200000)
                {
                    descuento = valor * 0.02;
                    valorFinal = valor - descuento;
                    lblValorTotal.Text = Convert.ToString(valorFinal);
                    label3.Visible = true;
                    lblValorTotal.Visible = true;
                }
                else
                {
                    descuento = valor * 0.05;
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
