using AVAL.Infrastructure.Data;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Models;

namespace AVAL.Infrastructure.Repository
{
    public class ContaRepository : EFRepository<Conta> ,IContaRepository
    {
        private readonly AvalContext avalContext;
        public ContaRepository(AvalContext aval):base(aval)
        {
            this.avalContext = aval;
        }

        public void Credito(Conta conta)
        {
            
           // this.Atualizar(Con)
        }

        public void Debido(Conta conta)
        {
            throw new NotImplementedException();
        }

        public void FazerTransferencia(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Conta Saldo(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
