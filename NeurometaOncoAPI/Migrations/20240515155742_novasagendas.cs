using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class novasagendas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "1ba2d920-fa73-4b76-a9b7-57486f2fca2b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "29e135a3-c89b-4885-88b0-d9f41d9f372c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "375bdd87-c1ff-4ace-9d63-0502fca64bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3a07c419-36cd-44c4-970d-609618c84663" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "4f73c108-43d8-460a-9dcf-935019f08cba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "75c651ba-8301-46d5-94af-ef8408f520af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a408c481-1d9d-427f-91ef-e889e785a589" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "af8257a7-8f36-4035-9479-c9adc2b74b26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "be5a1896-0eb6-494b-b57a-378d549d8b6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "e654b1ab-2229-43e6-a47e-081e50f92c7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "fd62962a-f68d-4679-8865-daa023dc3a1b" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "29e135a3-c89b-4885-88b0-d9f41d9f372c");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "375bdd87-c1ff-4ace-9d63-0502fca64bd6");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "75c651ba-8301-46d5-94af-ef8408f520af");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "a408c481-1d9d-427f-91ef-e889e785a589");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "af8257a7-8f36-4035-9479-c9adc2b74b26");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "1ba2d920-fa73-4b76-a9b7-57486f2fca2b");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "3a07c419-36cd-44c4-970d-609618c84663");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "4f73c108-43d8-460a-9dcf-935019f08cba");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "be5a1896-0eb6-494b-b57a-378d549d8b6a");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "e654b1ab-2229-43e6-a47e-081e50f92c7d");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "fd62962a-f68d-4679-8865-daa023dc3a1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ba2d920-fa73-4b76-a9b7-57486f2fca2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e135a3-c89b-4885-88b0-d9f41d9f372c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "375bdd87-c1ff-4ace-9d63-0502fca64bd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a07c419-36cd-44c4-970d-609618c84663");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f73c108-43d8-460a-9dcf-935019f08cba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75c651ba-8301-46d5-94af-ef8408f520af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a408c481-1d9d-427f-91ef-e889e785a589");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af8257a7-8f36-4035-9479-c9adc2b74b26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be5a1896-0eb6-494b-b57a-378d549d8b6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e654b1ab-2229-43e6-a47e-081e50f92c7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd62962a-f68d-4679-8865-daa023dc3a1b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "06308d61-318e-4d59-b5a5-83abcc436fca", 0, "7ee475c9-dabe-4104-87a3-e990442816aa", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEMdQxBf5NU3CBTtRHLvCddXBvbsrou/bQhXPr+AHYIi2CM983iv2zGu3tqfqXlaYHQ==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(4879), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "0b5172f7-8900-451a-bef4-9f35308cb8c4", 0, "5c184cb0-e9bd-4a3a-a4b8-14afe147d4f1", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAELYV9LAlZnXNpn21LiLCr3IyRUXPx1wmHuvP3h6xQ1PLrgKk5CYsXhR3c7f+asu5gw==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 227, DateTimeKind.Local).AddTicks(4605), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "108fe15f-b6d6-4475-aa8c-a7f8e1533997", 0, "02dfc5d4-f8a2-4caa-892b-55d1f5d5204e", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEPEfZlguY79gJiQH9Bth4NUMA6mYmmIflntmLZjtQf92Xbk2/sXyE+sf4GxHqZNSzw==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 300, DateTimeKind.Local).AddTicks(4438), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "159e62c4-08db-4130-8342-7abb94c1bc18", 0, "7747458b-db05-47ee-b8cc-7585778d3e67", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEAetgh10z+r/iRqKLqGQ+XN1xf2pRzFx+aagpZyxiuFDhUWIuoZ5c/sB9PFtOdRunw==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(5767), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "16ae5f23-68ca-484d-8052-309eb5d04895", 0, "3379bfe2-ad3c-484e-b4a2-1f2001a01575", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEGnjwZ4+qAYHUto4go1BMU62OYLuffFxZVn751k74TOPaEM/h5X+EKkrG9l9y0qBBg==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(968), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "42ea07ae-4f5a-4d34-961f-674806baa9da", 0, "8efc5715-07dd-480d-ac74-edc885b52a35", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEP2biIJ3ae0ZMnSE7/+qtnOfOatZPUUGkNf6qjzfmuO2R+s7NVVsGQWMM/C2+T7KtA==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(1759), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "7e08e66d-e081-4acc-b1c7-b806e10522b8", 0, "7e21e8dc-823c-4ab5-b827-378c272d750d", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEERGafjscToQ26SoYKcW+booW1g4DSMxZCOrY3t09f1qeXvCiT5YJG3ZUp0PxY78gQ==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 10, DateTimeKind.Local).AddTicks(1946), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", 0, "4d259826-754d-4d5a-a4a2-99993b2ce3e6", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEErsFwwd/igIn5DNumncV1tLAOwxmdhZtaNJCtzTi/j2C3F/HZJmVPo5vTQdWIRDGA==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(8985), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "e07758fa-e487-4ba5-8632-79e1b62d61d4", 0, "20b525ed-fa54-4d2d-a9c2-1b21d8591553", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEG7WkIiDKAeGi70E2j8S/+95JBn8eIyCgGFyN1587LfxrnApKNotCT3mhHvFyPa3HQ==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 150, DateTimeKind.Local).AddTicks(1461), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "e6858a95-7e31-4d41-b741-82c238d1755b", 0, "2703c090-59af-425b-b7a7-505ca4aad853", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEL1UMhmly+rvrxlEf3YljBf5YOWIh76ZDfO59zGz3X3Sd/aCD4GcsqR8SSChrCIp1g==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5033), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "f9f1f037-01d0-4f20-8b21-94de9d1abbce", 0, "8016f791-cda9-410c-a064-eca467ed7176", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEL+Q3B9NSEXyIocOzdBaVycoNIILLK1hOPVsOy1a9G+0Q7E5KsWZQsxywSGsp7XRQQ==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 370, DateTimeKind.Local).AddTicks(7371), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b", 0, "6f272d02-90c8-412b-a944-9afb818cbf54", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEKqAlDOebVE+HWe+xsXwvZv0iff0/0PAmQl9cYAQYf/xo6r5LA6pL4BDugeewCt7bA==", null, false, "", new DateTime(2024, 5, 15, 12, 57, 40, 79, DateTimeKind.Local).AddTicks(9944), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "06308d61-318e-4d59-b5a5-83abcc436fca" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "0b5172f7-8900-451a-bef4-9f35308cb8c4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "108fe15f-b6d6-4475-aa8c-a7f8e1533997" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "159e62c4-08db-4130-8342-7abb94c1bc18" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "16ae5f23-68ca-484d-8052-309eb5d04895" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "42ea07ae-4f5a-4d34-961f-674806baa9da" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "7e08e66d-e081-4acc-b1c7-b806e10522b8" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "e07758fa-e487-4ba5-8632-79e1b62d61d4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e6858a95-7e31-4d41-b741-82c238d1755b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f9f1f037-01d0-4f20-8b21-94de9d1abbce" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "06308d61-318e-4d59-b5a5-83abcc436fca", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "159e62c4-08db-4130-8342-7abb94c1bc18", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "16ae5f23-68ca-484d-8052-309eb5d04895", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" },
                    { "42ea07ae-4f5a-4d34-961f-674806baa9da", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "e6858a95-7e31-4d41-b741-82c238d1755b", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao", "Especialidade" },
                values: new object[,]
                {
                    { "0b5172f7-8900-451a-bef4-9f35308cb8c4", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4", "Psicanálise" },
                    { "108fe15f-b6d6-4475-aa8c-a7f8e1533997", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5", "Psicanálise" },
                    { "7e08e66d-e081-4acc-b1c7-b806e10522b8", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1", "Terceira Especialidade" },
                    { "e07758fa-e487-4ba5-8632-79e1b62d61d4", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3", "Psicanálise" },
                    { "f9f1f037-01d0-4f20-8b21-94de9d1abbce", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6", "Terapia Cognitivo Comportamental" },
                    { "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2", "Terapia Cognitivo Comportamental" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Data", "PacienteId", "PsicologoId", "Comentario", "DataFim", "DataInicio", "Nota" },
                values: new object[,]
                {
                    { new DateTime(2024, 5, 14, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5245), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4", null, new DateTime(2024, 5, 14, 13, 57, 40, 632, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 5, 14, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5255), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5285), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4", null, new DateTime(2024, 5, 15, 14, 57, 40, 632, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 5, 15, 13, 57, 40, 632, DateTimeKind.Local).AddTicks(5285), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5288), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4", null, new DateTime(2024, 5, 16, 15, 57, 40, 632, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 5, 16, 14, 57, 40, 632, DateTimeKind.Local).AddTicks(5289), null },
                    { new DateTime(2024, 5, 14, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1314), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997", null, new DateTime(2024, 5, 14, 13, 57, 40, 692, DateTimeKind.Local).AddTicks(1317), new DateTime(2024, 5, 14, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1316), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1337), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997", null, new DateTime(2024, 5, 15, 14, 57, 40, 692, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 5, 15, 13, 57, 40, 692, DateTimeKind.Local).AddTicks(1337), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1340), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997", null, new DateTime(2024, 5, 16, 15, 57, 40, 692, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 5, 16, 14, 57, 40, 692, DateTimeKind.Local).AddTicks(1340), null },
                    { new DateTime(2024, 5, 14, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2050), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8", null, new DateTime(2024, 5, 14, 13, 57, 40, 442, DateTimeKind.Local).AddTicks(2071), new DateTime(2024, 5, 14, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2059), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2091), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8", null, new DateTime(2024, 5, 15, 14, 57, 40, 442, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 5, 15, 13, 57, 40, 442, DateTimeKind.Local).AddTicks(2092), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2099), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8", null, new DateTime(2024, 5, 16, 15, 57, 40, 442, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 5, 16, 14, 57, 40, 442, DateTimeKind.Local).AddTicks(2100), null },
                    { new DateTime(2024, 5, 14, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9207), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4", null, new DateTime(2024, 5, 14, 13, 57, 40, 571, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 14, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9210), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9243), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4", null, new DateTime(2024, 5, 15, 14, 57, 40, 571, DateTimeKind.Local).AddTicks(9244), new DateTime(2024, 5, 15, 13, 57, 40, 571, DateTimeKind.Local).AddTicks(9244), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9246), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4", null, new DateTime(2024, 5, 16, 15, 57, 40, 571, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 5, 16, 14, 57, 40, 571, DateTimeKind.Local).AddTicks(9247), null },
                    { new DateTime(2024, 5, 14, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6072), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce", null, new DateTime(2024, 5, 14, 13, 57, 40, 752, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 5, 14, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6076), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6165), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce", null, new DateTime(2024, 5, 15, 14, 57, 40, 752, DateTimeKind.Local).AddTicks(6166), new DateTime(2024, 5, 15, 13, 57, 40, 752, DateTimeKind.Local).AddTicks(6165), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6180), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce", null, new DateTime(2024, 5, 16, 15, 57, 40, 752, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 5, 16, 14, 57, 40, 752, DateTimeKind.Local).AddTicks(6180), null },
                    { new DateTime(2024, 5, 14, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5194), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b", null, new DateTime(2024, 5, 14, 13, 57, 40, 506, DateTimeKind.Local).AddTicks(5213), new DateTime(2024, 5, 14, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5207), null },
                    { new DateTime(2024, 5, 15, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5309), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b", null, new DateTime(2024, 5, 15, 14, 57, 40, 506, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 5, 15, 13, 57, 40, 506, DateTimeKind.Local).AddTicks(5310), null },
                    { new DateTime(2024, 5, 16, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5326), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b", null, new DateTime(2024, 5, 16, 15, 57, 40, 506, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 16, 14, 57, 40, 506, DateTimeKind.Local).AddTicks(5327), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5245), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5285), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 632, DateTimeKind.Local).AddTicks(5288), "e6858a95-7e31-4d41-b741-82c238d1755b", "0b5172f7-8900-451a-bef4-9f35308cb8c4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1314), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1337), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 692, DateTimeKind.Local).AddTicks(1340), "16ae5f23-68ca-484d-8052-309eb5d04895", "108fe15f-b6d6-4475-aa8c-a7f8e1533997" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2050), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2091), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 442, DateTimeKind.Local).AddTicks(2099), "42ea07ae-4f5a-4d34-961f-674806baa9da", "7e08e66d-e081-4acc-b1c7-b806e10522b8" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9207), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9243), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 571, DateTimeKind.Local).AddTicks(9246), "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee", "e07758fa-e487-4ba5-8632-79e1b62d61d4" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6072), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6165), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 752, DateTimeKind.Local).AddTicks(6180), "159e62c4-08db-4130-8342-7abb94c1bc18", "f9f1f037-01d0-4f20-8b21-94de9d1abbce" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5194), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5309), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 12, 57, 40, 506, DateTimeKind.Local).AddTicks(5326), "06308d61-318e-4d59-b5a5-83abcc436fca", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "06308d61-318e-4d59-b5a5-83abcc436fca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "0b5172f7-8900-451a-bef4-9f35308cb8c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "108fe15f-b6d6-4475-aa8c-a7f8e1533997" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "159e62c4-08db-4130-8342-7abb94c1bc18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "16ae5f23-68ca-484d-8052-309eb5d04895" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "42ea07ae-4f5a-4d34-961f-674806baa9da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "7e08e66d-e081-4acc-b1c7-b806e10522b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "e07758fa-e487-4ba5-8632-79e1b62d61d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e6858a95-7e31-4d41-b741-82c238d1755b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f9f1f037-01d0-4f20-8b21-94de9d1abbce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "06308d61-318e-4d59-b5a5-83abcc436fca");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "159e62c4-08db-4130-8342-7abb94c1bc18");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "16ae5f23-68ca-484d-8052-309eb5d04895");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "42ea07ae-4f5a-4d34-961f-674806baa9da");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "e6858a95-7e31-4d41-b741-82c238d1755b");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "0b5172f7-8900-451a-bef4-9f35308cb8c4");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "108fe15f-b6d6-4475-aa8c-a7f8e1533997");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "7e08e66d-e081-4acc-b1c7-b806e10522b8");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "e07758fa-e487-4ba5-8632-79e1b62d61d4");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "f9f1f037-01d0-4f20-8b21-94de9d1abbce");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06308d61-318e-4d59-b5a5-83abcc436fca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b5172f7-8900-451a-bef4-9f35308cb8c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108fe15f-b6d6-4475-aa8c-a7f8e1533997");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e62c4-08db-4130-8342-7abb94c1bc18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16ae5f23-68ca-484d-8052-309eb5d04895");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42ea07ae-4f5a-4d34-961f-674806baa9da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e08e66d-e081-4acc-b1c7-b806e10522b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6004cb8-8e9a-4e04-8e3c-a8f74eda18ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e07758fa-e487-4ba5-8632-79e1b62d61d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6858a95-7e31-4d41-b741-82c238d1755b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f1f037-01d0-4f20-8b21-94de9d1abbce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faec9de0-ccd8-48d5-9e6f-090a39f7bc5b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "1ba2d920-fa73-4b76-a9b7-57486f2fca2b", 0, "66380be4-b4e2-4420-90ac-d82a65e30874", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAECNF2rEKB1uZXhFXS3L5qZ3oamBQQ315WRNq6KE2L9zCvIw+hmOlFM3dhx0Z9FPOmA==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 484, DateTimeKind.Local).AddTicks(9919), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5", 0, "9bacad09-e88c-4e3e-b168-5b1ea492044b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEOvkRRhonJyI1aBba/bssSi/rvPZfHIeEteFdufVZRffKzM7svizsrOxwP3/Uwpwdw==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 759, DateTimeKind.Local).AddTicks(2955), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "29e135a3-c89b-4885-88b0-d9f41d9f372c", 0, "68fd46f8-5f5a-4e85-ab33-3cf7d668b7e5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEAW05DqqNpl+k0/EcOGLyXP+Zc8KLrfgB8K1LTgrmF8Lu5023JZpUtRrzKcFt19v4w==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 818, DateTimeKind.Local).AddTicks(5685), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "375bdd87-c1ff-4ace-9d63-0502fca64bd6", 0, "328697e9-6c00-40ea-a835-58cf32aeefd9", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEA4qDlEVO1MFEHmDOdnunL0YJnmKf1hQeq+f7w5F1iCWWABZ3SgWMmxb00mnAy4oSQ==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 880, DateTimeKind.Local).AddTicks(7119), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "3a07c419-36cd-44c4-970d-609618c84663", 0, "e79c3413-bb6a-409a-8835-a770fd634b59", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEKfkt0tk/edQHgftMkX/C8xbwlrzGX+mpcD863p4eszsEVDxyEuO8yriqwAAYX+61Q==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 555, DateTimeKind.Local).AddTicks(2698), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "4f73c108-43d8-460a-9dcf-935019f08cba", 0, "67815a8e-397b-4074-a96d-bd6b3e80c600", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEIhEGLDbLDqwLY1FmeNlZSBLWBXJB8HbnLqWt6bS37VuXHIp4YjFGg3UXvpgOomdmw==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 329, DateTimeKind.Local).AddTicks(5135), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "75c651ba-8301-46d5-94af-ef8408f520af", 0, "a61deb48-6692-4189-ab2a-8bcf3633b76c", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEGKZfF+Sf15iHN+m3nhVzqE516pXST3L4pf/FboHcIfNd5tgUiE9hGEb7tw2n+sY3g==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 689, DateTimeKind.Local).AddTicks(6557), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "a408c481-1d9d-427f-91ef-e889e785a589", 0, "e25daad5-431b-42f0-93ca-9f92bfb79696", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEOqm4wafB7Hj7Y6rzoKNqHNx+gje8DqZi33ivsmEZNkhPkQF/7zgjRXy3o1OBPRwUQ==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 59, 6, DateTimeKind.Local).AddTicks(5423), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "af8257a7-8f36-4035-9479-c9adc2b74b26", 0, "ffc059e7-97c6-41c5-b357-f5aa231a6497", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAENbngYLH3My68ODLDI3moWwI3QJL8TrmnKhXyX0YLAKB34eh2kz6Px/V5a9j7To4ng==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 943, DateTimeKind.Local).AddTicks(5453), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "be5a1896-0eb6-494b-b57a-378d549d8b6a", 0, "f8172693-1708-43de-a7fb-e3d158707cc6", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAELQrh3+IKZ067HnrKhMbaDLAho0pcMxPhPObjd+iQgHRDbMDlImCZaXOp6cJ04XG9g==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 623, DateTimeKind.Local).AddTicks(1573), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "e654b1ab-2229-43e6-a47e-081e50f92c7d", 0, "2bf2756c-0401-4407-9711-109be8b5988f", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAECkRy8De/ahJ+Mn4GXMpSaq36wGgbccB98MzjsVHB4wHl5digSqPBDLOyLP8nq+anQ==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 411, DateTimeKind.Local).AddTicks(5465), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "fd62962a-f68d-4679-8865-daa023dc3a1b", 0, "2ef18327-ffe2-4a57-9a5b-3b55616651da", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEGVyYPatevOTCv208iXlS04fs0befcfw1o/EgtuoFg+38p7hatBeusOuuHbX1ckIMg==", null, false, "", new DateTime(2024, 5, 15, 12, 16, 58, 252, DateTimeKind.Local).AddTicks(9361), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "1ba2d920-fa73-4b76-a9b7-57486f2fca2b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "29e135a3-c89b-4885-88b0-d9f41d9f372c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "375bdd87-c1ff-4ace-9d63-0502fca64bd6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3a07c419-36cd-44c4-970d-609618c84663" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "4f73c108-43d8-460a-9dcf-935019f08cba" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "75c651ba-8301-46d5-94af-ef8408f520af" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a408c481-1d9d-427f-91ef-e889e785a589" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "af8257a7-8f36-4035-9479-c9adc2b74b26" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "be5a1896-0eb6-494b-b57a-378d549d8b6a" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "e654b1ab-2229-43e6-a47e-081e50f92c7d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "fd62962a-f68d-4679-8865-daa023dc3a1b" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "1d6c8977-a808-4ed2-b8f1-c05d177a4ef5", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "29e135a3-c89b-4885-88b0-d9f41d9f372c", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "375bdd87-c1ff-4ace-9d63-0502fca64bd6", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" },
                    { "75c651ba-8301-46d5-94af-ef8408f520af", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "a408c481-1d9d-427f-91ef-e889e785a589", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "af8257a7-8f36-4035-9479-c9adc2b74b26", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao", "Especialidade" },
                values: new object[,]
                {
                    { "1ba2d920-fa73-4b76-a9b7-57486f2fca2b", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4", "Psicanálise" },
                    { "3a07c419-36cd-44c4-970d-609618c84663", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5", "Terceira Especialidade" },
                    { "4f73c108-43d8-460a-9dcf-935019f08cba", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2", "Terapia Cognitivo Comportamental" },
                    { "be5a1896-0eb6-494b-b57a-378d549d8b6a", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6", "Terceira Especialidade" },
                    { "e654b1ab-2229-43e6-a47e-081e50f92c7d", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3", "Terceira Especialidade" },
                    { "fd62962a-f68d-4679-8865-daa023dc3a1b", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1", "Terceira Especialidade" }
                });
        }
    }
}
