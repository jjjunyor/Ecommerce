using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Models;

namespace Domain.Interface.Repository
{
   public interface IContaRepository:IRepository<Conta>
    {
     
        Conta Saldo(Conta conta);
        void Debido(Conta conta);
        void Credito(Conta conta);
    }
}
