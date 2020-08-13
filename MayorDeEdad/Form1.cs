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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                MessageBox.Show("El campo debe estar diligenciado", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double edad;

                edad = double.Parse(txtEdad.Text);

                if (edad > 18)
                {
                    lblRespuesta.Text = "Usted es mayor de edad";
                }
                else if (edad < 0)

                {
                    lblRespuesta.Text = "Dato no valido";
                }
                else
                { lblRespuesta.Text = "Usted es menor de edad"; }
                lblRespuesta.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Text = String.Empty;
            lblRespuesta.Visible = false;
            txtEdad.Focus();
        }
    }
}
