using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class NFE
    {
		//FIXME names in portuguese
        public string NFSE { get; set; }
		public string NF { get; set; }
		public string ValorTotal { get; set; }
		public string Prestador { get; set; }
		public string CPFCNPJ { get; set; }
		public string Cidade { get; set; }
		public string Tomador { get; set; }
		public string Tipo { get; set; }
		public string TributacaoMunicipio { get; set; }
		public string CodigoLocalPrestacaoServico { get; set; }
		public string Descricao { get; set; }
		public string Aliquota { get; set; }
		public string SituacaoTributaria { get; set; }
		public string ValorTributario { get; set; }
		public string Identificador { get; set; }
		public string Numero { get; set; }
		public string Serie { get; set; }
		public string Situacao { get; set; }
		public string Observacao { get; set; }
		public string Solicitacao { get; set; }
	    
		public int ServiceId { get; set; }
		public virtual Service? Service { get; set; }
	
		public int CategoryId { get; set; }
		public virtual Category? Category { get; set; }
	
		public int ClientId { get; set; }
		public virtual Client? Client { get; set; }
	}
}
