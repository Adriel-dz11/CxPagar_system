using CxPagar_system.Controllers;
using CxPagar_system.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPagar_system.Views.Forms.Process
{
    public partial class Proc_Cierre : Form
    {
        private DriverDb driver;

      
        public Proc_Cierre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Datos WHERE txtbuscar = idproveedor";
                int idproveedor;
                float balance;
                DateTime fechadoc;
                float monto;
                float balanceactual;


                idproveedor = int.Parse(txtproveedor.Text);
                balance = float.Parse(txtbalanceinicial.Text);
                fechadoc = DateTime.Parse(txtfecha.Text);
                monto = float.Parse(txtmonto.Text);
                balanceactual = float.Parse(txtbalanceinicial.Text) - float.Parse(txtmonto.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(query, driver.Connect());
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                foreach (DataRow dato in dtable.Rows)
                    {
                       var idprov = dato["id_proveedor"];
                       var bal = dato["balance"];
                       var fecha = dato["fecha_documento"];
                       var mont = dato["monto"];             
                    }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                driver.Disconnect();
            }
        }
    }
}
