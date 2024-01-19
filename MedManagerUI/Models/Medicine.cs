using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagerUI.Models
{
    [Table("Meds")]
    public class Medicine
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Img { get; set; }

        [Required]
        public double Price {  get; set; }
        [Required]
        public int CategoryId {  get; set; }
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public List<CartDetail> CartDetails {  get; set; }


    }
}
