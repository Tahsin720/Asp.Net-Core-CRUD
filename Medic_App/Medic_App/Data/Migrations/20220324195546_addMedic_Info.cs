using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medic_App.Data.Migrations
{
    public partial class addMedic_Info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medic_Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicine_Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medic_Infos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medic_Infos");
        }
    }
}
