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
    public partial class Temporadadedescuentos : Form
    {
        public Temporadadedescuentos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void pBEscolar_Click(object sender, EventArgs e)
        {
            Escolar escolar = new Escolar();
            escolar.Show();
            this.Hide();
        }

        private void pBHalloween_Click(object sender, EventArgs e)
        {
            Halloween halloween = new Halloween();
            halloween.Show();
            this.Hide();
        }

        private void pBDiciembre_Click(object sender, EventArgs e)
        {
            Diciembre diciembre = new Diciembre();
            diciembre.Show();
            this.Hide();
        }
    }
}
