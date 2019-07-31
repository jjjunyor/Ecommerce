using AVAL.Infrastructure.Data;
using Domain.Entity;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVAL.Infrastructure.Repository
{
    public class ProdutoRepository : EFRepository<Produto>, IProdutoRepository
    {
        private readonly AvalContext avalContext;
        public ProdutoRepository(AvalContext aval) : base(aval)
        {
            this.avalContext = aval;
        }
    }
}
