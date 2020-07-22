using capaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaModelos.Transaccions
{
    public class Producto_CategoriaBLL
    {
        public static List<PRODUCTO_CATEGORIA> List()
        {
            DeliveryEntidades db = new DeliveryEntidades();
            return db.PRODUCTO_CATEGORIA.ToList();
        }
    }
}
