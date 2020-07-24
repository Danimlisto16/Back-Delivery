using capaModelos.Modelos;
using capaModelos.Transaccions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Delivery.Controllers
{
    //CORS
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class producto_categoriaController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                List<PRODUCTO_CATEGORIA> todos = Producto_CategoriaBLL.List();
                return Ok(todos);
            }
            catch (Exception ex)
            {
                return NotFound();
                throw ex;
            }
        }
    }
}
