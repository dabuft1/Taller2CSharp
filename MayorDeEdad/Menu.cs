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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pB1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            Calificaciones calificaciones = new Calificaciones();
            calificaciones.Show();
            this.Hide();
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            Temporadadedescuentos temporadadedescuentos = new Temporadadedescuentos();
            temporadadedescuentos.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
