using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_SEBET.Migrations
{
    public partial class Areas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Formality",
                table: "Users");

            migrationBuilder.AddColumn<long>(
                name: "AreaID",
                table: "Users",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FormalityID",
                table: "Users",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Formalities",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formalities", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AreaID",
                table: "Users",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FormalityID",
                table: "Users",
                column: "FormalityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Areas_AreaID",
                table: "Users",
                column: "AreaID",
                principalTable: "Areas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Formalities_FormalityID",
                table: "Users",
                column: "FormalityID",
                principalTable: "Formalities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Areas_AreaID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Formalities_FormalityID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Formalities");

            migrationBuilder.DropIndex(
                name: "IX_Users_AreaID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FormalityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AreaID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FormalityID",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Formality",
                table: "Users",
                nullable: true);
        }
    }
}
