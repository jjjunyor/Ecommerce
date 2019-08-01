using AVAL.Infrastructure.Data;
using Domain.Entity;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVAL.Infrastructure.Repository
{

    public class SegurancaRepository : EFRepository<Seguranca>, ISegurancaRepository
    {
        private readonly AvalContext avalContext;
        public SegurancaRepository(AvalContext aval) : base(aval)
        {
            this.avalContext = aval;
        }
    }
}
