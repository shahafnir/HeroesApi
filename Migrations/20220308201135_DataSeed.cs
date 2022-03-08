using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroesApi.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("1ea3e760-627d-4776-a179-261a475c501c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("1ea3e760-627d-4776-a179-261a475c501c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("4e417a5e-1af1-47f2-8450-279deade854b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("4e417a5e-1af1-47f2-8450-279deade854b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("be332150-c0c1-4bca-a049-e7903c575ea5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("be332150-c0c1-4bca-a049-e7903c575ea5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda") });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1ea3e760-627d-4776-a179-261a475c501c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4e417a5e-1af1-47f2-8450-279deade854b"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("be332150-c0c1-4bca-a049-e7903c575ea5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10a3b944-12de-4f82-878e-a1f1c8f22218");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "157ec0cd-d5b3-4fef-b97f-3fc6bf507447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9276c43b-1aff-4aa7-9a46-95e77eb08fbe");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "12ebb199-20ce-4eaf-b39c-7d7492877af6", 0, "d1bdcf4d-b884-499f-95cf-f62b1aa16992", "user1@example.com", false, "Moshe", "Cohen", true, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOcFTsgZYz8/P7PlFt/dW+3X6JLD0GDTcyXNM79ZtXUC7yH6vTr2m8+go8ONii3mCg==", null, false, "6a721693-0275-448e-abd1-1d91c0661962", false, "user1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62786193-15ce-4c5b-be9e-dff0e17fb15b", 0, "5d90166e-f9b0-4e21-86d5-b635b452fcfc", "user3@example.com", false, "Sholomo", "Daniel", true, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL+JgMo2bF4pBibprCKbRwYx/HNA1sp2Q9NI0N9QpjcK5x8VjAp5Jv1E8OsXgtb5Sw==", null, false, "d5c9bab0-1766-4b0b-baac-311ea35ce1c5", false, "user3@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 0, "0bf91b64-4aa9-4964-ba81-a1c3914bca51", "user2@example.com", false, "Keren", "David", true, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMo1s3Tb+3J5OhWvVSOuRWqYiYLGJ+s7tmtaGlc8UQ7pGARbF7VUN1GkX5mhOMx1rA==", null, false, "f6670aaa-ff05-4427-958f-ffe1b08bb152", false, "user2@example.com" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "ApplicationUserId", "CurrentPower", "Name", "StartedTrainingAt", "StartingPower" },
                values: new object[,]
                {
                    { new Guid("0515d54c-6203-401b-8688-215eabe8c97e"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 41m, "Black Widow", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8819), 41m },
                    { new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15"), "Attacker", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 35m, "Bane", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8975), 35m },
                    { new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5"), "Attacker", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 35m, "Scarlet Witch", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8828), 35m },
                    { new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26"), "Defender", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 43m, "The Punisher", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8864), 43m },
                    { new Guid("17cca59e-e2d7-4f53-ae8d-952297151463"), "Defender", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 50m, "Super-Girl", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(9035), 50m },
                    { new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65"), "Attacker", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 40m, "Dr. Strange", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8723), 40m },
                    { new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee"), "Defender", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 30m, "Star Lord", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8914), 30m },
                    { new Guid("364e91be-f233-4690-877a-7a0382f703cf"), "Defender", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 33m, "Hela", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(9006), 33m },
                    { new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024"), "Attacker", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 46m, "The Hulk", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8872), 46m },
                    { new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 45m, "Captain America", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8763), 45m },
                    { new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748"), "Attacker", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 43m, "She-Hulk", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(9013), 43m },
                    { new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 40m, "Iron-Man", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8754), 40m },
                    { new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8"), "Attacker", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 35m, "Bat-Man", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8958), 35m },
                    { new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a"), "Attacker", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 44m, "Spider-Man", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8857), 44m },
                    { new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f"), "Attacker", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 50m, "Adam Warlock", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8991), 50m },
                    { new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7"), "Attacker", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 47m, "Thanos", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8744), 47m },
                    { new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6"), "Defender", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 45m, "Dr. Doom", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(9021), 45m },
                    { new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 30m, "Thor", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8773), 30m },
                    { new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 32m, "Pheonix", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8848), 32m },
                    { new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9"), "Defender", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 48m, "Super-Man", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8921), 48m },
                    { new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684"), "Attacker", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 45m, "Wolverine", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8879), 45m },
                    { new Guid("b33596a1-d057-45db-8d05-351b709a3dd8"), "Attacker", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 50m, "Ant-Man", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8887), 50m },
                    { new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e"), "Attacker", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 40m, "Loki", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8999), 40m },
                    { new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2"), "Attacker", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 42m, "The Joker", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8967), 42m },
                    { new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606"), "Defender", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 33m, "Black Panther", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8897), 33m },
                    { new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 35m, "Captain Marvel", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8837), 35m },
                    { new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0"), "Defender", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 40m, "Bat-Girl", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(9028), 40m },
                    { new Guid("f1500394-f6e9-48ec-8966-f02129a6f736"), "Defender", "b4dd9b01-acdb-4d17-855a-aeef45bb0892", 36m, "Venom", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8905), 36m },
                    { new Guid("fac2a098-7438-4778-819d-7109d81abacd"), "Defender", "62786193-15ce-4c5b-be9e-dff0e17fb15b", 36m, "Wonder Woman", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8982), 36m },
                    { new Guid("fce6821a-9198-4e86-bf05-e718f5afd204"), "Defender", "12ebb199-20ce-4eaf-b39c-7d7492877af6", 38m, "Deadpool", new DateTime(2022, 3, 8, 20, 11, 35, 312, DateTimeKind.Utc).AddTicks(8734), 38m }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Brown", new Guid("0515d54c-6203-401b-8688-215eabe8c97e") },
                    { "Red", new Guid("0515d54c-6203-401b-8688-215eabe8c97e") },
                    { "Pink", new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15") },
                    { "Red", new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15") },
                    { "Orange", new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5") },
                    { "White", new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5") },
                    { "Orange", new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26") },
                    { "Pink", new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26") },
                    { "Brown", new Guid("17cca59e-e2d7-4f53-ae8d-952297151463") },
                    { "Pink", new Guid("17cca59e-e2d7-4f53-ae8d-952297151463") },
                    { "Brown", new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65") },
                    { "Orange", new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65") },
                    { "Brown", new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee") },
                    { "Green", new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee") },
                    { "Orange", new Guid("364e91be-f233-4690-877a-7a0382f703cf") },
                    { "Red", new Guid("364e91be-f233-4690-877a-7a0382f703cf") },
                    { "Blue", new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024") },
                    { "Brown", new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024") },
                    { "Orange", new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657") },
                    { "White", new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657") },
                    { "Orange", new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748") },
                    { "White", new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748") },
                    { "Orange", new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6") },
                    { "Silver", new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6") },
                    { "Blue", new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8") },
                    { "Red", new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8") },
                    { "Green", new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a") },
                    { "White", new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a") },
                    { "Brown", new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f") },
                    { "Red", new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f") },
                    { "Green", new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7") },
                    { "White", new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7") },
                    { "Purple", new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6") },
                    { "Silver", new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6") },
                    { "Pink", new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d") },
                    { "Silver", new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d") },
                    { "Brown", new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237") },
                    { "Purple", new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237") },
                    { "Black", new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9") },
                    { "Brown", new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9") },
                    { "Pink", new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684") },
                    { "Purple", new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684") }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Gold", new Guid("b33596a1-d057-45db-8d05-351b709a3dd8") },
                    { "Red", new Guid("b33596a1-d057-45db-8d05-351b709a3dd8") },
                    { "Green", new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e") },
                    { "White", new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e") },
                    { "Purple", new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2") },
                    { "Yellow", new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2") },
                    { "Brown", new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606") },
                    { "Silver", new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606") },
                    { "Green", new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c") },
                    { "Silver", new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c") },
                    { "Blue", new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0") },
                    { "Pink", new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0") },
                    { "Purple", new Guid("f1500394-f6e9-48ec-8966-f02129a6f736") },
                    { "Yellow", new Guid("f1500394-f6e9-48ec-8966-f02129a6f736") },
                    { "Blue", new Guid("fac2a098-7438-4778-819d-7109d81abacd") },
                    { "Orange", new Guid("fac2a098-7438-4778-819d-7109d81abacd") },
                    { "Gold", new Guid("fce6821a-9198-4e86-bf05-e718f5afd204") },
                    { "Silver", new Guid("fce6821a-9198-4e86-bf05-e718f5afd204") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("0515d54c-6203-401b-8688-215eabe8c97e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("0515d54c-6203-401b-8688-215eabe8c97e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("17cca59e-e2d7-4f53-ae8d-952297151463") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("17cca59e-e2d7-4f53-ae8d-952297151463") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("364e91be-f233-4690-877a-7a0382f703cf") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("364e91be-f233-4690-877a-7a0382f703cf") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("b33596a1-d057-45db-8d05-351b709a3dd8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("b33596a1-d057-45db-8d05-351b709a3dd8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("f1500394-f6e9-48ec-8966-f02129a6f736") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("f1500394-f6e9-48ec-8966-f02129a6f736") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("fac2a098-7438-4778-819d-7109d81abacd") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("fac2a098-7438-4778-819d-7109d81abacd") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("fce6821a-9198-4e86-bf05-e718f5afd204") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("fce6821a-9198-4e86-bf05-e718f5afd204") });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0515d54c-6203-401b-8688-215eabe8c97e"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0b4d29d1-b3e4-4872-8f50-8c57b0de7f15"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("162ec52a-7fa0-4479-9743-313fb078bfd5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("16c4ae8c-7ac0-44b4-a14c-3702bb9cef26"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("17cca59e-e2d7-4f53-ae8d-952297151463"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1f9f1c5b-a8f6-4f3c-bda9-b526db09bf65"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("26f81fbd-3de8-4a95-aabf-4d555230e1ee"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("364e91be-f233-4690-877a-7a0382f703cf"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4a1315b3-5b82-4ff5-8d5c-78376274a024"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4fc3a829-b9c4-4c40-8ea4-6a4556731657"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("511a0da2-f6db-4cce-8c70-71a36bd61748"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("519e5d81-f984-4dce-b3dd-f234ecf8f7a6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("583b8c19-d2f4-4b5a-a5c3-4237a43e19a8"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5971e187-2092-4e7e-b41f-5088d90b4b5a"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5b6c9bc5-0e1d-41b6-99c4-4ba6f6c6f22f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6a4a57ce-dcf2-4fc8-a910-eb7d63c674f7"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6b6f40bd-67c9-43f7-91ed-745c0bea01c6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6bf34c4c-bc58-48cc-a88b-77c054a5f16d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("72d05fb9-9a9a-4679-85e5-6947a42a7237"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9d09fe7c-5efa-4100-ab4c-825a9ae058a9"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9e38dcaf-6f3d-425f-af2b-9dde72d3d684"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("b33596a1-d057-45db-8d05-351b709a3dd8"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c690b45c-93a6-43f5-972b-e2c242fc011e"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c74ea23f-8d15-43e8-bee5-0eafa8e176d2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("cf1d1642-d725-47a1-bcf9-8101f6ee4606"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e77f19b9-960d-4e8d-aac7-f4fc84c75d7c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("ed35fa6a-8763-45ed-8579-9907c5c6a0a0"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f1500394-f6e9-48ec-8966-f02129a6f736"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fac2a098-7438-4778-819d-7109d81abacd"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fce6821a-9198-4e86-bf05-e718f5afd204"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ebb199-20ce-4eaf-b39c-7d7492877af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62786193-15ce-4c5b-be9e-dff0e17fb15b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4dd9b01-acdb-4d17-855a-aeef45bb0892");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10a3b944-12de-4f82-878e-a1f1c8f22218", 0, "e255d1ca-f7c3-4aae-9b0d-5ec4e6c4b82d", "user3@example.com", false, "Sholomo", "Daniel", false, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGxwYe2Z7aEmaIwpWQBbrGj/TL1Q+LmUrovnirdnWUEjlDcsh+exYZneBy0rnVg8Fw==", null, false, "4a1d77e6-0599-44f9-81db-0ca0881f2c65", false, "user3@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 0, "a640f292-1e0a-4a62-bf10-a895b997e47e", "user1@example.com", false, "Moshe", "Cohen", false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMoHaYgdi9Wig7ntPHsPcQH+o8npcAFwww+cq8DGs+w2fj/UT+A0b2GXxOTwRRaqTA==", null, false, "0adf64fe-c9c4-4db4-960b-71d365069455", false, "user1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 0, "328826ff-635a-4b00-9f7d-f779ed9441b7", "user2@example.com", false, "Keren", "David", false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEINHnOj8v16VkgrsqNOz7qy4rb/RTWeQBgtORAPQg+DEhkX3vkeZg3USxVy6/1i9jA==", null, false, "baa71003-337b-4559-8f65-3c2ea808bddb", false, "user2@example.com" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "ApplicationUserId", "CurrentPower", "Name", "StartedTrainingAt", "StartingPower" },
                values: new object[,]
                {
                    { new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 36m, "Hela", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4741), 36m },
                    { new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 34m, "Ant-Man", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4618), 34m },
                    { new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 47m, "Super-Girl", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4778), 47m },
                    { new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd"), "Defender", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 50m, "Spider-Man", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4528), 50m },
                    { new Guid("1ea3e760-627d-4776-a179-261a475c501c"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 35m, "Wolverine", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4611), 35m },
                    { new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652"), "Attacker", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 36m, "Deadpool", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4445), 36m },
                    { new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 49m, "Dr. Doom", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4759), 49m },
                    { new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be"), "Defender", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 36m, "Black Widow", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4493), 36m },
                    { new Guid("4e417a5e-1af1-47f2-8450-279deade854b"), "Attacker", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 36m, "Iron-Man", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4464), 36m },
                    { new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825"), "Attacker", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 35m, "Dr. Strange", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4434), 35m },
                    { new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f"), "Attacker", "10a3b944-12de-4f82-878e-a1f1c8f22218", 35m, "Wonder Woman", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4685), 35m },
                    { new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61"), "Defender", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 33m, "Bat-Man", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4662), 33m },
                    { new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97"), "Attacker", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 34m, "Captain Marvel", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4509), 34m },
                    { new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d"), "Defender", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 50m, "Black Panther", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4626), 50m },
                    { new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 30m, "Super-Man", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4654), 30m },
                    { new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f"), "Defender", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 34m, "Venom", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4635), 34m },
                    { new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c"), "Defender", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 32m, "Thanos", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4456), 32m },
                    { new Guid("be332150-c0c1-4bca-a049-e7903c575ea5"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 32m, "The Punisher", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4594), 32m },
                    { new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 37m, "Bane", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4677), 37m },
                    { new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec"), "Defender", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 44m, "Scarlet Witch", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4501), 44m },
                    { new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 33m, "Star Lord", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4644), 33m },
                    { new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31"), "Attacker", "9276c43b-1aff-4aa7-9a46-95e77eb08fbe", 36m, "The Hulk", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4603), 36m },
                    { new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 44m, "Loki", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4701), 44m },
                    { new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 48m, "Bat-Girl", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4769), 48m },
                    { new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee"), "Attacker", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 34m, "Captain America", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4475), 34m },
                    { new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608"), "Defender", "10a3b944-12de-4f82-878e-a1f1c8f22218", 50m, "Adam Warlock", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4693), 50m },
                    { new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86"), "Defender", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 34m, "Pheonix", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4518), 34m },
                    { new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5"), "Defender", "157ec0cd-d5b3-4fef-b97f-3fc6bf507447", 44m, "Thor", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4485), 44m },
                    { new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641"), "Attacker", "10a3b944-12de-4f82-878e-a1f1c8f22218", 35m, "She-Hulk", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4751), 35m },
                    { new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda"), "Attacker", "10a3b944-12de-4f82-878e-a1f1c8f22218", 47m, "The Joker", new DateTime(2022, 3, 8, 20, 7, 19, 645, DateTimeKind.Utc).AddTicks(4670), 47m }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Silver", new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb") },
                    { "Yellow", new Guid("003da4c0-a231-4e23-8cd0-b58165a88acb") },
                    { "Blue", new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8") },
                    { "Brown", new Guid("081fb833-d5f5-4ad6-8d16-08b08840cda8") },
                    { "Blue", new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189") },
                    { "Purple", new Guid("0aeec32b-56ba-470c-aaf4-eaf50b473189") },
                    { "Gold", new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd") },
                    { "Green", new Guid("0ea098bb-bf14-40f9-9433-a4eaa3e92bbd") },
                    { "Black", new Guid("1ea3e760-627d-4776-a179-261a475c501c") },
                    { "Green", new Guid("1ea3e760-627d-4776-a179-261a475c501c") },
                    { "Black", new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652") },
                    { "Silver", new Guid("3223813e-785f-45f3-8c6e-c41ac05f6652") },
                    { "Green", new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5") },
                    { "Red", new Guid("354d4ac4-ed63-48dc-8970-f5997f8b44c5") },
                    { "Pink", new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be") },
                    { "Silver", new Guid("3631b6e0-06b4-45a0-8bac-0d1639c539be") },
                    { "Black", new Guid("4e417a5e-1af1-47f2-8450-279deade854b") },
                    { "Gold", new Guid("4e417a5e-1af1-47f2-8450-279deade854b") },
                    { "Silver", new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825") },
                    { "White", new Guid("5009170f-d336-48c9-837c-5ee4d0e7a825") },
                    { "Orange", new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f") },
                    { "White", new Guid("52bf9900-0ea5-4671-a72f-beb846f2425f") },
                    { "White", new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61") },
                    { "Yellow", new Guid("54b405b0-6298-4fb2-a139-499e1a58fb61") },
                    { "Orange", new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97") },
                    { "Yellow", new Guid("6ed1e498-1442-476a-ac9c-a2ee07e0df97") },
                    { "Green", new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d") },
                    { "Yellow", new Guid("79d98b90-c623-477d-8a5e-6c1b342c0d9d") },
                    { "Green", new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d") },
                    { "White", new Guid("99a53a55-85f4-4a0d-835e-6d1c14e8d12d") },
                    { "Gold", new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f") },
                    { "Pink", new Guid("ac10fa13-372f-4753-8063-7748c5ef3e9f") },
                    { "Orange", new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c") },
                    { "Yellow", new Guid("b73e39f6-2298-4af9-a97e-d94c30d9db2c") },
                    { "Brown", new Guid("be332150-c0c1-4bca-a049-e7903c575ea5") },
                    { "Gold", new Guid("be332150-c0c1-4bca-a049-e7903c575ea5") },
                    { "Orange", new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c") },
                    { "Silver", new Guid("beacb83d-9ed6-4ad5-b037-6607fad5fa7c") },
                    { "Red", new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec") },
                    { "White", new Guid("cbde091c-ff0b-44c3-b710-e3d4ed67ebec") },
                    { "Blue", new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2") },
                    { "Brown", new Guid("ced4b573-4bdf-4242-a793-ae520f5bdab2") }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Blue", new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31") },
                    { "Silver", new Guid("d4a776c7-d16c-44c9-9aff-dfa467247a31") },
                    { "Purple", new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31") },
                    { "Silver", new Guid("d971c4b8-89c1-494a-a2d1-50707a0dfd31") },
                    { "Red", new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6") },
                    { "White", new Guid("e5eb7791-dbe9-4c06-bfe5-d56d0b1d3eb6") },
                    { "Blue", new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee") },
                    { "Brown", new Guid("e9c1baec-f1e6-4cc4-9a02-6fcc0db917ee") },
                    { "Blue", new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608") },
                    { "Brown", new Guid("ebdb0bc0-c150-4452-86c0-18e240c81608") },
                    { "Gold", new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86") },
                    { "White", new Guid("f227bc5c-5a7d-4ea2-b324-474c34219e86") },
                    { "Black", new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5") },
                    { "Yellow", new Guid("f9dafeb2-8305-4b63-b1b8-9904d204d6a5") },
                    { "Black", new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641") },
                    { "Pink", new Guid("fa9def7e-3e6a-4740-9e60-f29c7891c641") },
                    { "Orange", new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda") },
                    { "White", new Guid("fad3629a-e75d-49f4-8ef6-a535efd9ccda") }
                });
        }
    }
}
