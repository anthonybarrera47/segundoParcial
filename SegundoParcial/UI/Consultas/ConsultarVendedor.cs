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
    public partial class ConsultarVendedor : Form
    {
        RepositorioBase<Vendedor> repositorio;
        public ConsultarVendedor()
        {
            InitializeComponent();
            FiltroComboBox.SelectedIndex = 0;//Seleccionamos por default el Campo "Todos" de nuestro ComboBox
        }
        //Codigo De La Consulta
        private void Seleccion()
        {
            repositorio = new RepositorioBase<Vendedor>();
            var lista = new List<Vendedor>();
            errorProvider.Clear();
            if (CriterioTextBox.Text.Trim().Length >= 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Todo 
                        lista = repositorio.GetList(p => true);
                        break;
                    case 1: //Por ID
                        if (!Validar())
                            return;
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(p => p.VendedorID == id);
                        break;
                    case 2://Por Nombre
                        if (!Validar())
                            return;
                        lista = repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Por Sueldo
                        if (!Validar())
                            return;
                        Double sueldo = Convert.ToDouble(CriterioTextBox.Text);
                        lista = repositorio.GetList(p => p.Sueldo == sueldo);
                        break;
                    case 4://Por Porcentaje de Retencion
                        if (!Validar())
                            return;
                        float retencion = Convert.ToSingle(CriterioTextBox.Text);
                        lista = repositorio.GetList(p => p.RetencionPorcentaje == retencion);
                        break;
                    case 5: // Retencion a Pagar
                        if (!Validar())
                            return;
                        lista = repositorio.GetList(p => p.RetencionCalculo.Contains(CriterioTextBox.Text));
                        break;
                }

                lista = lista.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            ConsultaVendedoresDataGridView.DataSource = null;
            ConsultaVendedoresDataGridView.DataSource = lista;
        }
        //Evento del Boton Click Consulta
        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            Seleccion();
        }
        //Validacion del CriterioTextBox
        private void CriterioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento por si se desea utilizar el Boton Enter para consultar.
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Seleccion();
            }
            //Si Vamos a buscar por ID podremos digitar nada que no sea un numero Entero.
            if (FiltroComboBox.SelectedIndex == 1)
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
                return;

            }
            //Validamos EL textBox para que en el momento de digitar Sueldo y Retenciones solo nos permita digitar numeros.
            if (FiltroComboBox.SelectedIndex == 3 || FiltroComboBox.SelectedIndex == 4 || FiltroComboBox.SelectedIndex == 5)
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }
                bool IsDec = false;
                int nroDec = 0;
                for (int x = 0; x < CriterioTextBox.Text.Length; x++)
                {
                    if (CriterioTextBox.Text[x] == '.')
                    {IsDec = true;}
                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;
            }
            else
            {
                //En caso que fuesemos a buscar por Nombres entonces si podremos Digitar Letras
                if (Char.IsLetter(e.KeyChar))
                { e.Handled = false;}
                else if (Char.IsControl(e.KeyChar))
                {e.Handled = false;}
                else if (Char.IsSeparator(e.KeyChar))
                {e.Handled = false;}
                else
                {e.Handled = true;}
            }
        }
        //Avisamosa al usuario de algun error en la consulta por fechas
        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                errorProvider.SetError(HastadateTimePicker, "La Fecha del campo Desde no puede ser mayor que la del Campo Hasta");
            else
                errorProvider.Clear();
        }
        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                errorProvider.SetError(DesdedateTimePicker, "La Fecha del campo Hasta no puede ser menor que la del Campo Desde");
            else
                errorProvider.Clear();
        }
        //Cada vez que cambiemos de Seleccion En el ComboBox Limpiamos nuestra consultar
        private void FiltroComboBox_TextChanged(object sender, EventArgs e)
        {
            CriterioTextBox.Text = "";
            ConsultaVendedoresDataGridView.DataSource = null;
        }
        //Validamos Los Campos
        private bool Validar()
        {
            bool paso = true;
            if (CriterioTextBox.Text.FirstOrDefault() == '.')
                paso = false;
            if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                errorProvider.SetError(CriterioTextBox, "Debe poner Informacion en el campo");
                paso = false;
            }
            return paso;
        }
        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiltroComboBox.SelectedIndex>0)
                CriterioTextBox.Enabled = true;
            else
                CriterioTextBox.Enabled = false;
        }
    }
}
