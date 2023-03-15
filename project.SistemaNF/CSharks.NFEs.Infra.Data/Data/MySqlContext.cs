using Microsoft.EntityFrameworkCore;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Enums;
using CSharks.NFEs.Domain.Models.NF_UTILS;
using System.Data.Common;
using System.IO;

namespace CSharks.NFEs.Infra.Data.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var enterprise = new Enterprise
            {
                Id = Guid.NewGuid(),
                Name = "Csharks Developers LTDA",
                CpfCnpj = "12345678901234",
                City = "8453",
                Email = "csharkenterprise@hotmail.com"
            };


            modelBuilder.Entity<Enterprise>()
                .HasData(enterprise);

            modelBuilder.Entity<User>()
                .HasData(
                new { Id = Guid.NewGuid(), Name = "Desenvolvedor", Login = "dev", Password = "MTIz", Profile = TypeProfile.Admin,
                Email = "teste@hotmail.com" ,EnterpriseId = enterprise.Id
                }
            );


            modelBuilder.Entity<Client>()
                .HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    Name = "Patrick Weber",
                    CpfCnpj = "06262485902",
                    Address = "Leopoldo Holz",
                    Identifier = "3812817100220600010000000001",
                    Ie = "16",
                    Email = "patrick@gmail.com",
                    ResidentialNumber = "111",
                    Complement = "Rua",
                    Enrollment = "F"
                }
            );

            modelBuilder.Entity<Service>()
                .HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    tributa_municipio_prestador = "S",
                    codigo_local_prestacao_servico = "8357",
                    codigo_item_lista_servico = "702",
                    descritivo = "Teste",
                    aliquota_item_lista_servico = "5",
                    situacao_tributaria = "000",
                    valor_tributavel = "0"
                },
                new
                {
                    Id = Guid.NewGuid(),
                    tributa_municipio_prestador = "S",
                    codigo_local_prestacao_servico = "8357",
                    codigo_item_lista_servico = "0106",
                    descritivo = "Assessoria e consultoria em informática.",
                    aliquota_item_lista_servico = "2",
                    situacao_tributaria = "000",
                    valor_tributavel = "0"
                }
            );


            base.OnModelCreating(modelBuilder);
        }

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }

        public DbSet<TOM> Cities { get; set; }
        public DbSet<ISQN> Isqns { get ; set; }




        #endregion
    }
}
