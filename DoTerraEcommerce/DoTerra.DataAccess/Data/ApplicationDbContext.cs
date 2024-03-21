using DoTerra.Models;
using Microsoft.EntityFrameworkCore;

namespace DoTerra.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Óleos Essenciais", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Acessórios", DisplayOrder = 2 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, 
                            Name = "dōTERRA Peppermint Touch", 
                            ScientificName = "Mentha piperita", 
                            COD = 101, 
                            Size = "10 ml", 
                            Price= 115, 
                            Description = "O doTERRA® Peppermint Touch contém óleo essencial de Hortelã-Pimenta e " +
                            "Óleo de Coco Fracionado para promover vários benefícios. Seu aroma mentolado e herbáceo " +
                            "pode ser utilizado aromática e topicamente ao longo do dia para elevar o humor e promover " +
                            "um senso de foco. Quando aplicado nas têmporas e na nuca, ajuda a diminuir sentimentos de " +
                            "tensão. O doTERRA Peppermint Touch pode ser aplicado nessas áreas e em todo o corpo para " +
                            "promover uma massagem refrescante.",
                            Benefits = "Ajuda a reduzir sentimentos de tensão.", 
                            AromaticDescription = "Mentolado, fresco, herbáceo",
                            Ingredients = "Óleo de coco, Óleo de Mentha piperita.", 
                            Uses = "Esfregue nas têmporas quando " +
                            "estiver estudando ou ao acordar, para um reforço de energia durante a manhã.", 
                            HowToUse = "Esfregue " +
                            "nas têmporas quando estiver estudando ou ao acordar, para um reforço de energia durante a manhã.", 
                            Precautions = "Uso Externo. " +
                            "Pode causar irritação cutânea. Mantenha fora do alcance de crianças. Em caso de gravidez ou tratamento, consulte o médico. " +
                            "Evite contato com os olhos, ouvidos e áreas sensíveis. Em caso de contato com os olhos, enxágue com Óleo Carreador doTERRA em " +
                            "abundância. Em caso de irritação, descontinue o uso e procure um médico. Mantenha o produto ao abrigo da luz e do calor.",
                            CategoryId = 2
                            }
                );
        }
    }
}
