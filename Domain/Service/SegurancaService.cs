using Domain.Entity;
using Domain.Interface.Repository;
using Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Service
{
    public class SegurancaService : ISegurancaService
    {
        private readonly ISegurancaRepository _segurancaServiceRepository;
        public SegurancaService(ISegurancaRepository segurancaRepository)
        {
            this._segurancaServiceRepository = segurancaRepository;
        }

        public void GerarToken(Seguranca token)
        {
            _segurancaServiceRepository.Adicionar(new Seguranca() {
                DataGeracao = DateTime.Now,
                Token = token.Token
            });
        }
        public void ExcluirToken(Seguranca token)
        {
            _segurancaServiceRepository.Remover(token);
        }
        public bool ValidarToken(string token)
        {
           var obj = _segurancaServiceRepository.Buscar(x=>x.Token == token).FirstOrDefault();
            if (obj != null)
            {
                ExcluirToken(obj);
                return true;
            }else
            {
                return false;
            }

        }
        
    }
}
