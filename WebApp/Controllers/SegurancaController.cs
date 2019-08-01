using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Interface.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Seguranca")]
    public class SegurancaController : Controller
    {
        private readonly ISegurancaService _segurancaService;

        public SegurancaController(ISegurancaService segurancaService)
        {
            _segurancaService = segurancaService;
        }
        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("GerarToken")]
        [DisableCors]
        public IActionResult GerarToken([FromBody]Seguranca seguranca)
        {
            try
            {

                _segurancaService.GerarToken(seguranca);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                var msg = string.Format("Falha na geração do Token - Msg: {0} - StackTrace:{1}", ex.Message, ex.StackTrace);
                EventLog.WriteEntry("Segurança", msg, EventLogEntryType.Error);
                return StatusCode(StatusCodes.Status500InternalServerError, msg);
            }
        }
    }

}