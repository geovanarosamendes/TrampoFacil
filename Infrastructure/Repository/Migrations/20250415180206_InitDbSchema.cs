using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrampoFacil.Migrations
{
    /// <inheritdoc />
    public partial class InitDbSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    SenhaHash = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    IdAnuncio = table.Column<Guid>(type: "uuid", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Cobranca = table.Column<string>(type: "text", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.IdAnuncio);
                    table.ForeignKey(
                        name: "FK_Anuncio_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    IdDenuncia = table.Column<Guid>(type: "uuid", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: false),
                    Qtd_denuncia = table.Column<int>(type: "integer", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.IdDenuncia);
                    table.ForeignKey(
                        name: "FK_Denuncia_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoProPro",
                columns: table => new
                {
                    IdInfoPro = table.Column<Guid>(type: "uuid", nullable: false),
                    Profissao = table.Column<string>(type: "text", nullable: false),
                    Escolaridade = table.Column<string>(type: "text", nullable: false),
                    Cursos = table.Column<string>(type: "text", nullable: false),
                    Experiencias = table.Column<string>(type: "text", nullable: false),
                    Habilidades = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoProPro", x => x.IdInfoPro);
                    table.ForeignKey(
                        name: "FK_InfoProPro_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_UsuarioId",
                table: "Anuncio",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Denuncia_UsuarioId",
                table: "Denuncia",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoProPro_UsuarioId",
                table: "InfoProPro",
                column: "UsuarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Denuncia");

            migrationBuilder.DropTable(
                name: "InfoProPro");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
