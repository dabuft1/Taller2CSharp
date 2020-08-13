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
    public partial class Calificaciones : Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtNota4.Text == "" || txtNota5.Text == "")
            {
                MessageBox.Show("Debe diligenciar todos los campos", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{



                double nota1, nota2, nota3, nota4, nota5, notaFinal;

                nota1 = double.Parse(txtNota1.Text);
                nota2 = double.Parse(txtNota2.Text);
                nota3 = double.Parse(txtNota3.Text);
                nota4 = double.Parse(txtNota4.Text);
                nota5 = double.Parse(txtNota5.Text);

                notaFinal = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                if (nota1 < 0 || nota1 > 5 || nota2 < 0 || nota2 > 5 || nota3 < 0 || nota3 > 5 || nota4 < 0 || nota4 > 5 || nota5 < 0 || nota5 > 5)
                {
                    MessageBox.Show("La nota ingresa debe tener un rago entre 0 y 5", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblResultado.Visible = false;
                    lblNotaFinal.Visible = false;
                }
                else if (notaFinal >= 0 && notaFinal <= 1)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Reprueba la materia sin lograr realizar proceso de recuperación.";
                }
                else if (notaFinal > 1 && notaFinal < 3)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Reprueba la materia y puede hacer la habilitación";
                }
                else if (notaFinal >= 3 && notaFinal < 4)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Aprueba la materia con plan de mejora";
                }
                else if (notaFinal >= 4 && notaFinal <= 4.5)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Buen rendimiento";
                }
                else if (notaFinal >= 4.6 && notaFinal <= 4.9)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Excelente";
                }
                else if (notaFinal == 5)
                {
                    lblNotaFinal.Text = Convert.ToString(notaFinal);
                    lblResultado.Text = "Graduado con honores";
                }
                lblNotaFinal.Visible = true;
                lblResultado.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;
            txtNota5.Text = String.Empty;
            txtNota1.Focus();
            lblNotaFinal.Visible = false;
            lblResultado.Visible = false;
        }
    }
}