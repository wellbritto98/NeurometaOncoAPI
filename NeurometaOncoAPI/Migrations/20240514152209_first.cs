using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FotoPerfil = table.Column<byte[]>(type: "bytea", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    TokenExpiredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TokenCreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EnderecoCompleto = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<string>(type: "text", nullable: false),
                    FotoRgFrente = table.Column<byte[]>(type: "bytea", nullable: false),
                    FotoRgVerso = table.Column<byte[]>(type: "bytea", nullable: false),
                    ComprovanteResidencia = table.Column<byte[]>(type: "bytea", nullable: false),
                    RelatorioMedico = table.Column<byte[]>(type: "bytea", nullable: false),
                    PDFFormatado = table.Column<byte[]>(type: "bytea", nullable: false),
                    CrmMedico = table.Column<int>(type: "integer", nullable: false),
                    NomeMedico = table.Column<string>(type: "text", nullable: false),
                    Cid = table.Column<string>(type: "text", nullable: false),
                    UfCrm = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Pacientes_AspNetUsers_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Psicologos",
                columns: table => new
                {
                    PsicologoId = table.Column<string>(type: "text", nullable: false),
                    Crp = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    CarteiraCrp = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psicologos", x => x.PsicologoId);
                    table.ForeignKey(
                        name: "FK_Psicologos_AspNetUsers_PsicologoId",
                        column: x => x.PsicologoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    PsicologoId = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PacienteId = table.Column<string>(type: "text", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DataFim = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Nota = table.Column<int>(type: "integer", nullable: true),
                    Comentario = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => new { x.PsicologoId, x.Data, x.PacienteId });
                    table.ForeignKey(
                        name: "FK_Agendas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendas_Psicologos_PsicologoId",
                        column: x => x.PsicologoId,
                        principalTable: "Psicologos",
                        principalColumn: "PsicologoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "Paciente", "PACIENTE" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", null, "Psicologo", "PSICOLOGO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b", 0, "7fa0983a-aaec-420d-91eb-b290a4122bd0", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEGVU7c8NHlqeaxa+AX1Lg4jYWLW2m8zmrP8YA7aK7KU3CfLd8o4HH+IoVRPsevGWdg==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 794, DateTimeKind.Local).AddTicks(6112), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "26cbbda2-bcaa-4e73-b031-0953441bd130", 0, "b9a4e9c7-ff79-441a-9c3b-51d753c5e7b1", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAENX+aBxNaaMfilnOy7NDEI54kHUoOlFBdkZ/CAgGcFzwidndWoL/XK5cTW/T8M5zzQ==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 413, DateTimeKind.Local).AddTicks(3582), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "2b19466e-9f6a-4e53-8f6c-e64a9ced3095", 0, "8822187b-68d0-4d4e-aecd-81a00c8b5f89", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAECxIw7mA2d4aCv1WsFGNvRdJ+8vv1OFhlFqHEYWMZ3aF/hIvZPZotOHshr1zYT3hnw==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 236, DateTimeKind.Local).AddTicks(3755), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "3ed90f9b-e153-47c4-9c75-6945f5d1331c", 0, "803b35cf-0821-4ad3-913f-408ebd1b8571", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEMU0uguq8QWFIjV27U22U2fl14MJx+546cADd4C7MIQDFkYR3pE/ANPPsLowIgwMmw==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 734, DateTimeKind.Local).AddTicks(7099), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "5eb0952c-09b9-4571-8b72-291d1479048d", 0, "b4ac1240-8b33-4e2d-8368-3e1f7cf70308", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEIf+hk5jGxdzkQdUMb0eJePzeP3YSFc08ovZzy/e+gGS3AUbLFMx8jPX7OqR6Ahggw==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 294, DateTimeKind.Local).AddTicks(8791), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "68a725a9-ab50-4361-9a91-83da20930103", 0, "e1e68a79-74f4-4670-ac75-46b6a4c529e7", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEIQZu7ppFILirVOO7dAzVuqnMiL2x8YzI+x5C8I8MXNxoJnp+gcx9SoaAOkXmyzqpg==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 850, DateTimeKind.Local).AddTicks(9575), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "6c1318e6-8a6a-4b70-a428-82b2df1dc76b", 0, "bb2af7a4-7ee4-4500-926c-883990a2dc13", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEBW7IAL98GpTyvcHRRWjJweub/f/1FYA4hmMLc+btQRkhNe5Dkrs6Z6VkJoFWyA4mw==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 911, DateTimeKind.Local).AddTicks(2174), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "726e52ab-2ec8-4f61-bbd5-ac13d8932108", 0, "75540667-a52d-4b43-a341-350c6ea5163a", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEAQnfgjg8BrA03TcuPkhUAzUsiPE+DMPVyVyPgfaZ1V0NAHe2SDmqYWt7rrhFgVYCQ==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 352, DateTimeKind.Local).AddTicks(5500), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "a7d2f15d-eff2-4e7d-a474-8afd8da95f21", 0, "a70bb794-767c-4cf0-9371-87ecbf7d86f0", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEEEoa0jx4iPTTugYrbNZOJz8TLQo5eWKfWbXfvt0ZwLyVVC8qVGsFxROLHeDyVKW0w==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 676, DateTimeKind.Local).AddTicks(7096), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48", 0, "779db3bc-a6e4-4cdc-8fd2-e8ceb6e6d59b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEGJz56qCed8NSlDvPHLTJw4TgBKBF/tPYsUIxZqdCB9KWmHvkkysNMb/BYGELu/QuA==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 554, DateTimeKind.Local).AddTicks(2370), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "c55e6da3-a002-421d-b864-7a3d76e64790", 0, "b9a3f3bb-70ff-4d8b-a543-ad1473013f8f", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAELrBmJ+6wJutisGwHdljPXhWf5F4URjAV1ebviFwpuTDK6BISphXw/kTaXUBAWng+A==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 618, DateTimeKind.Local).AddTicks(5043), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "f7f70716-1ad4-433f-b853-dffa71ba3a2a", 0, "52a5e8f4-a907-4f45-a7cc-b05c08dc49a2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEE2xRugyc9n7mfk+RIZigPzQXA2uL/C7HX9AXbar+xJvXDzBqLaEqqcxb0BnViZefg==", null, false, "", new DateTime(2024, 5, 14, 12, 22, 8, 487, DateTimeKind.Local).AddTicks(4111), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "26cbbda2-bcaa-4e73-b031-0953441bd130" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "2b19466e-9f6a-4e53-8f6c-e64a9ced3095" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3ed90f9b-e153-47c4-9c75-6945f5d1331c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "5eb0952c-09b9-4571-8b72-291d1479048d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "68a725a9-ab50-4361-9a91-83da20930103" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6c1318e6-8a6a-4b70-a428-82b2df1dc76b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "726e52ab-2ec8-4f61-bbd5-ac13d8932108" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a7d2f15d-eff2-4e7d-a474-8afd8da95f21" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c55e6da3-a002-421d-b864-7a3d76e64790" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f7f70716-1ad4-433f-b853-dffa71ba3a2a" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" },
                    { "3ed90f9b-e153-47c4-9c75-6945f5d1331c", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "68a725a9-ab50-4361-9a91-83da20930103", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" },
                    { "6c1318e6-8a6a-4b70-a428-82b2df1dc76b", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "a7d2f15d-eff2-4e7d-a474-8afd8da95f21", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "c55e6da3-a002-421d-b864-7a3d76e64790", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao" },
                values: new object[,]
                {
                    { "26cbbda2-bcaa-4e73-b031-0953441bd130", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4" },
                    { "2b19466e-9f6a-4e53-8f6c-e64a9ced3095", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1" },
                    { "5eb0952c-09b9-4571-8b72-291d1479048d", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2" },
                    { "726e52ab-2ec8-4f61-bbd5-ac13d8932108", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3" },
                    { "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6" },
                    { "f7f70716-1ad4-433f-b853-dffa71ba3a2a", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_PacienteId",
                table: "Agendas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Psicologos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
