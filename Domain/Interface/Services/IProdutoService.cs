using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.Services
{
    public interface IProdutoService
    {
        IEnumerable<Produto> Listar();
    }
}
