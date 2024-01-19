using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagerUI.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Required]
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        
        [Required]
        public int Qty {  get; set; }
        [Required]
        public int Price {  get; set; }
    }
}
