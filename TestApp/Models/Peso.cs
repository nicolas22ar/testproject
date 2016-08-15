using System;
using System.Threading.Tasks;
using TestApp.Models.Interfaces;

namespace TestApp.Models
{
    public class Peso : IMoneda
    {
        Task<string> IMoneda.DarCotizacion()
        {
            throw new Exception("error 401 no authorized de http");
        }
    }
}