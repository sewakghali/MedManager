using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManagerUI.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}
