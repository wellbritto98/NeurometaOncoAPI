using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Enderecos_EnderecoId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EnderecoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "EnderecoCompleto",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FotoRgFrente = table.Column<byte[]>(type: "bytea", nullable: false),
                    FotoRgVerso = table.Column<byte[]>(type: "bytea", nullable: false),
                    ComprovanteResidencia = table.Column<byte[]>(type: "bytea", nullable: false),
                    RelatorioMedico = table.Column<byte[]>(type: "bytea", nullable: false),
                    PDFFormatado = table.Column<byte[]>(type: "bytea", nullable: false),
                    CrmMedico = table.Column<int>(type: "integer", nullable: false),
                    NomeMedico = table.Column<string>(type: "text", nullable: false),
                    Cid = table.Column<string>(type: "text", nullable: false),
                    UfCrm = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Pacientes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EnderecoCompleto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "role",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EnderecoId",
                table: "AspNetUsers",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Enderecos_EnderecoId",
                table: "AspNetUsers",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
