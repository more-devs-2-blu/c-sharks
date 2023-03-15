
﻿using CSharks.NFEs.Domain.Models;
using System.Xml.Serialization;

namespace CSharks.NFEs.Domain.DTOs

{
    [XmlRoot("nfse")]
    public class NFEDTO
    {
        [XmlElement("identificador")]
        public string Identificador { get; set; }

        [XmlElement("nf")]
        public NF Nf { get; set; }

        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }

        [XmlElement("tomador")]
        public Tomador Tomador { get; set; }

        [XmlArray("itens")]
        public List<lista> Itens { get; set; }

        [XmlElement("Pesquisa")]
        public PesquisaDTO2 Pesquisa { get; set; }

        [XmlElement("numero")]
        public string Numero { get; set; }

        [XmlElement("serie_nfse")]
        public string SerieNf { get; set; }

        [XmlElement("situacao")]
        public string Situacao { get; set; }

        [XmlElement("observacao")]
        public string Observacao { get; set; }

        public NFEDTO(NFE nfse, User user, Client client, Service service)
        {
            Identificador = nfse.Identificador;
            Nf = new NF()
            {
                ValorTotal = "1,00"
            };
            Prestador = new Prestador(user);
            Tomador = new Tomador(client);
            lista item = new lista(service);
            Itens = new List<lista>
            {
                item
            };
        }
        public NFEDTO()
        {

        }
    }

    [XmlRoot("nf")]
    public class NF
    {
        [XmlElement("valor_total")]
        public string ValorTotal { get; set; }

        [XmlElement("numero")]
        public string Numero { get; set; }

        [XmlElement("serie_nfse")]
        public string SerieNf { get; set; }

        [XmlElement("situacao")]
        public string Situacao { get; set; }

        [XmlElement("observacao")]
        public string Observacao { get; set; }
    }

    [XmlRoot("prestador")]
    public class Prestador 
    {
        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [XmlElement("cidade")]
        public string Cidade { get; set; }

        public Prestador(Enterprise enterprise)
        {
            CpfCnpj = enterprise.CpfCnpj;
            Cidade = enterprise.City;
        }
        public Prestador(User user)
        {
            CpfCnpj = user.Enterprise.CpfCnpj;
            Cidade = user.Enterprise.City;
        }
        public Prestador()
        {

        }
    }

    [XmlRoot("tomador")]
    public class Tomador
    {
        [XmlElement("tipo")]
        public string Tipo { get; set; }

        [XmlElement("endereco_informado")]
        public string EnderecoInformado { get; set; }

        [XmlElement("identificador")]
        public string Identificador { get; set; }

        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [XmlElement("nome_razao_social")]
        public string NomeRazaoSocial { get; set; }

        [XmlElement("ie")]
        public string Ie { get; set; }

        [XmlElement("logradouro")]
        public string Logradouro { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("numero_residencia")]
        public string NumeroResidencia { get; set; }

        [XmlElement("complemento")]
        public string Complemento { get; set; }

        public Tomador(Client client)
        {
            Tipo = client.Enrollment;
            EnderecoInformado = client.Address;
            CpfCnpj = client.CpfCnpj;
            NomeRazaoSocial = client.Name;
            Ie = client.Ie;
            Email = client.Email;
            NumeroResidencia = client.ResidentialNumber;
        }
        public Tomador()
        {

        }
    }
    public class lista
    {
        [XmlElement("tributa_municipio_prestador")]
        public string TributaMunicipioPrestador { get; set; }

        [XmlElement("codigo_local_prestacao_servico")]
        public string CodigoLocalPrestServico { get; set; }

        [XmlElement("codigo_item_lista_servico")]
        public string CodigoServico { get; set; }

        [XmlElement("descritivo")]
        public string Descricao { get; set; }

        [XmlElement("aliquota_item_lista_servico")]
        public string AliquotaServico { get; set; }

        [XmlElement("situacao_tributaria")]
        public string SituacaoTributaria { get; set; }

        [XmlElement("valor_tributavel")]
        public string ValorTributavel { get; set; }

        public lista(Service service)
        {
            TributaMunicipioPrestador = service.tributa_municipio_prestador;
            CodigoLocalPrestServico = service.codigo_local_prestacao_servico;
            CodigoServico = service.codigo_local_prestacao_servico;
            Descricao = service.descritivo;
            AliquotaServico = service.aliquota_item_lista_servico;
            SituacaoTributaria = service.situacao_tributaria;
            ValorTributavel = service.valor_tributavel;
        }
        public lista()
        {

        }
    }

    [XmlRoot("solicitacao_cancelamento")]
    public class SolicitacaoCancelamento
    {
        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }

        [XmlElement("documentos")]
        public Documentos Documentos { get; set; }
    }

    [XmlRoot("documentos")]
    public class Documentos
    {
        [XmlElement("Nfse")]
        public NFEDTO Nfse { get; set; }
    }

    [XmlRoot("pesquisa")]
    public class PesquisaDTO2
    {
        [XmlElement("numero")]
        public string Numero { get; set; }

        [XmlElement("serie_nfse")]
        public string SerieNfse { get; set; }

        [XmlElement("cadastro")]
        public string Cadastro { get; set; }
    }
}
