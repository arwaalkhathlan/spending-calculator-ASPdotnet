using System.ComponentModel.DataAnnotations;

namespace aspdotnet_ef_example.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal value { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
