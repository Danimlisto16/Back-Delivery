using capaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaModelos.Transaccions
{
    public class Estado_EnvioBLL
    {
        public static List<ESTADO_ENVIO> List()
        {
            DeliveryEntidades db = new DeliveryEntidades();
            return db.ESTADO_ENVIO.ToList();
        }
    }
}
