﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TestApp.Models.Interfaces
{
    public interface IMoneda
    {
        Task<string> DarCotizacion();
    }
}