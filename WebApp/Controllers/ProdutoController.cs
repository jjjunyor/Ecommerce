using Domain.Interface.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/produto")]
  //  [EnableCors("AllowSpecificOrigin")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ISegurancaService _segurancaService;

        public ProdutoController(IProdutoService produtoService, ISegurancaService segurancaService)
        {
            _produtoService = produtoService;
            _segurancaService = segurancaService;


        }
   
        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IActionResult Lista()
        {
            try
            {
                //TODO: habilitar validação do token
                if (!Util.ValidarToken(_segurancaService, Request))
                    return StatusCode(StatusCodes.Status203NonAuthoritative);

                var produtos = _produtoService.Listar();
                return StatusCode(StatusCodes.Status200OK, produtos);
            }
            catch (Exception ex)
            {
                var msg = string.Format("Falha na Consulta dos produtos - Msg: {0} - StackTrace:{1}", ex.Message, ex.StackTrace);
                EventLog.WriteEntry("Banco Aval", msg, EventLogEntryType.Error);
                return StatusCode(StatusCodes.Status500InternalServerError, msg);
            }
        }
    }
}