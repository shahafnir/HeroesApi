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
                values: new object[] { "690f8f27-48ce-439c-b9d8-d7905ae16028", 0, "abaffbcc-2fec-4801-97e2-f473d12a14d6", "user1@example.com", false, "Moshe", "Cohen", true, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEINEQLCPRroTwxTYIL0YJoxpaGMnTZUHWMfqvnQDbwRMbWGrzkSMueGRD9TbwDAgxQ==", null, false, "447bc8f5-75f9-4117-be3e-27f858358480", false, "user1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aaf0d392-1d51-4bc8-a308-58fe3376497d", 0, "c2698ecd-f700-44d6-ab1b-4c2a46d12813", "user3@example.com", false, "Sholomo", "Daniel", true, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMOrwUYqqVYD+n4Nk2KK68jiPLulPX5urPuZ1WELClB7qSxkn9ydOI9Xai10wc9gMA==", null, false, "c457909e-ecc6-4ce0-b22b-74be7ae2600f", false, "user3@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2283146-4b61-491e-8002-c361c52d9082", 0, "c00f76b8-5a94-444c-a323-b99e5450c6da", "user2@example.com", false, "Keren", "David", true, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIXUMnD0Zn3yv7SBJe6q2G4JaL7PtHfiRx0xRK6uJXIQ4LxJsE8ayz9dNVwgV1Z9pQ==", null, false, "de7a32fe-597f-47b0-97d2-cee361639adb", false, "user2@example.com" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "ApplicationUserId", "CurrentPower", "Name", "StartedTrainingAt", "StartingPower" },
                values: new object[,]
                {
                    { new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398"), "Defender", "690f8f27-48ce-439c-b9d8-d7905ae16028", 43m, "Pheonix", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6765), 43m },
                    { new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be"), "Defender", "f2283146-4b61-491e-8002-c361c52d9082", 39m, "Wolverine", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6801), 39m },
                    { new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2"), "Defender", "690f8f27-48ce-439c-b9d8-d7905ae16028", 41m, "Black Widow", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6683), 41m },
                    { new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be"), "Defender", "f2283146-4b61-491e-8002-c361c52d9082", 45m, "Black Panther", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6817), 45m },
                    { new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 47m, "Bane", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6898), 47m },
                    { new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c"), "Attacker", "690f8f27-48ce-439c-b9d8-d7905ae16028", 38m, "Scarlet Witch", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6745), 38m },
                    { new Guid("1eba75e9-de78-4143-a309-e351c36d7a38"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 50m, "Bat-Girl", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6957), 50m },
                    { new Guid("208ad836-e216-45f0-8501-2e53f5286d2e"), "Attacker", "690f8f27-48ce-439c-b9d8-d7905ae16028", 32m, "Iron-Man", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6656), 32m },
                    { new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2"), "Attacker", "690f8f27-48ce-439c-b9d8-d7905ae16028", 41m, "Captain America", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6666), 41m },
                    { new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 37m, "Super-Man", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6843), 37m },
                    { new Guid("519ced22-4303-473d-8293-68308b8e6ee4"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 50m, "The Hulk", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6790), 50m },
                    { new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 33m, "Dr. Doom", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6947), 33m },
                    { new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d"), "Defender", "690f8f27-48ce-439c-b9d8-d7905ae16028", 31m, "Deadpool", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6633), 31m },
                    { new Guid("6a724f99-c2a9-42da-959f-77ad500df838"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 40m, "Venom", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6827), 40m },
                    { new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af"), "Attacker", "690f8f27-48ce-439c-b9d8-d7905ae16028", 42m, "Thanos", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6645), 42m },
                    { new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 32m, "Loki", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6922), 32m },
                    { new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 34m, "The Punisher", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6782), 34m },
                    { new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9"), "Attacker", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 50m, "Hela", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6930), 50m },
                    { new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 43m, "Star Lord", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6835), 43m },
                    { new Guid("93530afb-f394-4057-9932-acd69f3eb487"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 50m, "Wonder Woman", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6906), 50m },
                    { new Guid("93ac9611-f4af-4d50-91ae-23d49365af55"), "Attacker", "690f8f27-48ce-439c-b9d8-d7905ae16028", 35m, "Captain Marvel", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6757), 35m },
                    { new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf"), "Attacker", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 42m, "The Joker", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6890), 42m },
                    { new Guid("b4efd809-e821-4d42-85f7-1c85238f3198"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 43m, "Adam Warlock", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6914), 43m },
                    { new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 34m, "Bat-Man", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6850), 34m },
                    { new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 35m, "She-Hulk", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6939), 35m },
                    { new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c"), "Defender", "690f8f27-48ce-439c-b9d8-d7905ae16028", 38m, "Thor", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6675), 38m },
                    { new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6"), "Attacker", "f2283146-4b61-491e-8002-c361c52d9082", 40m, "Spider-Man", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6775), 40m },
                    { new Guid("dd95a3f3-3568-444e-b300-3491eedf9758"), "Defender", "aaf0d392-1d51-4bc8-a308-58fe3376497d", 37m, "Super-Girl", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6965), 37m },
                    { new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6"), "Defender", "690f8f27-48ce-439c-b9d8-d7905ae16028", 41m, "Dr. Strange", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6621), 41m },
                    { new Guid("e6799233-35dd-4249-a9b6-e76303df2326"), "Defender", "f2283146-4b61-491e-8002-c361c52d9082", 34m, "Ant-Man", new DateTime(2022, 3, 8, 20, 31, 10, 398, DateTimeKind.Utc).AddTicks(6809), 34m }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Green", new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398") },
                    { "Silver", new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398") },
                    { "Green", new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be") },
                    { "Red", new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be") },
                    { "Blue", new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2") },
                    { "Yellow", new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2") },
                    { "Blue", new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be") },
                    { "Green", new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be") },
                    { "Blue", new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f") },
                    { "Orange", new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f") },
                    { "Blue", new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c") },
                    { "Red", new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c") },
                    { "Black", new Guid("1eba75e9-de78-4143-a309-e351c36d7a38") },
                    { "Red", new Guid("1eba75e9-de78-4143-a309-e351c36d7a38") },
                    { "Purple", new Guid("208ad836-e216-45f0-8501-2e53f5286d2e") },
                    { "Silver", new Guid("208ad836-e216-45f0-8501-2e53f5286d2e") },
                    { "Gold", new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2") },
                    { "Silver", new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2") },
                    { "Brown", new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3") },
                    { "Green", new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3") },
                    { "Black", new Guid("519ced22-4303-473d-8293-68308b8e6ee4") },
                    { "Red", new Guid("519ced22-4303-473d-8293-68308b8e6ee4") },
                    { "Gold", new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530") },
                    { "Pink", new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530") },
                    { "Gold", new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d") },
                    { "Orange", new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d") },
                    { "Blue", new Guid("6a724f99-c2a9-42da-959f-77ad500df838") },
                    { "Gold", new Guid("6a724f99-c2a9-42da-959f-77ad500df838") },
                    { "Blue", new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af") },
                    { "White", new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af") },
                    { "Orange", new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206") },
                    { "Yellow", new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206") },
                    { "Brown", new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812") },
                    { "Red", new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812") },
                    { "Green", new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9") },
                    { "Orange", new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9") },
                    { "Black", new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003") },
                    { "Silver", new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003") },
                    { "Black", new Guid("93530afb-f394-4057-9932-acd69f3eb487") },
                    { "White", new Guid("93530afb-f394-4057-9932-acd69f3eb487") },
                    { "Gold", new Guid("93ac9611-f4af-4d50-91ae-23d49365af55") },
                    { "Pink", new Guid("93ac9611-f4af-4d50-91ae-23d49365af55") }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Brown", new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf") },
                    { "Orange", new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf") },
                    { "Brown", new Guid("b4efd809-e821-4d42-85f7-1c85238f3198") },
                    { "Yellow", new Guid("b4efd809-e821-4d42-85f7-1c85238f3198") },
                    { "Blue", new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087") },
                    { "Brown", new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087") },
                    { "Purple", new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966") },
                    { "Silver", new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966") },
                    { "Black", new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c") },
                    { "Silver", new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c") },
                    { "Brown", new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6") },
                    { "Pink", new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6") },
                    { "Black", new Guid("dd95a3f3-3568-444e-b300-3491eedf9758") },
                    { "Red", new Guid("dd95a3f3-3568-444e-b300-3491eedf9758") },
                    { "Green", new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6") },
                    { "Silver", new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6") },
                    { "Black", new Guid("e6799233-35dd-4249-a9b6-e76303df2326") },
                    { "Gold", new Guid("e6799233-35dd-4249-a9b6-e76303df2326") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("1eba75e9-de78-4143-a309-e351c36d7a38") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("1eba75e9-de78-4143-a309-e351c36d7a38") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("208ad836-e216-45f0-8501-2e53f5286d2e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("208ad836-e216-45f0-8501-2e53f5286d2e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("519ced22-4303-473d-8293-68308b8e6ee4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("519ced22-4303-473d-8293-68308b8e6ee4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("6a724f99-c2a9-42da-959f-77ad500df838") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("6a724f99-c2a9-42da-959f-77ad500df838") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("93530afb-f394-4057-9932-acd69f3eb487") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("93530afb-f394-4057-9932-acd69f3eb487") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("93ac9611-f4af-4d50-91ae-23d49365af55") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("93ac9611-f4af-4d50-91ae-23d49365af55") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("b4efd809-e821-4d42-85f7-1c85238f3198") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("b4efd809-e821-4d42-85f7-1c85238f3198") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("dd95a3f3-3568-444e-b300-3491eedf9758") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("dd95a3f3-3568-444e-b300-3491eedf9758") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("e6799233-35dd-4249-a9b6-e76303df2326") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("e6799233-35dd-4249-a9b6-e76303df2326") });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("006efc8c-c0e0-4faa-88a4-3e12f43f5398"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("017d95a3-4e67-4d07-b677-2e8250e3f7be"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0a3e8b52-e3be-4816-a61f-641b277ebab2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("108bddb1-a4eb-4fe8-835d-beb4706c81be"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("132ea55f-5b82-422c-82a1-4ed58b00d98f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("19b1f271-6042-4a10-9ad8-d42f0c63964c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1eba75e9-de78-4143-a309-e351c36d7a38"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("208ad836-e216-45f0-8501-2e53f5286d2e"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("215ba930-e057-43fa-aa0d-b83cc664eaa2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("36ca83e9-054c-4db2-a7e5-5eb827292ca3"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("519ced22-4303-473d-8293-68308b8e6ee4"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5b57b2ec-8ad8-4790-9038-50c14c795530"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6035bd5b-bbf3-4264-b047-e1b8ec7d634d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6a724f99-c2a9-42da-959f-77ad500df838"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6a9750a5-75b9-41e0-a905-8321cee7c6af"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7598f1ef-c840-4251-8de6-52c7b9fac206"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("864d40d2-95e8-4f9d-b563-59a0b980c812"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("897209e9-a2b2-4890-bb73-12f6f7392ff9"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("8d938c90-0099-42a7-add2-fa6fd7cf9003"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("93530afb-f394-4057-9932-acd69f3eb487"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("93ac9611-f4af-4d50-91ae-23d49365af55"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("b01be38a-fd61-46ec-931f-cf4de535c4cf"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("b4efd809-e821-4d42-85f7-1c85238f3198"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("ba235dcc-c254-4bc0-911f-fb3b5c0ab087"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c891de5d-b0a0-4e3a-8cce-f1a03d586966"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("cdaf7f80-4d22-4e01-8640-7a2c4358a17c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("d288a1e5-5f2e-4c97-a399-4ce2c98c97f6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("dd95a3f3-3568-444e-b300-3491eedf9758"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e23f4c6b-728e-43e5-b210-4b7cbc5363c6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e6799233-35dd-4249-a9b6-e76303df2326"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "690f8f27-48ce-439c-b9d8-d7905ae16028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaf0d392-1d51-4bc8-a308-58fe3376497d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2283146-4b61-491e-8002-c361c52d9082");

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
    }
}
