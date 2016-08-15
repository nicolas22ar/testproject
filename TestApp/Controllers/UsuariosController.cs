using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.Models.Database;

namespace TestApp.Controllers
{
    public class UsuariosController : ApiController
    {
        private DbContext dbContext;

        public UsuariosController()
        {
            dbContext = new DbContext();
        }

        [HttpGet]
        public List<string> Get()
        {
            return dbContext.getUsuarios(); 
        }


    }
}
