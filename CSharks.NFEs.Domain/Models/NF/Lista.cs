namespace CSharks.NFEs.Domain.Models.NF
{
    public class Lista
    {
        public Guid Id { get; set; }
        public string tributa_municipio_prestador { get; set; }
        public string codigo_local_prestacao_servico { get; set; }
        public string codigo_item_lista_servico { get; set; }
        public string descritivo { get; set; }
        public string aliquota_item_lista_servico { get; set; }
        public string situacao_tributaria { get; set; }
        public string valor_tributavel { get; set; }
    }
}
