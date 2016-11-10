using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class AnimalFood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Animal")]
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        [Required]
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}