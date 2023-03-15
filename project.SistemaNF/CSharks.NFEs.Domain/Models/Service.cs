using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public string tributa_municipio_prestador { get; set; }
        public string codigo_local_prestacao_servico { get; set; }
        public string codigo_item_lista_servico { get; set; }
        public string descritivo { get; set; }
        public string aliquota_item_lista_servico { get; set; }
        public string situacao_tributaria { get; set; }
        public string valor_tributavel { get; set; }

        //public virtual Category? Category { get; set; }
    }
}
