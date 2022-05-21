using System.ComponentModel.DataAnnotations;

namespace PersonelPlakaTakibi.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string AdminUsername { get; set; }
        [Required]
        public string AdminPassword { get; set; }
    }
}
