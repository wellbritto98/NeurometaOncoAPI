using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class especialidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "108a512c-a147-4db6-a384-077f88de02c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3823ecb1-ad13-4cb4-b131-78325ab57622" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "61561c15-ba1c-4a4f-abf2-982351332d2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "70517581-782a-4ccf-9dbe-cc27fe96f59d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "75b9c1ef-6f79-4ac8-a219-a15bc1931546" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "93ff7dfb-8320-479d-b873-9c19a95c63ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9e50ba3c-9cc7-4f53-976f-92fe954ccecf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ae0cc099-178c-4b2c-90b2-08f40f2920f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b007b669-2179-4daf-a23f-826a79383847" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c0a13081-1138-47f3-98df-1425854aac1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "61561c15-ba1c-4a4f-abf2-982351332d2c");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "75b9c1ef-6f79-4ac8-a219-a15bc1931546");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "ae0cc099-178c-4b2c-90b2-08f40f2920f7");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "b007b669-2179-4daf-a23f-826a79383847");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "108a512c-a147-4db6-a384-077f88de02c7");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "3823ecb1-ad13-4cb4-b131-78325ab57622");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "70517581-782a-4ccf-9dbe-cc27fe96f59d");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "93ff7dfb-8320-479d-b873-9c19a95c63ec");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "9e50ba3c-9cc7-4f53-976f-92fe954ccecf");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "c0a13081-1138-47f3-98df-1425854aac1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108a512c-a147-4db6-a384-077f88de02c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3823ecb1-ad13-4cb4-b131-78325ab57622");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61561c15-ba1c-4a4f-abf2-982351332d2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70517581-782a-4ccf-9dbe-cc27fe96f59d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75b9c1ef-6f79-4ac8-a219-a15bc1931546");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93ff7dfb-8320-479d-b873-9c19a95c63ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e50ba3c-9cc7-4f53-976f-92fe954ccecf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0cc099-178c-4b2c-90b2-08f40f2920f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b007b669-2179-4daf-a23f-826a79383847");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0a13081-1138-47f3-98df-1425854aac1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5");

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Psicologos",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Psicologos");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "108a512c-a147-4db6-a384-077f88de02c7", 0, "39b5e8e5-1c7f-4ea9-97b8-0c8be74f2b6c", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEG5qO0DVXPV290hxTYn2wjPL7A8AsMOxvdhKKMi6QRfd2+91aCQQnKH1w7pZ+jt5yA==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 279, DateTimeKind.Local).AddTicks(5419), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff", 0, "3d5b63e6-2dfb-4ecf-81de-cd34e85eb934", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAECMSqtYvbgM0dCU1qzZ3hpay1g94WE5hE0iAbmwgCcKtNHEX//Cdo2CYMDZvUp7yEQ==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 998, DateTimeKind.Local).AddTicks(7935), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "3823ecb1-ad13-4cb4-b131-78325ab57622", 0, "5ae307c8-bb5d-4b19-9c98-787f9f266eb6", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEDrvJibQw8s/K+MDwWP9Ye9M5G5UG0+AHs3qvvwRKsmxgvZ5zEO3Z1m8Lnna7h1Y6Q==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 338, DateTimeKind.Local).AddTicks(8885), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "61561c15-ba1c-4a4f-abf2-982351332d2c", 0, "98e9ddca-56d7-4297-9f37-500ad56f959a", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEJG8/Ezc9dOr98Y/lCRaQhsGZTMf5nLd/mqR93BJ+bap362gecUh7jE0wj9XM+ltwA==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 823, DateTimeKind.Local).AddTicks(4884), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "70517581-782a-4ccf-9dbe-cc27fe96f59d", 0, "085e80b1-690e-4615-a313-03a740bafee5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAENx/LON8XOimUa8M+zp17/qGwch2tsCKAzExH+Tm+3b0k5wImBan8yLBWvewxttpWA==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 399, DateTimeKind.Local).AddTicks(6322), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "75b9c1ef-6f79-4ac8-a219-a15bc1931546", 0, "26736314-4c36-44de-ad84-23f91867cf4d", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAELqtjBb6xy5XkNlMRypzjrxGGC6+9+LtNHWuA2A+IN4lUeJQueiCj0U96kc8H4lACQ==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 747, DateTimeKind.Local).AddTicks(4224), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "93ff7dfb-8320-479d-b873-9c19a95c63ec", 0, "dbe5b76c-094f-4d19-af35-9b455dd21ff4", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEAnJyFi3sjA9i6C0qS84MrXQnplpfN3YKxBqAGfClZt7Z1r8NiwVi3ols53P+H6jQw==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 595, DateTimeKind.Local).AddTicks(5018), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "9e50ba3c-9cc7-4f53-976f-92fe954ccecf", 0, "5315c46f-88f3-48e5-b098-8f39c8568b06", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEPL0THDdd99rkVfxqxLCnsrvfJt5tDsNogEE4HTGLWKnZkvYYnzkdQoZXphpEU0KrA==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 537, DateTimeKind.Local).AddTicks(6001), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "ae0cc099-178c-4b2c-90b2-08f40f2920f7", 0, "3a3bd08d-551d-497c-b5a9-a54338baafdf", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEPm4K6Rzdq1Oin+VQMBlyynVpmPn06OT915/ZI7zreknd3Xlpud3VFe1tViZywh1Lg==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 669, DateTimeKind.Local).AddTicks(3930), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "b007b669-2179-4daf-a23f-826a79383847", 0, "b1d9b63d-b89f-4ffb-b948-31b6a8d9aa2c", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEN2nxZIs4qpY3Rkwf3bWmY8GR3yTs5xNK0o676HxbPrYW0YavPMj0ps69m2jrjU6MQ==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 880, DateTimeKind.Local).AddTicks(9895), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "c0a13081-1138-47f3-98df-1425854aac1b", 0, "3b59d5ec-9d4b-4be1-b044-a984e27548bb", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEJQiANCpKxej68FGOJzMt5asj5xYDh7eeCkxcIAOSyCgK9F3CWdnJw1ycIut0eqfvQ==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 474, DateTimeKind.Local).AddTicks(3445), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5", 0, "e1a4e11a-90d6-4694-aaee-9cdd2cacd172", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEDR/i+o2K/NZmqwMCxJpVe3vfos/4MlTPrctMnC9/R3XRttDy2wY7Gwp1Gw1CrOR0g==", null, false, "", new DateTime(2024, 5, 14, 15, 42, 22, 939, DateTimeKind.Local).AddTicks(4285), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "108a512c-a147-4db6-a384-077f88de02c7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3823ecb1-ad13-4cb4-b131-78325ab57622" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "61561c15-ba1c-4a4f-abf2-982351332d2c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "70517581-782a-4ccf-9dbe-cc27fe96f59d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "75b9c1ef-6f79-4ac8-a219-a15bc1931546" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "93ff7dfb-8320-479d-b873-9c19a95c63ec" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9e50ba3c-9cc7-4f53-976f-92fe954ccecf" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ae0cc099-178c-4b2c-90b2-08f40f2920f7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b007b669-2179-4daf-a23f-826a79383847" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c0a13081-1138-47f3-98df-1425854aac1b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "26cfbc5f-29dc-4b9d-982e-3902a52fc4ff", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "61561c15-ba1c-4a4f-abf2-982351332d2c", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "75b9c1ef-6f79-4ac8-a219-a15bc1931546", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "ae0cc099-178c-4b2c-90b2-08f40f2920f7", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "b007b669-2179-4daf-a23f-826a79383847", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" },
                    { "cc58ab93-5387-431f-95ee-d6dbd8f7b9d5", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao" },
                values: new object[,]
                {
                    { "108a512c-a147-4db6-a384-077f88de02c7", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1" },
                    { "3823ecb1-ad13-4cb4-b131-78325ab57622", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2" },
                    { "70517581-782a-4ccf-9dbe-cc27fe96f59d", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3" },
                    { "93ff7dfb-8320-479d-b873-9c19a95c63ec", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6" },
                    { "9e50ba3c-9cc7-4f53-976f-92fe954ccecf", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5" },
                    { "c0a13081-1138-47f3-98df-1425854aac1b", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4" }
                });
        }
    }
}
