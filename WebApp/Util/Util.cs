using Domain.Interface.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Util
    {
        public static bool ValidarToken(ISegurancaService _segurancaService, HttpRequest httpRequest)
        {
            return (httpRequest.Headers != null && _segurancaService.ValidarToken(httpRequest.Headers["app_token"]));

        }
    }
}
