﻿using capaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using capaModelos.Transaccions;
using System.Web.Http.Cors;

namespace Delivery.Controllers
{
    //CORS
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class clienteController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                List<CLIENTE> todos = ClienteBLL.List();
                return Ok(todos);
            }
            catch (Exception ex)
            {
                return NotFound();
                throw ex;
            }
        }



        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(ClienteBLL.Get(id));
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }



        
        public IHttpActionResult Post(CLIENTE a)
        {
            try
            {
                ClienteBLL.Create(a);
                return Content(HttpStatusCode.Created, "Message: \n\trealizado correctamente!" + "\nstatus: \n\t 200");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, "Solicitud no procesada, Agregado con éxito");
            }
        }

        
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ClienteBLL.Delete(id);
                return Content(HttpStatusCode.OK, "Borrado con éxito");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, "Solicitud no procesada , No se pudo eliminar");
            }
        }



        public IHttpActionResult Put(CLIENTE cliente)
        {
            if (ClienteBLL.Update(cliente))
            {
                return Content(HttpStatusCode.OK, "Cliente actualizado");
            }
            return Content(HttpStatusCode.InternalServerError, "Error interno del servidor");
        }
    }
}
