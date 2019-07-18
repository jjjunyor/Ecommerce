using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Models;

namespace Domain.Interface.Services
{
    public interface IContaService
    {
        void Transferir(Tansferencia transferencia);
        IEnumerable<Conta> Consultar(string conta);
      

    }
}
