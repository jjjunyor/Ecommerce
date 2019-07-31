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
        public DbSet <Conta> contas { get; set; }
        /// <summary>
        /// Responsavel pela configuração do entityFrameWork
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ContaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);

            //  base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Conta>().ToTable("tblConta");

            //modelBuilder.Entity<Conta>().HasKey(t => t.Id);

            //modelBuilder.Entity<TransfHist>().ToTable("tblTrasnfHist");
            //modelBuilder.Entity<Conta>().HasKey(t => t.Id);
        }
    }
}
