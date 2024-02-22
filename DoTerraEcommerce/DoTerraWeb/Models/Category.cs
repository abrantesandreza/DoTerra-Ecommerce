using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DoTerraWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome da categoria é um campo obrigatório")]
        [MaxLength(100)]
        [DisplayName("Nome da categoria")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Número de identificação é um campo obrigatório")]
        [DisplayName("Número de identificação")]
        [Range(1,100,ErrorMessage ="Número de identificação precisa ser entre 1 e 100")]
        public int DisplayOrder { get; set; }

    }
}
