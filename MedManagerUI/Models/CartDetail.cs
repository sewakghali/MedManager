using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagerUI.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id {  get; set; }

        [Required]
        public int CardId { get; set; }
        [Required]
        public int MedId {  get; set; }
        [Required]
        public int Qty { get; set; }

        public Medicine Medicine { get; set; }
        public Cart Cart { get; set; }
    }
}
