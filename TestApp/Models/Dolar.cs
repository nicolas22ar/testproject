using System.Threading.Tasks;
using TestApp.Models.Interfaces;

namespace TestApp.Models
{
    public class Dolar : IMoneda
    {
        async Task<string> IMoneda.DarCotizacion()
        {
            var common = new Common.Common();
            var response = await common.SendGetRequestAsync("Dolar");
            return response;
        }
        
    }
}