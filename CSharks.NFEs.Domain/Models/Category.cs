using System.ComponentModel.DataAnnotations;

namespace CSharks.NFEs.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Favor digitar a descrição")]
	    public string Description { get; set; }
    }
}
