using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class userfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4108), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4189), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4199), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5320), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5352), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5357), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4321), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4520), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4550), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5378), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5457), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5465), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2826), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2860), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2950), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 14, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(5958), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 15, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(6142), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 16, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(6272), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2f4106df-6cee-42f9-a22e-8d65d994b824" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3f38348a-bf9d-4ed5-97af-a09cc965ca2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "46cc5a6f-e612-42ca-a969-bb6ca507ec71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "66a805db-f7f6-4948-8558-1c2abdd7cf2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "767351ac-1687-46d0-b7fe-9e64f801c009" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "a58404da-ceff-4fd2-9ec4-d749a0e136f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7deb289-28b8-4cb6-8f0d-c1845aff8421" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d008bf53-5d61-41de-96e9-877b48d74beb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f95747e3-80c2-4261-a1dc-e3e0dd773d57" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "2f4106df-6cee-42f9-a22e-8d65d994b824");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "3f38348a-bf9d-4ed5-97af-a09cc965ca2e");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "b7deb289-28b8-4cb6-8f0d-c1845aff8421");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "d008bf53-5d61-41de-96e9-877b48d74beb");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "46cc5a6f-e612-42ca-a969-bb6ca507ec71");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "66a805db-f7f6-4948-8558-1c2abdd7cf2c");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "767351ac-1687-46d0-b7fe-9e64f801c009");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "a58404da-ceff-4fd2-9ec4-d749a0e136f7");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "f95747e3-80c2-4261-a1dc-e3e0dd773d57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f4106df-6cee-42f9-a22e-8d65d994b824");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f38348a-bf9d-4ed5-97af-a09cc965ca2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46cc5a6f-e612-42ca-a969-bb6ca507ec71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66a805db-f7f6-4948-8558-1c2abdd7cf2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "767351ac-1687-46d0-b7fe-9e64f801c009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a58404da-ceff-4fd2-9ec4-d749a0e136f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7deb289-28b8-4cb6-8f0d-c1845aff8421");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d008bf53-5d61-41de-96e9-877b48d74beb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95747e3-80c2-4261-a1dc-e3e0dd773d57");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Cpf", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "Rg", "SecurityStamp", "Telefone", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "0cd1cefe-8d05-43e5-a873-d0950dc60d52", 0, "5f9495f9-c121-4723-b70c-c8b2f2966fc5", "818708025", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEI8YgU6LAaKntPFvmI5DRFEEzb6X5UK0yUL30LNhTQPkUTatDGh2A+unBt6D/XwnXw==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(2621), "7750570", "", "(79) 964919636", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "0ec18f49-c71a-4c09-b107-7ca97d7cde73", 0, "9ddcf0ec-1558-4af6-9416-17a84ab200bf", "413188397", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEHKlnk3l08DsN90bWNXQ93iuhLR3vPLoc4SYrqGxEeZ1/mjN+Lx1GjZTztCZ6QGbqA==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(4790), "4631346", "", "(79) 984503567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "32bd932b-17dc-4776-8d19-47aa6e507cd8", 0, "4a59cda5-d790-467a-b11c-3c27421c840e", "921780754", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEJZT1ZjjrscwrbzxyWrbL9VuyUDK/p86A0NLSqDKmVW4XbTK+wd/BKccWHoLzL47RA==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1371), "9644407", "", "(79) 965936398", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e", 0, "86bf45e1-a92f-46ec-9402-e63647eb7b96", "475554808", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAELuteqUNZr/Wnx5ObAZJj7lskxEwDwF/VHQkTzLZZtZ6+JZQkOBsfIQ8psv+/a1+pw==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 7, DateTimeKind.Local).AddTicks(5431), "2837147", "", "(79) 931325570", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "44d5957f-8de6-43ae-9514-73b4648aa004", 0, "0f4c2362-bfe7-437d-bd13-59d45cd7c9a3", "480042652", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEN10xrLqdf9IKwXyvsYifjid7zJuuWjMG1Vp9kJ+wHh3ZuePNzNDE69alrUmF6/ivg==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 156, DateTimeKind.Local).AddTicks(528), "3953747", "", "(79) 970836070", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "48da0069-7d68-4a2e-9759-118abfd9e539", 0, "d1386a94-aa6f-4ea4-b6c5-131a81f07d39", "934720815", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK7QqZ5WOuLUIxwC7r3RJtj8+yxqoOasvJ6NW6C/fo6LpgXFs1A+4xV+1UssziZwPg==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9010), "8844343", "", "(79) 985644652", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "7f134669-b7c8-40d6-836d-2456f41b6dcc", 0, "7d43fd16-0542-48bc-bfdf-932ad063c97a", "126573043", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEF8f0gvllKp80FONBr19OX12+usePwL1QrN7+75mvQ4AZR2IwxzUFjdIqjZD3FVLrw==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1392), "9437038", "", "(79) 994777128", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9", 0, "c71330cd-4d5e-410c-98d8-2645bdfa0ed7", "100658849", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEKaoUeEaBduST8EhhWUnyja1LeoJwjoy0s5xLvHisrcmftXq9PlBo11U4Xl0GEARSA==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 80, DateTimeKind.Local).AddTicks(2620), "2936999", "", "(79) 919320255", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "9521118d-9c5a-4651-b69a-d56b0d6ce982", 0, "8175b587-3cd5-4a21-9bd1-09f39ace0e90", "806596778", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEG1hOY+nDhYkcXZAzDrIKwwnIf7hIsTzgNXAyE7PBAfXyDANerdWuXEnSEmjkcEk5g==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 227, DateTimeKind.Local).AddTicks(5228), "7467661", "", "(79) 993187834", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "9b3d79ac-d16e-4ebc-804b-f34fd976ffee", 0, "692f0ca0-d866-4b74-80cf-28da1cdae462", "717440467", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEJtjQ4HSQ0AdIjLOagRYfVnvduMWKx0PJdg2zbk7ZHOEWaSytQaV0f2dPoL8GSHqaA==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 292, DateTimeKind.Local).AddTicks(6756), "6883109", "", "(79) 984500412", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" },
                    { "9e7d866b-3b8a-4f95-a351-3cd241ebc475", 0, "11765411-d91d-4a4f-bc5f-c18631920d90", "179523941", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEIrArRP67+oXQgYBTUGqFuvr4ozSMBjylP3xasR+j+2vEFEF3dB77D3OHbUe8+OBIA==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 41, 936, DateTimeKind.Local).AddTicks(4667), "4899908", "", "(79) 924090560", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", 0, "d9e3909b-3984-470f-9c0d-c3c45f35af0e", "433126107", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEN8DWkvdc6itQW0re1dL1yvxDxMkW+r+gXdjztqyniEBQV8gQVDMt19Uw/Jp4+U+lQ==", null, false, "", new DateTime(2024, 5, 20, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(5976), "7735958", "", "(79) 924205586", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0cd1cefe-8d05-43e5-a873-d0950dc60d52" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0ec18f49-c71a-4c09-b107-7ca97d7cde73" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "32bd932b-17dc-4776-8d19-47aa6e507cd8" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "44d5957f-8de6-43ae-9514-73b4648aa004" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "48da0069-7d68-4a2e-9759-118abfd9e539" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7f134669-b7c8-40d6-836d-2456f41b6dcc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9521118d-9c5a-4651-b69a-d56b0d6ce982" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9e7d866b-3b8a-4f95-a351-3cd241ebc475" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" },
                    { "32bd932b-17dc-4776-8d19-47aa6e507cd8", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "48da0069-7d68-4a2e-9759-118abfd9e539", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "7f134669-b7c8-40d6-836d-2456f41b6dcc", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" },
                    { "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao", "Especialidade" },
                values: new object[,]
                {
                    { "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2", "Terceira Especialidade" },
                    { "44d5957f-8de6-43ae-9514-73b4648aa004", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4", "Terapia Cognitivo Comportamental" },
                    { "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3", "Terceira Especialidade" },
                    { "9521118d-9c5a-4651-b69a-d56b0d6ce982", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5", "Terapia Cognitivo Comportamental" },
                    { "9b3d79ac-d16e-4ebc-804b-f34fd976ffee", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6", "Psicanálise" },
                    { "9e7d866b-3b8a-4f95-a351-3cd241ebc475", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1", "Terceira Especialidade" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Data", "PacienteId", "PsicologoId", "Comentario", "DataFim", "DataInicio", "Nota" },
                values: new object[,]
                {
                    { new DateTime(2024, 5, 19, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3117), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 438, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 5, 19, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3133), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3178), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3209), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e", null, null, null, null },
                    { new DateTime(2024, 5, 19, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5316), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 581, DateTimeKind.Local).AddTicks(5339), new DateTime(2024, 5, 19, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5334), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5374), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5382), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004", null, null, null, null },
                    { new DateTime(2024, 5, 19, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(6552), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 510, DateTimeKind.Local).AddTicks(6714), new DateTime(2024, 5, 19, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(6698), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(8565), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(8615), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9", null, null, null, null },
                    { new DateTime(2024, 5, 19, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1693), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 649, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 5, 19, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1698), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1723), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1726), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982", null, null, null, null },
                    { new DateTime(2024, 5, 19, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9242), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 713, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 5, 19, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9247), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9276), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9291), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee", null, null, null, null },
                    { new DateTime(2024, 5, 19, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1927), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475", "Consulta concluída", new DateTime(2024, 5, 19, 18, 27, 42, 372, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 5, 19, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1947), 10 },
                    { new DateTime(2024, 5, 20, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1984), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475", null, null, null, null },
                    { new DateTime(2024, 5, 21, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(2005), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3117), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3178), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 438, DateTimeKind.Local).AddTicks(3209), "0cd1cefe-8d05-43e5-a873-d0950dc60d52", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5316), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5374), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 581, DateTimeKind.Local).AddTicks(5382), "0ec18f49-c71a-4c09-b107-7ca97d7cde73", "44d5957f-8de6-43ae-9514-73b4648aa004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(6552), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(8565), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 510, DateTimeKind.Local).AddTicks(8615), "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1693), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1723), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 649, DateTimeKind.Local).AddTicks(1726), "7f134669-b7c8-40d6-836d-2456f41b6dcc", "9521118d-9c5a-4651-b69a-d56b0d6ce982" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9242), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9276), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 713, DateTimeKind.Local).AddTicks(9291), "48da0069-7d68-4a2e-9759-118abfd9e539", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 19, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1927), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 20, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(1984), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Data", "PacienteId", "PsicologoId" },
                keyValues: new object[] { new DateTime(2024, 5, 21, 17, 27, 42, 372, DateTimeKind.Local).AddTicks(2005), "32bd932b-17dc-4776-8d19-47aa6e507cd8", "9e7d866b-3b8a-4f95-a351-3cd241ebc475" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0cd1cefe-8d05-43e5-a873-d0950dc60d52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0ec18f49-c71a-4c09-b107-7ca97d7cde73" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "32bd932b-17dc-4776-8d19-47aa6e507cd8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "44d5957f-8de6-43ae-9514-73b4648aa004" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "48da0069-7d68-4a2e-9759-118abfd9e539" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7f134669-b7c8-40d6-836d-2456f41b6dcc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9521118d-9c5a-4651-b69a-d56b0d6ce982" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9b3d79ac-d16e-4ebc-804b-f34fd976ffee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "9e7d866b-3b8a-4f95-a351-3cd241ebc475" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "0cd1cefe-8d05-43e5-a873-d0950dc60d52");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "0ec18f49-c71a-4c09-b107-7ca97d7cde73");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "32bd932b-17dc-4776-8d19-47aa6e507cd8");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "48da0069-7d68-4a2e-9759-118abfd9e539");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "7f134669-b7c8-40d6-836d-2456f41b6dcc");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "44d5957f-8de6-43ae-9514-73b4648aa004");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "9521118d-9c5a-4651-b69a-d56b0d6ce982");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "9b3d79ac-d16e-4ebc-804b-f34fd976ffee");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "9e7d866b-3b8a-4f95-a351-3cd241ebc475");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cd1cefe-8d05-43e5-a873-d0950dc60d52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ec18f49-c71a-4c09-b107-7ca97d7cde73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32bd932b-17dc-4776-8d19-47aa6e507cd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f5942f4-6e3d-4bc1-8c88-2f6b34504e2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44d5957f-8de6-43ae-9514-73b4648aa004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48da0069-7d68-4a2e-9759-118abfd9e539");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f134669-b7c8-40d6-836d-2456f41b6dcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9410327a-d9a2-4c17-87ea-c7ec61e2c3b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9521118d-9c5a-4651-b69a-d56b0d6ce982");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b3d79ac-d16e-4ebc-804b-f34fd976ffee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e7d866b-3b8a-4f95-a351-3cd241ebc475");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7ff103-cb8f-4324-8fa6-e27bf56dd31b");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "EnderecoCompleto", "FotoPerfil", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName", "role" },
                values: new object[,]
                {
                    { "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", 0, "a6de829b-e778-428e-aa6e-335e4cf49779", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, "Endereço 9", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEKCSHLRmtmCeoGuGnXC0U8YZ+ls/sWNhrgTVgpmyCg4f1MVQxWKinOoQz4QPY7UmIA==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2603), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9", "Paciente" },
                    { "2f4106df-6cee-42f9-a22e-8d65d994b824", 0, "7a77f1bd-86f2-4e4b-91c0-9085ee0dbe62", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, "Endereço 7", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEOfGFacpw09n3+28EABxZ9b0TOE9IRvRnXZVt/psUElfH95ynPoav7Eb7E6lEcK5/A==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(3275), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7", "Paciente" },
                    { "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", 0, "5201e473-d91d-4313-b640-1cf9389c66a5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, "Endereço 8", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEKDiHGE3J5JYdihUp8zZFlAbxnsITjHNfO/7l4muZp4/JNd6t2lVeOULhgWtEwwD/Q==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(3780), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8", "Paciente" },
                    { "46cc5a6f-e612-42ca-a969-bb6ca507ec71", 0, "3b5611ab-5b4d-4967-b861-54c59df6273c", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, "Endereço 1", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEBEdKhIHzg+cHbkXbHRZbiYFXsbp30+El9H7ASVpE7/igYieVZbAT+ug3NX+m1eShA==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 12, 877, DateTimeKind.Local).AddTicks(2043), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1", "Psicologo" },
                    { "66a805db-f7f6-4948-8558-1c2abdd7cf2c", 0, "1dfbb251-d112-431b-839a-ceb1d96bcd1f", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, "Endereço 4", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEKm/VvDEvmv+9z+xd7rXD14Zk80eT6I2A5RKDEj0kYaOqSO0ANQBM2eFKLwtEb1Vcg==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 155, DateTimeKind.Local).AddTicks(8816), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4", "Psicologo" },
                    { "767351ac-1687-46d0-b7fe-9e64f801c009", 0, "61559cea-4d23-41a8-a497-6e8ec22a18ec", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, "Endereço 2", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEDLt+nazC4rD5s1mGpaagwauwPpDyRfIRsbOKH+eD6KSPMJkTJON8G0+k8tR/0zx5Q==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 12, 959, DateTimeKind.Local).AddTicks(615), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2", "Psicologo" },
                    { "a58404da-ceff-4fd2-9ec4-d749a0e136f7", 0, "ef854e53-8ff9-4cfd-985e-33a2515a0516", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, "Endereço 5", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEH9SO2QLksXnBdBMbw27exCszdFBQ2kw5ZWV9adN5gauMs63BznVF05wnZvbz2QpSg==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 243, DateTimeKind.Local).AddTicks(7985), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5", "Psicologo" },
                    { "b7deb289-28b8-4cb6-8f0d-c1845aff8421", 0, "860284d2-f029-4e0a-bf3c-a82b0c3fd67c", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, "Endereço 10", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEMQje7LpS6942OVlz6a2eYklFn4sxqMmi3d0a9m1/00eY5BDEzqFQriEUANDFUlogg==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(4211), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10", "Paciente" },
                    { "d008bf53-5d61-41de-96e9-877b48d74beb", 0, "3a287d6c-f269-4cf7-a46f-35549a406474", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, "Endereço 12", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAENJiCEOSWBxrlUdkyha7Rw1x9kORPOcDdqPqK+nW+XQXia0oWs2zt4i+rFxP79mrSQ==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(5555), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12", "Paciente" },
                    { "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9", 0, "a393567d-d563-4945-9aa0-ca61462ecfa2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, "Endereço 3", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAED/m4L9r+bU3yefnPC4xp3SOydjgKkVzTs8GO++KB5ZkA3kCjXCDiqilcpxZmBtrAw==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 54, DateTimeKind.Local).AddTicks(7386), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3", "Psicologo" },
                    { "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", 0, "c72de184-130a-4175-8ac8-9545d79bbf5b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, "Endereço 11", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAENZuGBm17KGCkACKUs63bCQgsye2oSJ+SYKrR2Zl0eJLLGTSucHIJSlibXxupdPipA==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(4790), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11", "Paciente" },
                    { "f95747e3-80c2-4261-a1dc-e3e0dd773d57", 0, "4af890f6-c2cc-45b7-aa00-6f9930d74a1a", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, "Endereço 6", "https://static.vecteezy.com/system/resources/previews/009/397/835/non_2x/man-avatar-clipart-illustration-free-png.png", null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEGKQZJ2Ytpk0xvn2Fu9GXkSeeBmv+ROtrSdN32NbNbndisFM5L9uCDb9GdXluu+NEg==", null, false, "", new DateTime(2024, 5, 15, 13, 1, 13, 327, DateTimeKind.Local).AddTicks(9966), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6", "Psicologo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2f4106df-6cee-42f9-a22e-8d65d994b824" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3f38348a-bf9d-4ed5-97af-a09cc965ca2e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "46cc5a6f-e612-42ca-a969-bb6ca507ec71" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "66a805db-f7f6-4948-8558-1c2abdd7cf2c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "767351ac-1687-46d0-b7fe-9e64f801c009" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "a58404da-ceff-4fd2-9ec4-d749a0e136f7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b7deb289-28b8-4cb6-8f0d-c1845aff8421" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d008bf53-5d61-41de-96e9-877b48d74beb" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f95747e3-80c2-4261-a1dc-e3e0dd773d57" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Cid", "ComprovanteResidencia", "CrmMedico", "FotoRgFrente", "FotoRgVerso", "NomeMedico", "PDFFormatado", "RelatorioMedico", "UfCrm" },
                values: new object[,]
                {
                    { "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "CID-9", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 57 }, 9, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 57 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 57 }, "Medico 9", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 57 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 57 }, "UF-9" },
                    { "2f4106df-6cee-42f9-a22e-8d65d994b824", "CID-7", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 55 }, 7, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 55 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 55 }, "Medico 7", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 55 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 55 }, "UF-7" },
                    { "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "CID-8", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 56 }, 8, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 56 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 56 }, "Medico 8", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 56 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 56 }, "UF-8" },
                    { "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "CID-10", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 48 }, 10, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 48 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 48 }, "Medico 10", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 48 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 48 }, "UF-10" },
                    { "d008bf53-5d61-41de-96e9-877b48d74beb", "CID-12", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 50 }, 12, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 50 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 50 }, "Medico 12", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 50 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 50 }, "UF-12" },
                    { "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "CID-11", new byte[] { 67, 111, 109, 112, 114, 111, 118, 97, 110, 116, 101, 32, 82, 101, 115, 105, 100, 101, 110, 99, 105, 97, 32, 49, 49 }, 11, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 70, 114, 101, 110, 116, 101, 32, 49, 49 }, new byte[] { 70, 111, 116, 111, 32, 82, 71, 32, 86, 101, 114, 115, 111, 32, 49, 49 }, "Medico 11", new byte[] { 80, 68, 70, 32, 70, 111, 114, 109, 97, 116, 97, 100, 111, 32, 49, 49 }, new byte[] { 82, 101, 108, 97, 116, 111, 114, 105, 111, 32, 77, 101, 100, 105, 99, 111, 32, 49, 49 }, "UF-11" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CarteiraCrp", "Crp", "Descricao", "Especialidade" },
                values: new object[,]
                {
                    { "46cc5a6f-e612-42ca-a969-bb6ca507ec71", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 49 }, "CRP-1", "Psicologo 1", "Terceira Especialidade" },
                    { "66a805db-f7f6-4948-8558-1c2abdd7cf2c", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 52 }, "CRP-4", "Psicologo 4", "Terapia Cognitivo Comportamental" },
                    { "767351ac-1687-46d0-b7fe-9e64f801c009", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 50 }, "CRP-2", "Psicologo 2", "Terceira Especialidade" },
                    { "a58404da-ceff-4fd2-9ec4-d749a0e136f7", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 53 }, "CRP-5", "Psicologo 5", "Psicanálise" },
                    { "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 51 }, "CRP-3", "Psicologo 3", "Terceira Especialidade" },
                    { "f95747e3-80c2-4261-a1dc-e3e0dd773d57", new byte[] { 67, 97, 114, 116, 101, 105, 114, 97, 32, 67, 82, 80, 32, 54 }, "CRP-6", "Psicologo 6", "Psicanálise" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Data", "PacienteId", "PsicologoId", "Comentario", "DataFim", "DataInicio", "Nota" },
                values: new object[,]
                {
                    { new DateTime(2024, 5, 14, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4108), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 414, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 5, 14, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4144), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4189), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 414, DateTimeKind.Local).AddTicks(4199), "2f4106df-6cee-42f9-a22e-8d65d994b824", "46cc5a6f-e612-42ca-a969-bb6ca507ec71", null, null, null, null },
                    { new DateTime(2024, 5, 14, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5320), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 631, DateTimeKind.Local).AddTicks(5336), new DateTime(2024, 5, 14, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5323), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5352), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 631, DateTimeKind.Local).AddTicks(5357), "b7deb289-28b8-4cb6-8f0d-c1845aff8421", "66a805db-f7f6-4948-8558-1c2abdd7cf2c", null, null, null, null },
                    { new DateTime(2024, 5, 14, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4321), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 494, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 5, 14, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4338), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4520), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 494, DateTimeKind.Local).AddTicks(4550), "3f38348a-bf9d-4ed5-97af-a09cc965ca2e", "767351ac-1687-46d0-b7fe-9e64f801c009", null, null, null, null },
                    { new DateTime(2024, 5, 14, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5378), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 714, DateTimeKind.Local).AddTicks(5415), new DateTime(2024, 5, 14, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5388), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5457), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 714, DateTimeKind.Local).AddTicks(5465), "d6d527ad-d610-40d6-9f8b-0da55ba1d2e2", "a58404da-ceff-4fd2-9ec4-d749a0e136f7", null, null, null, null },
                    { new DateTime(2024, 5, 14, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2826), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 565, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 5, 14, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2838), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2860), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 565, DateTimeKind.Local).AddTicks(2950), "10c0fcd0-efa0-453f-bdfd-9dc231bdea0d", "d26a8f97-bfc2-4cdc-b3c0-b9fa998ad5f9", null, null, null, null },
                    { new DateTime(2024, 5, 14, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(5958), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57", "Consulta concluída", new DateTime(2024, 5, 14, 14, 1, 13, 799, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 5, 14, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(5963), 10 },
                    { new DateTime(2024, 5, 15, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(6142), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57", null, null, null, null },
                    { new DateTime(2024, 5, 16, 13, 1, 13, 799, DateTimeKind.Local).AddTicks(6272), "d008bf53-5d61-41de-96e9-877b48d74beb", "f95747e3-80c2-4261-a1dc-e3e0dd773d57", null, null, null, null }
                });
        }
    }
}
