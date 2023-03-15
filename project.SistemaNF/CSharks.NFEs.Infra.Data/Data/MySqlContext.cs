using Microsoft.EntityFrameworkCore;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Enums;
using CSharks.NFEs.Domain.Models.NF_UTILS;
using System.Data.Common;
using System.IO;
using System.Runtime.ConstrainedExecution;

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
                CpfCnpj = "25825307000152",
                City = "8357",
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
                    Enrollment = "F",
                    InformedAdress = "1",
                    CpfCnpj = "43975686855",
                    Name = "Carlos Eduardo dos Santos Junior",
                    Ie = "16",
                    Address = "Rua Gustavo Zimmermann",
                    District = "Itoupava Central",
                    City = "8357",
                    ResidentialNumber = "2421",
                    Email = "juninhocb@hotmail.com",
                    CEP = "89062100 "
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
                    descritivo = "Assessoria e consultoria em informática.",
                    aliquota_item_lista_servico = "5",
                    situacao_tributaria = "0",
                    valor_tributavel = "1"
                }
            );

            modelBuilder.Entity<EmitedNF>()
                .HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    EmitDate = "23-03-15-19-29",
                    ServiceName = "Programação",
                    ClientName = "PATRICK WEBER",
                    ValueNF = "35",
                    Situation = "Success",
                    LinkPDF = "https://homologacao.atende.net//homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/atende.php?rot=1&aca=119&ajax=t&processo=viewFile&ajaxPrevent=1678894724274&file=3BEC12ECA3FEFF0F56229CD1C8598E57ABEC522A&sistema=wne&classe=upload_nota_fiscal_eletronica",
                    NoNfse = "74",
                    CodVerify = "8357738593202582530720240315032023189724"
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

        public DbSet<EmitedNF> Emiteds { get; set; }




        #endregion
    }
}
