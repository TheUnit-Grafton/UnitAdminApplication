using System.ComponentModel.DataAnnotations;
using static DataLibrary.Extensions.Enums;

namespace DataLibrary.Models
{
    public class PartModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500 , ErrorMessage = "Description must be less than 500 characters")]
        public string Description { get; set; }

        [MaxLength(50 , ErrorMessage = "Brandn must be less than 50 characters")]
        public string Brand { get; set; }

        [MaxLength(50)]
        public string Capacity { get; set; }

        public PartType Type { get; set; }
    }
}