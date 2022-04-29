using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPagar_system.Controllers;

namespace CxPagar_system.Views.Forms.Process
{
    public partial class Proc_Parametros : Form
    {
        ProcesoParametrosController controller;

        public Proc_Parametros()
        {
            InitializeComponent();
            controller = new ProcesoParametrosController();
            ListarDatosAIntroducir();
            DeshabilitarCamposALlenar();
            dataGridProcesoParametros.DataSource = controller.ListarProcesoParametros();
            var dataGridWidth = dataGridProcesoParametros.Width;
            dataGridProcesoParametros.Columns[0].Width = dataGridWidth / 4;
            dataGridProcesoParametros.Columns[1].Width = dataGridWidth / 4;
            dataGridProcesoParametros.Columns[2].Width = dataGridWidth / 4;
            dataGridProcesoParametros.Columns[3].Width = dataGridWidth / 4;
        }

        private void ListarDatosAIntroducir()
        {
            DataTable Meses = controller.ListarMeses();
            DataTable Anios = controller.ListarAnios();
            DataTable OpcionesCierre = controller.ListarOpcionesDeCierre();
            cmbMes.DataSource = Meses;
            cmbAnio.DataSource = Anios;
            cmbCierre.DataSource = OpcionesCierre;
            cmbMes.DisplayMember = "nombre";
            cmbMes.ValueMember = "id";
            cmbAnio.DisplayMember = "nombre";
            cmbAnio.ValueMember = "id";
            cmbCierre.DisplayMember = "opcion";
            cmbCierre.ValueMember = "id";
        }

        private void HabilitarCamposALlenar()
        {
            cmbMes.Enabled = true;
            cmbAnio.Enabled = true;
            cmbCierre.Enabled = true;
        }

        private void DeshabilitarCamposALlenar()
        {
            cmbMes.Enabled = false;
            cmbAnio.Enabled = false;
            cmbCierre.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarCamposALlenar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("¿Seguro que quieres guardar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string Mes = cmbMes.Text;
                string Anio = cmbAnio.Text;
                string CierreEjecutado = cmbCierre.Text;
                controller.InsertarProcesoParametro(Mes, Anio, CierreEjecutado);
                ListarDatosAIntroducir();
                DeshabilitarCamposALlenar();
                dataGridProcesoParametros.DataSource = controller.ListarProcesoParametros();
            } else
            {
                ListarDatosAIntroducir();
                DeshabilitarCamposALlenar();
                dataGridProcesoParametros.DataSource = controller.ListarProcesoParametros();
            }
        }
    }
}
