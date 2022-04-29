using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxPagar_system.Models
{
     class ConceptoPago
    {
       private int id_pago;
       private string descripcion;
       private string estado;

        public ConceptoPago()
        {
            this.id_pago = 0;
            this.descripcion = "";
            this.estado = "";
        }

        public int Id_pago { get => id_pago; set => id_pago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
