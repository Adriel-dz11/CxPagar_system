using CxPagar_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxPagar_system.Data
{
    class ConceptoPagoCAD
    {
        public static bool Guardar(ConceptoPago e)
        {
            try
            {
                DriverDb db =  DriverDb.GetInstance();
                string sql = "insert into ConceptosDePago values ('" +e.Descripcion+ "','" + e.Estado + "');";
                SqlCommand comando = new SqlCommand(sql, db.Connect());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;

                db.Disconnect();

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                DriverDb db = DriverDb.GetInstance();
                string sql = " SELECT * FROM ConceptosDePago;";
                SqlCommand comando = new SqlCommand(sql, db.Connect());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr); 

                db.Disconnect();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static ConceptoPago consultar(string Descripcion)
        {
            try
            {
                DriverDb db = DriverDb.GetInstance();
                string sql = " SELECT * FROM ConceptosDePago WHERE descripcion = '"+ Descripcion + "';";
                SqlCommand comando = new SqlCommand(sql, db.Connect());
                SqlDataReader dr = comando.ExecuteReader();
                ConceptoPago cp = new ConceptoPago();
                if (dr.Read())
                {
                    cp.Descripcion = dr ["descripcion"].ToString();
                    cp.Id_pago = Convert.ToInt32(dr["id_pago"].ToString());
                    cp.Estado = dr["estado"].ToString();
                    db.Connect();
                    return cp;
                   
                }
                else
                {
                    db.Disconnect();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
