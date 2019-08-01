using Domain.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public abstract class APIControllerBaseAuth : Controller
    {
        private readonly ISegurancaService _segurancaService;
        /// <summary>
        /// Construtor Opcional
        /// </summary>

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="segurancaService"></param>
        //public APIControllerBaseAuth(ISegurancaService segurancaService)
        //{
        //    _segurancaService = segurancaService;
        //}
        /// <summary>
        /// Validar Header
        /// </summary>
        /// <returns></returns>
        
     
    }
}
