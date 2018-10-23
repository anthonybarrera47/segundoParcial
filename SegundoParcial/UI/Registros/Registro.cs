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
        public List<VendedorDetalle> Detalle { get; set; }
        public Registro()
        {
            InitializeComponent();
            this.Detalle = new List<VendedorDetalle>();
            LlenaComboBox();
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
            this.Detalle = new List<VendedorDetalle>();
            CargarGrid();
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
                Fecha = FechaDataTimePicker.Value,
                Meta = this.Detalle
                
            };
            return vendedor;
        }
        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }
        private void LlenaCampo(Vendedor vendedor)
        {
            vendedorIDNumericUpDown.Value = vendedor.VendedorID;
            NombresTextBox.Text = vendedor.Nombres;
            sueldoNumericUpDown.Value = Convert.ToDecimal(vendedor.Sueldo);
            RetencionPorcentajeNumericUpDown.Value = Convert.ToDecimal(vendedor.RetencionPorcentaje);
            retencionCalculoTextBox.Text = Convert.ToString(vendedor.RetencionCalculo);
            FechaDataTimePicker.Value = vendedor.Fecha;
            this.Detalle = vendedor.Meta;
            CargarGrid();
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
            if (this.Detalle.Count == 0)
            {
                errorProvider.SetError(CuotatextBox, "Debe Agregar uno o mas Cuotas");
                CuotatextBox.Focus();
                paso = false;
            }

            return paso;
        }
        public bool ValidarRemover()
        {
            bool paso = true;
            if (DetalledataGridView.SelectedRows == null)
            {
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Vendedor vendedor = VendedorBLL.Buscar((int)vendedorIDNumericUpDown.Value);
            return (vendedor != null);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            Vendedor vendedor;
            bool paso = false;
            if (!Validar())
                return;

            vendedor = LlenaClase();
            if (vendedorIDNumericUpDown.Value == 0)
                paso = VendedorBLL.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No Se Puedo Modificar un Vendedor Inexistente!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = VendedorBLL.Modificar(vendedor);
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
            errorProvider.Clear();
            int id;
            int.TryParse(vendedorIDNumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(vendedorIDNumericUpDown, "No puedes Borrar Un Vendedor Inexistente");
                return;
            }
            if (VendedorBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Vendedor Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Vendedor vendedor = new Vendedor();
            int.TryParse(vendedorIDNumericUpDown.Text, out id);
            vendedor = VendedorBLL.Buscar(id);

            if (vendedor != null)
            {
                errorProvider.Clear();
                LlenaCampo(vendedor);
                MessageBox.Show("Vendedor Encontrado!!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vendedor no Encontrado!!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool ValidarAgregarMetas()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(CuotatextBox.Text.Replace("-", "")))
            {
                errorProvider.SetError(CuotatextBox, "Debe Insertar Por lo menos una cuota");
                CuotatextBox.Focus();
                paso = false;
            }
            if(MetascomboBox1.SelectedValue== null)
            {
                errorProvider.SetError(MetascomboBox1, "Debe Agragar Por lo menos un tipo de metas");
                paso = false;
            }
            return paso;
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
        public void LlenaComboBox()
        {
            RepositorioBase<Metas> repos = new RepositorioBase<Metas>();
            MetascomboBox1.DataSource = repos.GetList(x => true);
            MetascomboBox1.ValueMember = "MetaID";
            MetascomboBox1.DisplayMember = "Descripcion";

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
        private void MetasButtonClick_Click(object sender, EventArgs e)
        {
            RegistroDeMetas registroDeMetas = new RegistroDeMetas();
            registroDeMetas.ShowDialog();
            LlenaComboBox();
        }

        private void AddButtonClick_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<VendedorDetalle>)DetalledataGridView.DataSource;
            if (!ValidarAgregarMetas())
                return;

            this.Detalle.Add(
                new VendedorDetalle(
                    ID: 0,
                    VendedorID: (int)vendedorIDNumericUpDown.Value,
                    Cuota: Convert.ToDouble(CuotatextBox.Text),
                    MetaID: (int)MetascomboBox1.SelectedValue
                    )
               );
            errorProvider.Clear();
            CargarGrid();
        }

        private void RemoverFilarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
