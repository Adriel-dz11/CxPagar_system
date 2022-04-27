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
            txtUsername.MaxLength = 50;
            txtContrasena.PasswordChar = '*';
            txtContrasena.MaxLength = 950;
            this.AcceptButton = BtnIngresar;
        }

        private void BtnIngresar_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginController.Ingresar(this);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            loginController.Ingresar(this);
        }

        public TextBox GetUsernameField()
        {
            return txtUsername;
        }

        public TextBox GetPasswordField()
        {
            return txtContrasena;
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
