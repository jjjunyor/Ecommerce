using AVAL.Infrastructure.EntityConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Models;


namespace AVAL.Infrastructure.Data
{
   public class AvalContext: IdentityDbContext
    {
        public AvalContext(DbContextOptions<AvalContext> options):base(options)
        {

        }
        
        /// <summary>
        /// Responsavel pela configuração do entityFrameWork
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new SegurancaMap());

            base.OnModelCreating(modelBuilder);

        }
    }
}
