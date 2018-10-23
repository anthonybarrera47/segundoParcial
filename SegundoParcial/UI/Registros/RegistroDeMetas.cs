using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial.UI.Registros
{
    public partial class RegistroDeMetas : Form
    {
        RepositorioBase<Metas> repositorio;
        public RegistroDeMetas()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            MetasIdNumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CuotanumericUpDown2.Value = 0;
        }
        public Metas LlenaClase()
        {
            Metas metas = new Metas()
            {
                MetaID = Convert.ToInt32(MetasIdNumericUpDown.Value),
                Descripcion = DescripciontextBox.Text,
                Cuota = Convert.ToDouble(CuotanumericUpDown2.Value)
            };
            return metas;
        }
        public void LlenaCampos(Metas metas)
        {
            MetasIdNumericUpDown.Value = metas.MetaID;
            DescripciontextBox.Text = metas.Descripcion;
            CuotanumericUpDown2.Value = Convert.ToDecimal(metas.Cuota);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Metas>();
            Metas metas;
            bool paso = false;

            metas = LlenaClase();
            if (MetasIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(metas);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No Se Puede Modificar una meta que no existe!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(metas);
            }
            if (paso)
            {
                MessageBox.Show("Meta Guardada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Metas>();
            Metas metas = repositorio.Buscar((int)MetasIdNumericUpDown.Value);
            return (metas != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Metas>();
            int id;
            int.TryParse(MetasIdNumericUpDown.Text, out id);
            Metas metas = new Metas();
            metas = repositorio.Buscar(id);
            if(metas!=null)
            {
                LlenaCampos(metas);
                MessageBox.Show("Metas Encontrado!!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Metas no Encontrado!!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
