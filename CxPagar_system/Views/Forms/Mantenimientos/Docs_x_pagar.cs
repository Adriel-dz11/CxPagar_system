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
    public partial class Docs_x_pagar : Form
    {
        public Docs_x_pagar()
        {
            InitializeComponent();
            tBox_ID_Doc.Enabled = false;
            tBox_Id_Proveedor.Enabled = false;
            tBox_Monto.Enabled = false;
            tBox_NoFactura.Enabled = false;
            Dtp_FechaVencimiento.Enabled = false;
            Dtp_FechaDoc.Enabled = false;
            Dtp_FechaRegistro.Enabled = false;
            cmBox_Estado.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            tBox_Id_Proveedor.Enabled = true;
            tBox_Monto.Enabled = true;
            tBox_NoFactura.Enabled = true;
            Dtp_FechaVencimiento.Enabled = true;
            Dtp_FechaDoc.Enabled = true;
            Dtp_FechaRegistro.Enabled = true;
            cmBox_Estado.Enabled = true;

        }
    }
}
