using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagerUI.Models
{
    public enum OrderStatus{
        Delivered,
        Cancelled,
        Shipped,
        Preparing
    }

    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Delivered {  get; set; }
        public OrderStatus Status { get; set; }
        public bool isArchived { get; set; } = false;
        public List<OrderDetail> SubOrders {  get; set; }
    }
}
