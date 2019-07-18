using Domain.Entity;
using Domain.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;



namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Conta")]
    public class ContaController : Controller
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {

            _contaService = contaService;
        }
        /// <summary>
        ///  Faz a transferencia de uma conta para outra.
        /// Exemplo: {
        /// "contaOrigem": "889988",
        /// "contaDestino": "233349499",
        /// "cpfDestino": "333433334",
        /// "tipoTransferencia": "doc",
        ///"valor": 35.00
        ///}
        /// </summary>
        /// <param name="obj">Json com informação da trensferencia</param>
        /// <returns></returns>
        [Route("Transferir")]
        [HttpPost]
        public IActionResult Transferir([FromBody]Tansferencia obj)
        {
            try
            {
                _contaService.Transferir(obj);
                var msg = string.Format("Banco Aval - Traferência Feita com sucesso.");
                var json = new { ContaOrigem = obj.ContaOrigem, msg = "Tranferência feita com sucesso!" };
                return StatusCode(StatusCodes.Status201Created, json);
            }
            catch (Exception ex)
            {
                var msg = string.Format("Banco Aval - Falha na transferencia - Msg: {0} - StackTrace:{1}", ex.Message, ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, msg);
            }
        }
        /// <summary>
        /// Verifica o Saldo da Conta
        /// </summary>
        /// <param name="numeroConta"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Saldo/{numeroConta}")]
        public IActionResult Saldo(string numeroConta)
        {
            try
            {
                var conta = _contaService.Consultar(numeroConta).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, conta);
            }
            catch (Exception ex)
            {
                var msg = string.Format("Banco Aval - Falha na Consulta do Saldo - Msg: {0} - StackTrace:{1}", ex.Message, ex.StackTrace);
                EventLog.WriteEntry("Banco Aval", msg, EventLogEntryType.Error);
                return StatusCode(StatusCodes.Status500InternalServerError, msg);
            }
        }
    }
}