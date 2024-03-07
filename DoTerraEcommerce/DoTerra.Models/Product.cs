using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Nome Científico")]
        public string ScientificName  { get; set; }
        [Required]
        public int COD { get; set; }
        [Required]
        [DisplayName("Tamanho")]
        public string Size { get; set; }

        [Required]
        [DisplayName("Preço")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Required]
        [DisplayName("Preço de 1-100")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [DisplayName("Preço de 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }

        [Required]
        [DisplayName("Preço de 500+")]
        [Range(1, 1000)]
        public double Price500 { get; set; }

        [Required]
        [DisplayName("Preço de 1000+")]
        [Range(1, 1000)]
        public double Price1000 { get; set; }

        [Required]
        [DisplayName("Tamanho")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Benefícios")]
        public string Benefits { get; set; }
        [Required]
        [DisplayName("Descrição Aromática")]
        public string AromaticDescription { get; set; }
        [Required]
        [DisplayName("Ingredientes")]
        public string Ingredients { get; set; }
        [Required]
        [DisplayName("Usos")]
        public string Uses { get; set; }
        [Required]
        [DisplayName("Como usar")]
        public string HowToUse { get; set; }
        [Required]
        [DisplayName("Precauções")]
        public string Precautions { get; set; }
    }
}
