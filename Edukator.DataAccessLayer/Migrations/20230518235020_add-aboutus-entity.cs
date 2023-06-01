using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class addaboutusentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUss",
                columns: table => new
                {
                    AboutUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureIcon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureIcon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureIcon3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureIcon4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticValue1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticValue2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticValue3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticTitle4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticValue4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUss", x => x.AboutUsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUss");
        }
    }
}
