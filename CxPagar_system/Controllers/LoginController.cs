using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CxPagar_system.Views;
using CxPagar_system.Models;
using CxPagar_system.Data;

namespace CxPagar_system.Controllers
{
    internal class LoginController
    {
        DataLogin dataLogin;

        public LoginController() {
            dataLogin = new DataLogin(this);
        }

        public void Ingresar(object sender, EventArgs e, Login loginForm)
        {
            string username = loginForm.getUsernameFieldValue();
            string password = loginForm.getPasswordFieldValue();
            LoginModel model = new LoginModel(username, password);

            dataLogin.ValidateLoginData(model, loginForm);
        }

        public void HideCurrentFormAndShowMainForm(Login loginForm)
        {
            Inicio vtnInicio = new Inicio();
            vtnInicio.Show();
            loginForm.Hide();
        }
    }
}
