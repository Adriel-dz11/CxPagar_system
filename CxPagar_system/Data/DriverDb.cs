using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CxPagar_system.Data
{
    internal class DriverDb
    {
        private static DriverDb Instance;
        SqlConnection _connection;

        private DriverDb() { }

        public SqlConnection Connect()
        {
            _connection = new SqlConnection(@"Data Source=ADRIAN-LENOVO\SQLSERVERW;Initial Catalog=cuentasxpagar;Integrated Security=True");
            return _connection;
        }

        public void Disconnect()
        {
            _connection.Close();
        }

        public static DriverDb GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DriverDb();
                return Instance;
            } else { return Instance; }
        }
    }
}
