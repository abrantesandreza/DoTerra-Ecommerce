using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DoTerraWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome da categoria")]
        public string Name { get; set; }
        [DisplayName("Número de identificação")]
        public int DisplayOrder { get; set; }

    }
}
