using SegundoParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private void RegistrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro
            {
                MdiParent = this
            };
            Registro.Show();
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVendedor consultarVendedores = new ConsultarVendedor
            {
                MdiParent = this
        };
            consultarVendedores.Show();
        }
    }
}
