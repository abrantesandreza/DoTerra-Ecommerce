using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DoTerra.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Nome")]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Nome Científico")]
        [MaxLength(100)]
        public string ScientificName  { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Código")]
        public int COD { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Tamanho")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Preço")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Benefícios")]
        public string Benefits { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Descrição Aromática")]
        public string AromaticDescription { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Ingredientes")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Usos")]
        public string Uses { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Como usar")]
        public string HowToUse { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Precauções")]
        public string Precautions { get; set; }

        [DisplayName("Categoria do produto")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }
    }
}
