using System.Collections.Generic;
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

        // GET MyResftfullApp/Usuarios
        [HttpGet]
        public List<string> Get()
        {
            return dbContext.getUsuarios(); 
        }


    }
}
