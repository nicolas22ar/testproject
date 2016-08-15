using System.Web.Http;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class CotizacionController : ApiController
    {
        private Strategy strategy => new Strategy();

        // GET MyResftfullApp/Cotizacion
        [HttpGet]
        public async Task<string> Get(string moneda)
        {
            return await strategy.DoAlgorithm(moneda);
        }

    }
}
