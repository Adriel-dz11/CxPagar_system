using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPagar_system.Views.Forms.Mant;
using CxPagar_system.Views.Forms.Process;
using CxPagar_system.Views.Forms.Cons;


namespace CxPagar_system.Views
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            new Docs_x_pagar().ShowDialog(); 
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            new Mant_Gestion_Pago().ShowDialog();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            new Mant_Concepto_Pago().ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            new Mant_Proveedores().ShowDialog();
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            new Mant_Usuarios().ShowDialog();
        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            new Proc_Cierre().ShowDialog();
        }

        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            new Proc_Parametros().ShowDialog();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Proveedores().ShowDialog();
        }

        private void consultaDeCierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Cierres().ShowDialog();

        }

        private void consultaDeParámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Parametros().ShowDialog();
        }

        private void consultaDeConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Conceptos().ShowDialog();
        }

        private void consultaDeFracturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Facturas().ShowDialog();
        }

        private void consultaDePendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Pendientes().ShowDialog(); 
        }

        private void consultaDeDocsXPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Docs_x_Pagar().ShowDialog();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cons_Usuarios().ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            new Mant_Proveedores().ShowDialog();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            new Proc_Cierre().ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            new Proc_Parametros().ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            new Docs_x_pagar().ShowDialog();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            new Mant_Concepto_Pago().ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            new Cons_Pendientes().ShowDialog();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            new Mant_Usuarios().ShowDialog();
        }

        private void iconDropDownButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = Login.GetInstance();
            loginForm.GetUsernameField().Text = "";
            loginForm.GetPasswordField().Text = "";
            loginForm.GetUsernameField().Focus();
            loginForm.Show();
        }
    }
}
