using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrampoFacil.Migrations
{
    /// <inheritdoc />
    public partial class AddFotoPerfilUrlToUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoProPro_Usuario_UsuarioId",
                table: "InfoProPro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InfoProPro",
                table: "InfoProPro");

            migrationBuilder.DropColumn(
                name: "Qtd_denuncia",
                table: "Denuncia");

            migrationBuilder.RenameTable(
                name: "InfoProPro",
                newName: "InfoPro");

            migrationBuilder.RenameColumn(
                name: "SenhaHash",
                table: "Usuario",
                newName: "Senha");

            migrationBuilder.RenameIndex(
                name: "IX_InfoProPro_UsuarioId",
                table: "InfoPro",
                newName: "IX_InfoPro_UsuarioId");

            migrationBuilder.AddColumn<string>(
                name: "FotoPerfilUrl",
                table: "Usuario",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TituloDenuncia",
                table: "Denuncia",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "Anuncio",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InfoPro",
                table: "InfoPro",
                column: "IdInfoPro");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoPro_Usuario_UsuarioId",
                table: "InfoPro",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoPro_Usuario_UsuarioId",
                table: "InfoPro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InfoPro",
                table: "InfoPro");

            migrationBuilder.DropColumn(
                name: "FotoPerfilUrl",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "TituloDenuncia",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Anuncio");

            migrationBuilder.RenameTable(
                name: "InfoPro",
                newName: "InfoProPro");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuario",
                newName: "SenhaHash");

            migrationBuilder.RenameIndex(
                name: "IX_InfoPro_UsuarioId",
                table: "InfoProPro",
                newName: "IX_InfoProPro_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "Qtd_denuncia",
                table: "Denuncia",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InfoProPro",
                table: "InfoProPro",
                column: "IdInfoPro");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoProPro_Usuario_UsuarioId",
                table: "InfoProPro",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
