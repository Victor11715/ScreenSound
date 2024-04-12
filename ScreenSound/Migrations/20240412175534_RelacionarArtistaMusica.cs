using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class RelacionarArtistaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "Musica",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musica_ArtistaId",
                table: "Musica",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musica_Artista_ArtistaId",
                table: "Musica",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musica_Artista_ArtistaId",
                table: "Musica");

            migrationBuilder.DropIndex(
                name: "IX_Musica_ArtistaId",
                table: "Musica");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "Musica");
        }
    }
}
