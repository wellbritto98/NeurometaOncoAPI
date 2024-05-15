using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeurometaOncoAPI.Migrations
{
    /// <inheritdoc />
    public partial class novasagendas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
