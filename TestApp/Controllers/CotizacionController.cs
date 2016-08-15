using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System;
using TestApp.Models;
using System.Collections.Generic;

namespace TestApp.Controllers
{
    public class CotizacionController : ApiController
    {
        private ContextStrategy context => new ContextStrategy();

        // GET MyResftfullApp/Cotizacion
        [HttpGet]
        public async Task<string> Get(string moneda)
        {
            return await context.DoAlgorithm(moneda);
        }

    }
}
