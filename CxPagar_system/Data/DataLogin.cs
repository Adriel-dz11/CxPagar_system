using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CxPagar_system.Models;
using CxPagar_system.Controllers;
using CxPagar_system.Views;
using System.Data;
using System.Windows.Forms;
namespace CxPagar_system.Data
{
    internal class DataLogin
    {
        private DriverDb driver;
        private LoginController controller;

        public DataLogin(LoginController controller)
        {
            driver = DriverDb.GetInstance();
            this.controller = controller;
        }

        public void ValidateLoginData(LoginModel objLogin, Login loginForm)
        {
            try
            {
                string query = "SELECT username, password FROM Login " +
                               "WHERE username = '" + objLogin.Username + "' AND " + "password = '" + objLogin.Password + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, driver.Connect());
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    controller.HideCurrentFormAndShowMainForm(loginForm);
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginForm.GetUsernameField().Clear();
                    loginForm.GetPasswordField().Clear();
                    loginForm.GetUsernameField().Focus();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                driver.Disconnect();
            }
        }
    }
}
