using CancerDeMama.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CancerDeMama.Infra.Data.Contexts
{
    public class CancerDeMamaContext : DbContext
    {
        public CancerDeMamaContext(DbContextOptions<CancerDeMamaContext> options) 
            : base(options)
        {
        }

        public DbSet<RegiaoEntity> Regiao { get; set; }
        public DbSet<IncidenciaExameEntity> IncidenciaExame { get; set; }
        public DbSet<FaixaEtariaEntity> FaixaEtaria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Mapeando tabela Incidencia exame
            modelBuilder.Entity<IncidenciaExameEntity>().ToTable("INCIDENCIA_EXAME");
            modelBuilder.Entity<IncidenciaExameEntity>().Property(P => P.FaixaEtariaId).HasColumnName("FAIXA_ETARIA_ID");
            modelBuilder.Entity<IncidenciaExameEntity>().Property(P => P.RegiaoId).HasColumnName("REGIAO_ID");
            modelBuilder.Entity<IncidenciaExameEntity>().Property(P => P.QuantExames).HasColumnName("QUANT_EXAMES");
            #endregion

            #region Mapeando tabela Faixa etaria
            modelBuilder.Entity<FaixaEtariaEntity>().ToTable("FAIXA_ETARIA");
            modelBuilder.Entity<FaixaEtariaEntity>().Property(p => p.FaixaInicial).HasColumnName("FAIXA_INICIAL");
            modelBuilder.Entity<FaixaEtariaEntity>().Property(p => p.FaixaFinal).HasColumnName("FAIXA_FINAL");
            #endregion

        }
    }
}
