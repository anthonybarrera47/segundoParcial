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
    public partial class Registro : Form
    {
        RepositorioBase<Vendedor> repositorio;
        public Registro()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            errorProvider.Clear();
            vendedorIDNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            sueldoNumericUpDown.Value = Convert.ToDecimal(0);
            RetencionPorcentajeNumericUpDown.Value = Convert.ToDecimal(0);
            retencionCalculoTextBox.Text = string.Empty;
            FechaDataTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor()
            {
                VendedorID = Convert.ToInt32(vendedorIDNumericUpDown.Value),
                Nombres = NombresTextBox.Text,
                Sueldo = Convert.ToDouble(sueldoNumericUpDown.Value),
                RetencionPorcentaje = Convert.ToSingle(RetencionPorcentajeNumericUpDown.Value),
                RetencionCalculo = retencionCalculoTextBox.Text,
                Fecha = FechaDataTimePicker.Value
            };
            return vendedor;
        }
        private void LlenaCampo(Vendedor vendedor)
        {
            vendedorIDNumericUpDown.Value = vendedor.VendedorID;
            NombresTextBox.Text = vendedor.Nombres;
            sueldoNumericUpDown.Value = Convert.ToDecimal(vendedor.Sueldo);
            RetencionPorcentajeNumericUpDown.Value = Convert.ToDecimal(vendedor.RetencionPorcentaje);
            retencionCalculoTextBox.Text = Convert.ToString(vendedor.RetencionCalculo);
            FechaDataTimePicker.Value = vendedor.Fecha;
        }
        private bool Validar()
        {
            bool paso = true;

            if (String.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                errorProvider.SetError(NombresTextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
            if (sueldoNumericUpDown.Value == 0)
            {
                errorProvider.SetError(sueldoNumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }
            if (RetencionPorcentajeNumericUpDown.Value == 0)
            {
                errorProvider.SetError(RetencionPorcentajeNumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }

            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor vendedor = repositorio.Buscar((int)vendedorIDNumericUpDown.Value);
            return (vendedor != null);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor vendedor;
            bool paso = false;
            if (!Validar())
                return;

            vendedor = LlenaClase();
            if (vendedorIDNumericUpDown.Value == 0)
                paso = repositorio.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    return;
                }
                paso = repositorio.Modificar(vendedor);
            }
            if (paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedor>();
            errorProvider.Clear();
            int id;
            int.TryParse(vendedorIDNumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(vendedorIDNumericUpDown, "No puedes Borrar Un Vendedor Inexistente");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Vendedor Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor vendedor = new Vendedor();
            int.TryParse(vendedorIDNumericUpDown.Text, out id);

            vendedor = repositorio.Buscar(id);

            if (vendedor != null)
            {
                errorProvider.Clear();
                LlenaCampo(vendedor);
                MessageBox.Show("Vendedor Encontrado!!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vendedor no Encontrado!!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SueldoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Double sueldo = Convert.ToDouble(sueldoNumericUpDown.Value);
            float retencion = Convert.ToSingle(RetencionPorcentajeNumericUpDown.Value);

            retencion /= 100;

            Double Total = sueldo * retencion;
            retencionCalculoTextBox.Text = Convert.ToString(Math.Round(Total, 3));

        }

        private void RetencionPorcentajeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Double sueldo = Convert.ToDouble(sueldoNumericUpDown.Value);
            float retencion = Convert.ToSingle(RetencionPorcentajeNumericUpDown.Value);

            retencion /= 100;

            Double Total = sueldo * retencion;
            retencionCalculoTextBox.Text = Convert.ToString(Math.Round(Total, 3));
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
