using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DoTerraWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(50)]
        [DisplayName("Nome da categoria")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Número de identificação")]
        [Range(1,100,ErrorMessage ="Número de identificação precisa ser entre 1 e 100")]
        public int? DisplayOrder { get; set; }

    }
}
