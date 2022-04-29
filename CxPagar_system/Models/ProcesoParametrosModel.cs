using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxPagar_system.Models
{
    internal class ProcesoParametrosModel
    {
        private int id_parametro;
        private string mes_de_proceso;
        private string anio_de_proceso;
        private string cierre_ejecutado;

        public ProcesoParametrosModel() { }

        public ProcesoParametrosModel(string mes_de_proceso,
                                      string anio_de_proceso,
                                      string cierre_ejecutado)
        {
            MesDeProceso = mes_de_proceso;
            AnioDeProceso = anio_de_proceso;
            CierreEjecutado = cierre_ejecutado;
        }

        public ProcesoParametrosModel(int id_parametro, 
                                      string mes_de_proceso, 
                                      string anio_de_proceso, 
                                      string cierre_ejecutado)
        {
            IdParametro = id_parametro;
            MesDeProceso = mes_de_proceso;
            AnioDeProceso= anio_de_proceso;
            CierreEjecutado = cierre_ejecutado;
        }

        public int IdParametro
        {
            get { return id_parametro; }
            set { id_parametro = value; }
        }

        public string MesDeProceso
        {
            get { return mes_de_proceso; }
            set { mes_de_proceso = value; }
        }

        public string AnioDeProceso
        {
            get { return anio_de_proceso; }
            set { anio_de_proceso= value; }
        }

        public string CierreEjecutado
        {
            get { return cierre_ejecutado; }
            set { cierre_ejecutado = value; }
        }
    }
}
