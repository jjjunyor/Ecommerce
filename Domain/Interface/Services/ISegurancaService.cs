using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.Services
{
    public interface ISegurancaService
    {
        void  GerarToken(Seguranca token);
        void ExcluirToken(Seguranca token);
        bool ValidarToken(string token);
    }
}
