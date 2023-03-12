using Microsoft.EntityFrameworkCore;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF;
using CSharks.NFEs.Domain.Enums;

namespace CSharks.NFEs.Infra.Data.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>()
                .HasData(
                new { Id = Guid.NewGuid(), Name = "Desenvolvedor", Login = "dev", Password = "MTIz", Profile = TypeProfile.Admin }
            );

            modelBuilder.Entity<NF>()
                .HasData(
                new { Id = Guid.NewGuid(), valor_total = "1,00" }
            );

            modelBuilder.Entity<Prestador>()
                .HasData(
                new { Id = Guid.NewGuid(), cpfcnpj = "00000000000000", cidade = "8357" }
            );

            modelBuilder.Entity<Tomador>()
                .HasData(
                new { Id = Guid.NewGuid(), tipo = "J", endereco_informado = "", identificador = "", 
                    cpfcnpj = "06262485902", nome_razao_social = "", ie = "", logradouro = "",
                    email = "", numero_residencia = "", complemento = ""
                }
            );

            modelBuilder.Entity<Lista>()
                .HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    tributa_municipio_prestador = "S",
                    codigo_local_prestacao_servico = "8357",
                    codigo_item_lista_servico = "702",
                    descritivo = "Teste",
                    aliquota_item_lista_servico = "5",
                    situacao_tributaria = "0",
                    valor_tributavel = "0"
                }
            );


            base.OnModelCreating(modelBuilder);
        }

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }

        //NFE crud
        public DbSet<Lista> Lists { get; set; }
        public DbSet<Pesquisa> Pesquisas { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<NF> NFS { get; set; }
        public DbSet<Tomador> Tomadores { get; set; }



        #endregion
    }
}
