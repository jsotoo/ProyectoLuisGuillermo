using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utilities;

namespace WebApp.Controllers
{
    public class UsuarioController : ApiController
    {
        BUsers BUsers;
        public UsuarioController()
        {
            BUsers = new BUsers();
        }

        // GET api/values
        public IEnumerable<UsuarioVM> Get(UsuarioVM user)
        {
            List<UsuarioVM> usuarios = BUsers.ObtenerTodos(user);
            return usuarios;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
