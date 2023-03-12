
namespace CSharks.NFEs.Domain.Models.NF
{
    public class NF
    {
        public Guid Id { get; set; }
        public string valor_total { get; set; }
        public string? numero { get; set; }
        public string? serie_nfse { get; set; }
        public string? situacao { get; set; }
        public string? observacao { get; set; }
    }
}
