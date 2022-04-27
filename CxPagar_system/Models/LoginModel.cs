using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxPagar_system.Models
{
    internal class LoginModel
    {
        private int id_user;
        private string username;
        private string password;
        private string privilegios;

        public LoginModel() { }

        public LoginModel(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public LoginModel(int id_user, string username, string password, string privilegios)
        {
            this.id_user = id_user;
            this.username = username;
            this.password = password;
            this.privilegios = privilegios;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
