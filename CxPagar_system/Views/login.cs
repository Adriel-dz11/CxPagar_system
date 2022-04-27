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


namespace CxPagar_system.Views
{
    public partial class Login : Form
    {
        LoginController loginController = new LoginController();

        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            loginController.Ingresar(sender, e, this);
        }

        public void setUsernameFieldValue(String username)
        {
            txtUsername.Text = username;
        }

        public string getUsernameFieldValue()
        {
            return txtUsername.Text;
        }

        public void setPasswordFieldValue(String password)
        {
            txtContrasena.Text = password;
        }

        public string getPasswordFieldValue()
        {
            return txtContrasena.Text;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("¿Seguro que quieres salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            } else
            {
                this.Show();
            }
        }
    }
}
