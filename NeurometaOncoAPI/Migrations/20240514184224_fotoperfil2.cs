using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class fotoperfil2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "35e2e315-bf33-42c7-9c8d-1799232c7732" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3b3b7737-5864-4b5d-be9f-d41b3406f805" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "59455323-cec2-4ca4-b885-8e290e6507f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "6181b44d-1521-439b-88f3-b38a60de7738" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7771539c-6f47-4041-acb8-d82b7af6de5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "818eb11a-079d-4415-810a-571ff6bc8bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8fb2a5af-2667-48f5-bc1f-1418d9a3424f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b60d1814-691e-4e29-bb62-38e5dee79076" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c2a276ae-f9af-468d-a593-f60a7c2be4be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d1b349a8-ae25-4920-8190-80c4608b2dd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "3b3b7737-5864-4b5d-be9f-d41b3406f805");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "7771539c-6f47-4041-acb8-d82b7af6de5c");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "818eb11a-079d-4415-810a-571ff6bc8bab");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "b60d1814-691e-4e29-bb62-38e5dee79076");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "d1b349a8-ae25-4920-8190-80c4608b2dd1");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "35e2e315-bf33-42c7-9c8d-1799232c7732");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "59455323-cec2-4ca4-b885-8e290e6507f0");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "6181b44d-1521-439b-88f3-b38a60de7738");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "8fb2a5af-2667-48f5-bc1f-1418d9a3424f");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "c2a276ae-f9af-468d-a593-f60a7c2be4be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e2e315-bf33-42c7-9c8d-1799232c7732");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b3b7737-5864-4b5d-be9f-d41b3406f805");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59455323-cec2-4ca4-b885-8e290e6507f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6181b44d-1521-439b-88f3-b38a60de7738");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7771539c-6f47-4041-acb8-d82b7af6de5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "818eb11a-079d-4415-810a-571ff6bc8bab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fb2a5af-2667-48f5-bc1f-1418d9a3424f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b60d1814-691e-4e29-bb62-38e5dee79076");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2a276ae-f9af-468d-a593-f60a7c2be4be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b349a8-ae25-4920-8190-80c4608b2dd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4");

            migrationBuilder.AlterColumn<string>(
                name: "FotoPerfil",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoPerfil",
                table: "AspNetUsers",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "35e2e315-bf33-42c7-9c8d-1799232c7732", 0, "204bd24b-fab7-4d4e-a4dd-0622e2a6b149", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEF/VDll1Hu7bgSOED2TMQITXG8R20uRDTTuOZu0G7fxMwxDrzx9XXjh3DruxzVJtcA==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 53, DateTimeKind.Local).AddTicks(2176), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "3b3b7737-5864-4b5d-be9f-d41b3406f805", 0, "da6a6420-1f26-43e7-936f-e615ec778e7e", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAECg0N/zyMK7fNHhkQJMpX0COzVkQflManlOYa1QS4S72W4RFGdfIshdsM3l3PzP6OA==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 263, DateTimeKind.Local).AddTicks(6186), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "59455323-cec2-4ca4-b885-8e290e6507f0", 0, "d05526b5-3cb4-4ca1-95a6-828db34da932", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEE1Lc8v6kilq4o18kBqO7XUAqA58AZnI/P4ip1cQq7Rjf9wE4osKhPhJhjryeof0Jg==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 7, 694, DateTimeKind.Local).AddTicks(4041), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "6181b44d-1521-439b-88f3-b38a60de7738", 0, "0334e63c-b3a2-4b3a-98ca-e61daec17f08", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEHqlq2M+CMN7H0DfNuTDFhQXuhAWraGOESz9+k3gcBz6FToqY5oT7wh8he3VUh12Pg==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 7, 990, DateTimeKind.Local).AddTicks(6008), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "7771539c-6f47-4041-acb8-d82b7af6de5c", 0, "240a0779-b878-4462-b7b6-e7268ed5d0b8", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEA5b3u4VijE25t1RBin/QtCTcMiT+poF6IPr8XZXjEtIMCWbSPPKIuOTUwW+wkSqVw==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 202, DateTimeKind.Local).AddTicks(9199), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "818eb11a-079d-4415-810a-571ff6bc8bab", 0, "39e8e108-db51-4898-a5b1-5b7500898bf0", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEBkX8Ap/xevSed81Lh5iWOrkBCaFo+ys6uM8ZIxrs14vQdaM2ZZ3RFM4Vg8BKXb7ww==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 383, DateTimeKind.Local).AddTicks(539), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "8fb2a5af-2667-48f5-bc1f-1418d9a3424f", 0, "2ced5e81-e1ff-4759-9f76-3dafb5159b24", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEPn42mc3ZScCIbASTIMiz/sz4FRWhLcei2sb95vqLZ1XEaeExCKxhweHuWnNCT0TLQ==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 7, 759, DateTimeKind.Local).AddTicks(3593), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc", 0, "63e32d04-8f9a-492c-99ba-b6fb323a5434", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEHhQAsBkINdK2Xn4DX9FG5N/jvyy3DD/74qCTBMwKDjNyHEEGSMrpHLoYfU5DZwVKA==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 7, 930, DateTimeKind.Local).AddTicks(987), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "b60d1814-691e-4e29-bb62-38e5dee79076", 0, "2b45b1a0-3e00-4be8-a075-a60ba53717db", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEFEbm2FY1QCJtSZKDvW3vjX4hFNePNwXf2BWmVNYDp9GB799KFJckPR4JC2aLr848w==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 125, DateTimeKind.Local).AddTicks(6954), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "c2a276ae-f9af-468d-a593-f60a7c2be4be", 0, "76d037a8-2b30-4851-9bd7-4720060fba20", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEOSYY5ui5xPGQvO76VnQpeV6PQmIJHY/5D/8haxaf41OqAGx61iz3P+u+G3pGqH8Gg==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 7, 839, DateTimeKind.Local).AddTicks(1082), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "d1b349a8-ae25-4920-8190-80c4608b2dd1", 0, "b73f75c7-de86-4b13-8042-f4a36889eb67", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK0JmnRfiS2LvVwiSoM4ceeIAw8oazwDtKQVvwLFEs6UGCSQ3uGlp+EVSbgUtMZcFw==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 442, DateTimeKind.Local).AddTicks(770), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4", 0, "4768f249-db4e-4f83-b033-76c7524f11b7", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", new byte[] { 104, 116, 116, 112, 115, 58, 47, 47, 115, 116, 97, 116, 105, 99, 46, 118, 101, 99, 116, 101, 101, 122, 121, 46, 99, 111, 109, 47, 115, 121, 115, 116, 101, 109, 47, 114, 101, 115, 111, 117, 114, 99, 101, 115, 47, 112, 114, 101, 118, 105, 101, 119, 115, 47, 48, 48, 57, 47, 51, 57, 55, 47, 56, 51, 53, 47, 110, 111, 110, 95, 50, 120, 47, 109, 97, 110, 45, 97, 118, 97, 116, 97, 114, 45, 99, 108, 105, 112, 97, 114, 116, 45, 105, 108, 108, 117, 115, 116, 114, 97, 116, 105, 111, 110, 45, 102, 114, 101, 101, 45, 112, 110, 103, 46, 112, 110, 103 }, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEGFvptJyUlykaUPkDQRdWKsDKHadumJ5whTuxymTn6hlEFH9GaYaGMSpubKtWI2e3g==", null, false, "", new DateTime(2024, 5, 14, 15, 39, 8, 325, DateTimeKind.Local).AddTicks(605), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "35e2e315-bf33-42c7-9c8d-1799232c7732" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3b3b7737-5864-4b5d-be9f-d41b3406f805" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "59455323-cec2-4ca4-b885-8e290e6507f0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "6181b44d-1521-439b-88f3-b38a60de7738" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7771539c-6f47-4041-acb8-d82b7af6de5c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "818eb11a-079d-4415-810a-571ff6bc8bab" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8fb2a5af-2667-48f5-bc1f-1418d9a3424f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b60d1814-691e-4e29-bb62-38e5dee79076" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c2a276ae-f9af-468d-a593-f60a7c2be4be" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d1b349a8-ae25-4920-8190-80c4608b2dd1" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "3b3b7737-5864-4b5d-be9f-d41b3406f805", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "7771539c-6f47-4041-acb8-d82b7af6de5c", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "818eb11a-079d-4415-810a-571ff6bc8bab", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" },
                    { "b60d1814-691e-4e29-bb62-38e5dee79076", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "d1b349a8-ae25-4920-8190-80c4608b2dd1", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "dc8d159a-5554-4420-bc6d-e8d6f7ece9c4", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao" },
                values: new object[,]
                {
                    { "35e2e315-bf33-42c7-9c8d-1799232c7732", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6" },
                    { "59455323-cec2-4ca4-b885-8e290e6507f0", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1" },
                    { "6181b44d-1521-439b-88f3-b38a60de7738", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5" },
                    { "8fb2a5af-2667-48f5-bc1f-1418d9a3424f", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2" },
                    { "a6dc25d5-fab9-4c1c-8391-5b2d5c61a2cc", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4" },
                    { "c2a276ae-f9af-468d-a593-f60a7c2be4be", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3" }
                });
        }
    }
}
