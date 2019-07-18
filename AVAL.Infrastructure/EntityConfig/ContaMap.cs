using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Models;

namespace AVAL.Infrastructure.EntityConfig
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("tblConta");

            builder.HasKey(t => t.idConta);

            //builder.Entity<TransfHist>().ToTable("tblTrasnfHist");
            //builder.HasKey(t => t.Id);
        }
    }
}
