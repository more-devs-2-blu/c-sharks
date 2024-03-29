﻿// <auto-generated />
using System;
using CSharks.NFEs.Infra.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20230315163648_UPDATE12")]
    partial class UPDATE12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Enrollment")
                        .HasColumnType("longtext");

                    b.Property<string>("Ie")
                        .HasColumnType("longtext");

                    b.Property<string>("InformedAdress")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ResidentialNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ac04250-fb25-4a99-a4d5-ab7ab070f78d"),
                            Address = "Rua Gustavo Zimmermann",
                            CEP = "89062100 ",
                            City = "8357",
                            CpfCnpj = "43975686855",
                            District = "Itoupava Central",
                            Email = "juninhocb@hotmail.com",
                            Enrollment = "F",
                            Ie = "16",
                            InformedAdress = "1",
                            Name = "Carlos Eduardo dos Santos Junior",
                            ResidentialNumber = "2421"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.EmitedNF", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodVerify")
                        .HasColumnType("longtext");

                    b.Property<string>("EmitDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LinkPDF")
                        .HasColumnType("longtext");

                    b.Property<string>("NoNfse")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Situation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ValueNF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Emiteds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f02452a-e9e7-4d65-abf8-41e09a1d2863"),
                            ClientName = "PATRICK WEBER",
                            CodVerify = "8357738593202582530720240315032023189724",
                            EmitDate = "23-03-15-19-29",
                            LinkPDF = "https://homologacao.atende.net//homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/atende.php?rot=1&aca=119&ajax=t&processo=viewFile&ajaxPrevent=1678894724274&file=3BEC12ECA3FEFF0F56229CD1C8598E57ABEC522A&sistema=wne&classe=upload_nota_fiscal_eletronica",
                            NoNfse = "74",
                            ServiceName = "Programação",
                            Situation = "Success",
                            ValueNF = "35"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Enterprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eedadba9-5ced-491e-af02-0e29daea5f70"),
                            City = "8357",
                            CpfCnpj = "25825307000152",
                            Email = "csharkenterprise@hotmail.com",
                            Name = "Csharks Developers LTDA"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.NF_UTILS.ISQN", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Aliquot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Isqns");
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("aliquota_item_lista_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_item_lista_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_local_prestacao_servico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("descritivo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("situacao_tributaria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tributa_municipio_prestador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("valor_tributavel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9333e8c7-4767-46a2-b9e2-dd898a4f2eb3"),
                            aliquota_item_lista_servico = "5",
                            codigo_item_lista_servico = "702",
                            codigo_local_prestacao_servico = "8357",
                            descritivo = "Assessoria e consultoria em informática.",
                            situacao_tributaria = "0",
                            tributa_municipio_prestador = "S",
                            valor_tributavel = "1"
                        },
                        new
                        {
                            Id = new Guid("53fa0b05-72c4-477d-b0e1-d817b9b5dbc3"),
                            aliquota_item_lista_servico = "2",
                            codigo_item_lista_servico = "0106",
                            codigo_local_prestacao_servico = "8357",
                            descritivo = "Assessoria e consultoria em informática.",
                            situacao_tributaria = "0",
                            tributa_municipio_prestador = "S",
                            valor_tributavel = "1"
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.TOM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("EnterpriseId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(55)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0cfa54b6-584f-43c4-b8b3-77a769abe3db"),
                            Email = "teste@hotmail.com",
                            EnterpriseId = new Guid("eedadba9-5ced-491e-af02-0e29daea5f70"),
                            Login = "dev",
                            Name = "Desenvolvedor",
                            Password = "MTIz",
                            Profile = 1
                        });
                });

            modelBuilder.Entity("CSharks.NFEs.Domain.Models.User", b =>
                {
                    b.HasOne("CSharks.NFEs.Domain.Models.Enterprise", "Enterprise")
                        .WithMany()
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");
                });
#pragma warning restore 612, 618
        }
    }
}
