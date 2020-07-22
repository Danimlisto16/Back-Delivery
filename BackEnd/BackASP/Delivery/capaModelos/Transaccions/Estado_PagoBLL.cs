using capaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaModelos.Transaccions
{
    public class Estado_PagoBLL
    {
        public static List<ESTADO_PAGO> List()
        {
            DeliveryEntidades db = new DeliveryEntidades();
            return db.ESTADO_PAGO.ToList();
        }
    }
}
