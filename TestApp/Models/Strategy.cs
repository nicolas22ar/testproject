using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models.Interfaces;

namespace TestApp.Models
{
    public class Strategy
    {
        private static Dictionary<string, IMoneda> _strategies = new Dictionary<string, IMoneda>();

        public Strategy()
        {
            if (!_strategies.Any())
            {
                _strategies.Add(nameof(Dolar).ToUpper(), new Dolar());
                _strategies.Add(nameof(Peso).ToUpper(), new Peso());
                _strategies.Add(nameof(Real).ToUpper(), new Real());
            }
        }

        public async Task<string> DoAlgorithm(string moneda)
        {
            return await _strategies[moneda.ToUpper()].DarCotizacion();
        }
    }

}