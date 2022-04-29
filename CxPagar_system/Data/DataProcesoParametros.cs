using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxPagar_system.Controllers;
using CxPagar_system.Models;
using CxPagar_system.Data;
using System.Windows.Forms;

namespace CxPagar_system.Data
{
    internal class DataProcesoParametros
    {
        private DriverDb driver;
        private SqlCommand command;
        private SqlDataReader reader;
        private ProcesoParametrosController controller;

        public DataProcesoParametros(ProcesoParametrosController controller)
        {
            driver = DriverDb.GetInstance();
            command = new SqlCommand();
            this.controller = controller;
        }

        public void Insertar(ProcesoParametrosModel model)
        {
            var con = driver.Connect();
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandText = "INSERT INTO Parametros(mes_de_proceso, anio_de_proceso, cierre_ejecutado) " +
                                      "VALUES('" + model.MesDeProceso + "', '" + model.AnioDeProceso + "', '" + model.CierreEjecutado + "')";

                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ListarMeses()
        {
            DataTable table = new DataTable();

            var con = driver.Connect();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT id, nombre " +
                                  "FROM Meses";
            reader = command.ExecuteReader();
            table.Load(reader);
            reader.Close();
            driver.Disconnect();
            con.Close();
            return table;
        }

        public DataTable ListarAnios()
        {
            DataTable table = new DataTable();

            var con = driver.Connect();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT id, nombre " +
                                  "FROM Anios";
            reader = command.ExecuteReader();
            table.Load(reader);
            reader.Close();
            driver.Disconnect();
            con.Close();
            return table;
        }

        public DataTable ListarOpcionesDeCierre()
        {
            DataTable table = new DataTable();

            var con = driver.Connect();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT id, opcion " +
                                  "FROM CierreEjecutado";
            reader = command.ExecuteReader();
            table.Load(reader);
            reader.Close();
            driver.Disconnect();
            con.Close();
            return table;
        }
    }
}
