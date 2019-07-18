using Domain.Entity;
using Domain.Interface.Repository;
using Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Models;

namespace Domain.Service
{
    /// <summary>
    /// Classe  Responsavel para chamar repository e aplicar as regras de negócio.
    /// </summary>
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        public ContaService(IContaRepository contaRepository)
        {
            this._contaRepository = contaRepository;
        }

        public IEnumerable<Conta> Consultar(string numeroConta)
        {
            if (string.IsNullOrEmpty(numeroConta))
                throw new Exception("Número da Conta deve ser preenchido");

            return _contaRepository.Buscar(x => x.NumeroConta == numeroConta);
        }

        public void Transferir(Tansferencia transferencia)
        {
            //TODO:Adicionar Regra de negocio aqui.
            var ContaOrigemExistente = _contaRepository.Buscar(x => x.NumeroConta == transferencia.ContaOrigem).FirstOrDefault();
            var ContaDestinoExistente = _contaRepository.Buscar(x => x.NumeroConta == transferencia.ContaDestino).FirstOrDefault();
           

            if (ContaOrigemExistente ==null)
                throw new Exception("Conta Origem não encontrada!");

            if (ContaOrigemExistente ==null)
                throw new Exception("Conta Destino não encontrada!");

            if ((ContaOrigemExistente.Saldo - transferencia.Valor) < 0)
                throw new Exception("Conta Origem não tem Saldo para efetuar esta operação!");

            ContaOrigemExistente.Saldo = (ContaOrigemExistente.Saldo - transferencia.Valor);
            _contaRepository.Atualizar(ContaOrigemExistente);

            ContaDestinoExistente.Saldo = (ContaDestinoExistente.Saldo + transferencia.Valor);
            _contaRepository.Atualizar(ContaDestinoExistente);

                       
          
        }

       
    }
}
