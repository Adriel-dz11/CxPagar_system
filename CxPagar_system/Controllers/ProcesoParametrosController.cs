using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxPagar_system.Models;
using CxPagar_system.Data;
using System.Windows.Forms;
using System.Data;

namespace CxPagar_system.Controllers
{
    internal class ProcesoParametrosController
    {
        ProcesoParametrosModel model;
        DataProcesoParametros data;


        public ProcesoParametrosController()
        {
            data = new DataProcesoParametros(this);
        }

        public void InsertarProcesoParametro(string Mes, string Anio, string CierreEjecutado)
        {
            model = new ProcesoParametrosModel(Mes, Anio, CierreEjecutado);

            if (model.MesDeProceso != null && model.MesDeProceso != "")
            {
                if (model.AnioDeProceso != null && model.AnioDeProceso != "")
                {
                    if (model.CierreEjecutado != null && model.CierreEjecutado != "")
                    {
                        data.Insertar(model);
                    }
                }
            } 
            else
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable ListarProcesoParametros()
        {
            return data.ListarProcesoParametros();
        }

        public DataTable ListarMeses()
        {
            return data.ListarMeses();
        }

        public DataTable ListarAnios()
        {
            return data.ListarAnios();
        }

        public DataTable ListarOpcionesDeCierre()
        {
            return data.ListarOpcionesDeCierre();
        }
    }
}
