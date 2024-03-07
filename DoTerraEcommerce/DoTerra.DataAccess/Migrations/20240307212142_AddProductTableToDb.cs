using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoTerra.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COD = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    Price500 = table.Column<double>(type: "float", nullable: false),
                    Price1000 = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AromaticDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HowToUse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precautions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AromaticDescription", "Benefits", "COD", "Description", "HowToUse", "Ingredients", "ListPrice", "Name", "Precautions", "Price", "Price100", "Price1000", "Price500", "ScientificName", "Size", "Uses" },
                values: new object[] { 1, "Mentolado, fresco, herbáceo", "Ajuda a reduzir sentimentos de tensão.", 1, "O doTERRA® Peppermint Touch contém óleo essencial de Hortelã-Pimenta e Óleo de Coco Fracionado para promover vários benefícios. Seu aroma mentolado e herbáceo pode ser utilizado aromática e topicamente ao longo do dia para elevar o humor e promover um senso de foco. Quando aplicado nas têmporas e na nuca, ajuda a diminuir sentimentos de tensão. O doTERRA Peppermint Touch pode ser aplicado nessas áreas e em todo o corpo para promover uma massagem refrescante.", "Esfregue nas têmporas quando estiver estudando ou ao acordar, para um reforço de energia durante a manhã.", "Óleo de coco, Óleo de Mentha piperita.", 125.0, "dōTERRA Peppermint Touch", "Uso Externo. Pode causar irritação cutânea. Mantenha fora do alcance de crianças. Em caso de gravidez ou tratamento, consulte o médico. Evite contato com os olhos, ouvidos e áreas sensíveis. Em caso de contato com os olhos, enxágue com Óleo Carreador doTERRA em abundância. Em caso de irritação, descontinue o uso e procure um médico. Mantenha o produto ao abrigo da luz e do calor.", 115.0, 225.0, 1050.0, 770.0, "Mentha piperita", "10 ml", "Esfregue nas têmporas quando estiver estudando ou ao acordar, para um reforço de energia durante a manhã." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
