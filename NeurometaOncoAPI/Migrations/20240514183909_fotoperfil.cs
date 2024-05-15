using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class fotoperfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "26cbbda2-bcaa-4e73-b031-0953441bd130" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "2b19466e-9f6a-4e53-8f6c-e64a9ced3095" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3ed90f9b-e153-47c4-9c75-6945f5d1331c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "5eb0952c-09b9-4571-8b72-291d1479048d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "68a725a9-ab50-4361-9a91-83da20930103" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "6c1318e6-8a6a-4b70-a428-82b2df1dc76b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "726e52ab-2ec8-4f61-bbd5-ac13d8932108" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a7d2f15d-eff2-4e7d-a474-8afd8da95f21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c55e6da3-a002-421d-b864-7a3d76e64790" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "f7f70716-1ad4-433f-b853-dffa71ba3a2a" });

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "3ed90f9b-e153-47c4-9c75-6945f5d1331c");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "68a725a9-ab50-4361-9a91-83da20930103");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "6c1318e6-8a6a-4b70-a428-82b2df1dc76b");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "a7d2f15d-eff2-4e7d-a474-8afd8da95f21");

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: "c55e6da3-a002-421d-b864-7a3d76e64790");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "26cbbda2-bcaa-4e73-b031-0953441bd130");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "2b19466e-9f6a-4e53-8f6c-e64a9ced3095");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "5eb0952c-09b9-4571-8b72-291d1479048d");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "726e52ab-2ec8-4f61-bbd5-ac13d8932108");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48");

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: "f7f70716-1ad4-433f-b853-dffa71ba3a2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a49caec-57a9-4d92-b0e1-1f4dfbcaa71b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26cbbda2-bcaa-4e73-b031-0953441bd130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b19466e-9f6a-4e53-8f6c-e64a9ced3095");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ed90f9b-e153-47c4-9c75-6945f5d1331c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5eb0952c-09b9-4571-8b72-291d1479048d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68a725a9-ab50-4361-9a91-83da20930103");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1318e6-8a6a-4b70-a428-82b2df1dc76b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726e52ab-2ec8-4f61-bbd5-ac13d8932108");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7d2f15d-eff2-4e7d-a474-8afd8da95f21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2a56b59-1faf-4d2f-b8f5-0b4a4d05bd48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55e6da3-a002-421d-b864-7a3d76e64790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7f70716-1ad4-433f-b853-dffa71ba3a2a");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoPerfil",
                table: "AspNetUsers",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "role",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoPerfil",
                table: "AspNetUsers",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

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
        }
    }
}
