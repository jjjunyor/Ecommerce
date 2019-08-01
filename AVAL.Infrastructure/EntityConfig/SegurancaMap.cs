using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVAL.Infrastructure.EntityConfig
{
     public class SegurancaMap : IEntityTypeConfiguration<Seguranca>
    {
        public void Configure(EntityTypeBuilder<Seguranca> builder)
        {
            builder.ToTable("tblSeguranca");
            builder.HasKey(t => t.idToken);
        }
    }
}
