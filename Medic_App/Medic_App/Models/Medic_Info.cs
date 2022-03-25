using System.ComponentModel.DataAnnotations;
namespace Medic_App.Models
{
    public class Medic_Info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Medicine_Name { get; set; }
        public int Medicine_Quantity { get; set; }
    }
}