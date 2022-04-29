using CxPagar_system.Data;
using CxPagar_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPagar_system.Views.Forms.Mant
{
    public partial class Mant_Concepto_Pago : Form
    {
        public Mant_Concepto_Pago()
        {
            InitializeComponent();
            CbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDescripcion.Enabled = false;
            txtIDCP.Enabled = false;
            CbEstado.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
            CbEstado.Enabled = true;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion");
            }
            else
            {
                try
                {
                    ConceptoPago c = new ConceptoPago();
                    c.Descripcion = txtDescripcion.Text.Trim().ToUpper();
                    c.Estado = txtDescripcion.Text.Trim().ToUpper();

                    if (ConceptoPagoCAD.Guardar(c))
                    {
                        LimpiarCampos();
                        llenarGrid();
                        MessageBox.Show("Registro guardado");
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo guardar el registro");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtIDCP.Text = "";
            CbEstado.Text = "";
        }

        private void llenarGrid()
        {
            DataTable datos = ConceptoPagoCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logo acceder a los datos");
            }
            else
            {
                dgLista.DataSource = datos.DefaultView;
            }
        }

        private void Mant_Concepto_Pago_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion");
            }
            else
            {

                ConceptoPago cp = ConceptoPagoCAD.consultar(txtConsultar.Text.Trim());
                if (cp == null)
                {
                    MessageBox.Show("No existe la descripcion que esta solicitando");
                }
                else
                {
                    txtDescripcion.Text = cp.Descripcion;
                    txtIDCP.Text = cp.Id_pago.ToString();
                    CbEstado.Text = cp.Estado;
                }
            }
        }
    }
}
