namespace CSharks.NFEs.Domain.Models.NF
{
    public class Tomador
    {
        public Guid Id { get; set; }
        public string tipo { get; set; }
        public string? endereco_informado { get; set; }
        public string? identificador { get; set; }
        public string cpfcnpj { get; set; }
        public string? nome_razao_social { get; set; }
        public string? ie { get; set; }
        public string? logradouro { get; set; }
        public string? email { get; set; }
        public string? numero_residencia { get; set; }
        public string? complemento { get; set; }
    }
}
