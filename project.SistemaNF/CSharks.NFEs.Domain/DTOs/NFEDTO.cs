
﻿using CSharks.NFEs.Domain.Models;

namespace CSharks.NFEs.Domain.DTOs

{
    public class nfse
    {
        //FIXME names in portuguese
        //FIXME names like tags xml
        //public string NFSE { get; set; }
        public string identificador { get; set; }
        public NF nf { get; set; }
        public Prestador prestador { get; set; }
        public Tomador tomador { get; set; }
        public List<lista> itens { get; set; }
        public PesquisaDTO2 pesquisa { get; set; }
        public string numero { get; set; }
        public string serie_nfse { get; set; }
        public string situacao { get; set; }
        public string observacao { get; set; }

        //public int ServiceId { get; set; }
        //public virtual Service? Service { get; set; }

        //public int CategoryId { get; set; }
        //public virtual Category? Category { get; set; }

        //public int ClientId { get; set; }
        //public virtual Client? Client { get; set; }

    }

    public class NF
    {
        public string valor_total { get; set; }
        public string numero { get; set; }
        public string serie_nfse { get; set; }
        public string situacao { get; set; }
        public string observacao { get; set; }
    }
    public class Prestador 
    {
        public string cpfcnpj { get; set; }
        public string cidade { get; set; }
    }

    public class Tomador
    {
        public string tipo { get; set; }
        public string endereco_informado { get; set; }
        public string identificador { get; set; }
        public string cpfcnpj { get; set; }
        public string nome_razao_social { get; set; }
        public string ie { get; set; }
        public string logradouro { get; set; }
        public string email { get; set; }
        public string numero_residencia { get; set; }
        public string complemento { get; set; }
    }
    public class lista
    {
        public string tributa_municipio_prestador { get; set; }
        public string codigo_local_prestacao_servico { get; set; }
        public string codigo_item_lista_servico { get; set; }
        public string descritivo { get; set; }
        public string aliquota_item_lista_servico { get; set; }
        public string situacao_tributaria { get; set; }
        public string valor_tributavel { get; set; }
    }
    public class SolicitacaoCancelamento
    {
        public Prestador prestador { get; set; }
        public Documentos documentos { get; set; }
    }
    public class Documentos
    {
        public nfse nfse { get; set; }
    }
    public class PesquisaDTO2
    {
        public string numero { get; set; }
        public string serie_nfse { get; set; }
        public string cadastro { get; set; }
    }
}
