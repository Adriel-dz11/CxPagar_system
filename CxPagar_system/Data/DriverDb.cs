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
        private SqlConnection _connection;
        private string EnvVariable;

        private DriverDb() { }

        public SqlConnection Connect()
        {
            EnvVariable = Environment.GetEnvironmentVariable("SQLSERVER_CONNECTIONSTRING");
            _connection = new SqlConnection(EnvVariable);
            _connection.Open();
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
