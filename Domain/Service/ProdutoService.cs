using Domain.Entity;
using Domain.Interface.Repository;
using Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service
{
    public class ProdutoService:IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }
        public IEnumerable<Produto> Listar()
        {
                  

            return _produtoRepository.ObterTodos();
        }
    }
}
