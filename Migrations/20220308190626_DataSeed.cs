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
                keyValues: new object[] { "Green", new Guid("12674aed-ccde-42f7-954c-83ee5290d667") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("12674aed-ccde-42f7-954c-83ee5290d667") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("25157dc8-253d-451e-bb11-fa00d9999179") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("25157dc8-253d-451e-bb11-fa00d9999179") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("433c50ca-85bc-4f99-bab1-923df245ed77") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("433c50ca-85bc-4f99-bab1-923df245ed77") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("58a17f0a-164a-45f1-8920-20c90243c608") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("58a17f0a-164a-45f1-8920-20c90243c608") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("5e11211f-242a-4054-a4e2-8328da34f96d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("5e11211f-242a-4054-a4e2-8328da34f96d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("8a7b794c-2df4-46df-b012-cca500e35941") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("8a7b794c-2df4-46df-b012-cca500e35941") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("94b37666-bb39-4866-9bff-14225015d938") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("94b37666-bb39-4866-9bff-14225015d938") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8") });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("12674aed-ccde-42f7-954c-83ee5290d667"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("25157dc8-253d-451e-bb11-fa00d9999179"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("433c50ca-85bc-4f99-bab1-923df245ed77"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("58a17f0a-164a-45f1-8920-20c90243c608"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5e11211f-242a-4054-a4e2-8328da34f96d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("8a7b794c-2df4-46df-b012-cca500e35941"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("94b37666-bb39-4866-9bff-14225015d938"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1cbc061-d0be-4c9d-ae4e-82ae28e99550");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2a921ab-53fb-4edd-8547-3e7140528286");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "49ba864d-5963-493f-8254-217192dfe74b", 0, "a3759961-35a4-4745-b1c8-d9d2649a2cd5", "user2@example.com", false, "Keren", "David", false, null, null, null, "AQAAAAEAACcQAAAAEG8bio9iY8zwHhNzjwAzY+vlCU52solJRUU22kigc2vYJxzY/WguAPBTSfQIiXhZZg==", null, false, "f3556fcb-89d2-4a31-884f-73b8ace71e7f", false, "user2@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "56522a96-07e6-4331-afea-b3c4fedc4039", 0, "ecc3c1d7-ec73-4857-9140-8152db39c500", "user1@example.com", false, "Moshe", "Cohen", false, null, null, null, "AQAAAAEAACcQAAAAEKIm0nYdxOWeMPfZrY4z1L4gVB/pjYrab3fi7CTiwF4m8E+Pk/DqzzhU4GHVAJ+eUw==", null, false, "c395dd87-1e16-4bd7-935a-0fa3b6e45371", false, "user1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62029255-19a6-4583-bb55-1bd251999ff1", 0, "9cde9ff2-6abb-47f9-a60c-113b12df6e8e", "user3@example.com", false, "Sholomo", "Daniel", false, null, null, null, "AQAAAAEAACcQAAAAEK0e72uqRORaVFCW+Z2+jITS6C0XKMrz7BKh15tpoqs2fb/0L2A3r0YlT1EYMrhe3g==", null, false, "e9f7105c-5a5b-4735-a149-4062f18f1d15", false, "user3@example.com" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "ApplicationUserId", "CurrentPower", "Name", "StartedTrainingAt", "StartingPower" },
                values: new object[,]
                {
                    { new Guid("0631cff2-cbc8-4be7-a518-422b395183fc"), "Defender", "49ba864d-5963-493f-8254-217192dfe74b", 48m, "Wolverine", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6982), 48m },
                    { new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989"), "Defender", "62029255-19a6-4583-bb55-1bd251999ff1", 41m, "Adam Warlock", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7104), 41m },
                    { new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 46m, "Super-Girl", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7163), 46m },
                    { new Guid("1d5e4f75-7a5e-477d-9487-353074933703"), "Defender", "49ba864d-5963-493f-8254-217192dfe74b", 43m, "Bat-Man", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7069), 43m },
                    { new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3"), "Defender", "62029255-19a6-4583-bb55-1bd251999ff1", 30m, "Bat-Girl", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7154), 30m },
                    { new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 46m, "Dr. Doom", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7146), 46m },
                    { new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 47m, "Wonder Woman", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7096), 47m },
                    { new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 36m, "Thor", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6911), 36m },
                    { new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5"), "Attacker", "49ba864d-5963-493f-8254-217192dfe74b", 35m, "Ant-Man", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6991), 35m },
                    { new Guid("4c939e82-0569-427d-8e86-776406cd0416"), "Defender", "62029255-19a6-4583-bb55-1bd251999ff1", 49m, "The Joker", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7078), 49m },
                    { new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4"), "Defender", "49ba864d-5963-493f-8254-217192dfe74b", 48m, "Spider-Man", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6958), 48m },
                    { new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 39m, "Captain America", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6901), 39m },
                    { new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 38m, "Hela", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7128), 38m },
                    { new Guid("5956738d-c40c-4995-bb5a-c69809b58f48"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 37m, "Pheonix", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6949), 37m },
                    { new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2"), "Defender", "56522a96-07e6-4331-afea-b3c4fedc4039", 35m, "Iron-Man", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6831), 35m },
                    { new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 45m, "Bane", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7088), 45m },
                    { new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c"), "Attacker", "49ba864d-5963-493f-8254-217192dfe74b", 35m, "The Punisher", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6966), 35m },
                    { new Guid("7297dc26-0268-4d58-af2e-3048e11fb473"), "Defender", "49ba864d-5963-493f-8254-217192dfe74b", 39m, "Black Panther", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6999), 39m },
                    { new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a"), "Defender", "56522a96-07e6-4331-afea-b3c4fedc4039", 46m, "Dr. Strange", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6798), 46m },
                    { new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a"), "Attacker", "49ba864d-5963-493f-8254-217192dfe74b", 43m, "Super-Man", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7061), 43m },
                    { new Guid("9ca081c2-2be9-491b-9db0-973005b505a8"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 33m, "Captain Marvel", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6940), 33m },
                    { new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8"), "Defender", "49ba864d-5963-493f-8254-217192dfe74b", 36m, "Venom", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7010), 36m },
                    { new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6"), "Defender", "56522a96-07e6-4331-afea-b3c4fedc4039", 50m, "Thanos", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6823), 50m },
                    { new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 42m, "She-Hulk", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7138), 42m },
                    { new Guid("a249ce29-a842-469e-bea6-63fc400d5897"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 49m, "Black Widow", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6920), 49m },
                    { new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 30m, "Deadpool", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6811), 30m },
                    { new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13"), "Attacker", "56522a96-07e6-4331-afea-b3c4fedc4039", 36m, "Scarlet Witch", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6928), 36m },
                    { new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6"), "Attacker", "49ba864d-5963-493f-8254-217192dfe74b", 35m, "Star Lord", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7053), 35m },
                    { new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d"), "Attacker", "49ba864d-5963-493f-8254-217192dfe74b", 33m, "The Hulk", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(6974), 33m },
                    { new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107"), "Attacker", "62029255-19a6-4583-bb55-1bd251999ff1", 39m, "Loki", new DateTime(2022, 3, 8, 19, 6, 26, 152, DateTimeKind.Utc).AddTicks(7118), 39m }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Purple", new Guid("0631cff2-cbc8-4be7-a518-422b395183fc") },
                    { "White", new Guid("0631cff2-cbc8-4be7-a518-422b395183fc") },
                    { "Orange", new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989") },
                    { "Pink", new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989") },
                    { "Brown", new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051") },
                    { "Red", new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051") },
                    { "Brown", new Guid("1d5e4f75-7a5e-477d-9487-353074933703") },
                    { "Yellow", new Guid("1d5e4f75-7a5e-477d-9487-353074933703") },
                    { "Blue", new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3") },
                    { "Brown", new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3") },
                    { "Black", new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2") },
                    { "Silver", new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2") },
                    { "Green", new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93") },
                    { "Pink", new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93") },
                    { "Blue", new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518") },
                    { "Gold", new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518") },
                    { "Green", new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5") },
                    { "Pink", new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5") },
                    { "Red", new Guid("4c939e82-0569-427d-8e86-776406cd0416") },
                    { "Silver", new Guid("4c939e82-0569-427d-8e86-776406cd0416") },
                    { "Black", new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4") },
                    { "Blue", new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4") },
                    { "Gold", new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff") },
                    { "Red", new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff") },
                    { "Orange", new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0") },
                    { "Yellow", new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0") },
                    { "Pink", new Guid("5956738d-c40c-4995-bb5a-c69809b58f48") },
                    { "White", new Guid("5956738d-c40c-4995-bb5a-c69809b58f48") },
                    { "Black", new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2") },
                    { "Silver", new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2") },
                    { "Purple", new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2") },
                    { "Silver", new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2") },
                    { "Brown", new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c") },
                    { "Gold", new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c") },
                    { "Gold", new Guid("7297dc26-0268-4d58-af2e-3048e11fb473") },
                    { "Silver", new Guid("7297dc26-0268-4d58-af2e-3048e11fb473") },
                    { "Green", new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a") },
                    { "White", new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a") },
                    { "Brown", new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a") },
                    { "Red", new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a") },
                    { "Blue", new Guid("9ca081c2-2be9-491b-9db0-973005b505a8") },
                    { "Silver", new Guid("9ca081c2-2be9-491b-9db0-973005b505a8") }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Black", new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8") },
                    { "Orange", new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8") },
                    { "Blue", new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6") },
                    { "Pink", new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6") },
                    { "Orange", new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f") },
                    { "Red", new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f") },
                    { "Blue", new Guid("a249ce29-a842-469e-bea6-63fc400d5897") },
                    { "Yellow", new Guid("a249ce29-a842-469e-bea6-63fc400d5897") },
                    { "Black", new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1") },
                    { "White", new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1") },
                    { "Orange", new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13") },
                    { "Yellow", new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13") },
                    { "Orange", new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6") },
                    { "Pink", new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6") },
                    { "Brown", new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d") },
                    { "Yellow", new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d") },
                    { "Red", new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107") },
                    { "White", new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("0631cff2-cbc8-4be7-a518-422b395183fc") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("0631cff2-cbc8-4be7-a518-422b395183fc") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("1d5e4f75-7a5e-477d-9487-353074933703") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("1d5e4f75-7a5e-477d-9487-353074933703") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("4c939e82-0569-427d-8e86-776406cd0416") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("4c939e82-0569-427d-8e86-776406cd0416") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("5956738d-c40c-4995-bb5a-c69809b58f48") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("5956738d-c40c-4995-bb5a-c69809b58f48") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Purple", new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Gold", new Guid("7297dc26-0268-4d58-af2e-3048e11fb473") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("7297dc26-0268-4d58-af2e-3048e11fb473") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Green", new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("9ca081c2-2be9-491b-9db0-973005b505a8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Silver", new Guid("9ca081c2-2be9-491b-9db0-973005b505a8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Blue", new Guid("a249ce29-a842-469e-bea6-63fc400d5897") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("a249ce29-a842-469e-bea6-63fc400d5897") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Black", new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Orange", new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Pink", new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Brown", new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Yellow", new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "Red", new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107") });

            migrationBuilder.DeleteData(
                table: "HeroSuitColors",
                keyColumns: new[] { "ColorName", "HeroId" },
                keyValues: new object[] { "White", new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107") });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0631cff2-cbc8-4be7-a518-422b395183fc"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("071c7a42-11f8-4438-b737-b9bc6b04c989"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("0aaf71ff-372e-4b91-ae1a-386d87824051"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1d5e4f75-7a5e-477d-9487-353074933703"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1e6b4e3d-db3e-43b6-ab64-7edbec2cb6d3"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("25bf2b6c-f2c5-4714-93ac-1be15374bca2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("34ac0bad-c01c-4b28-bb38-baa351aabd93"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("3a10bf79-85dd-4703-ab45-4f3ca23f4518"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4bd00c16-d738-4acd-8c95-6e04483061d5"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4c939e82-0569-427d-8e86-776406cd0416"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4fb8ecbf-d8e7-427d-b80e-c330bc718ad4"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5731ae4e-fa73-47d9-8c20-9553d4b582ff"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("588f56a9-88d1-427e-a402-28a32f4d40b0"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5956738d-c40c-4995-bb5a-c69809b58f48"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6d7819ca-efda-478e-ab81-0a545f4cc1e2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6f8cdcfb-3378-49e2-b5c5-58768294f7b2"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7140ca1f-ccce-42e3-aa5a-1df93e347c9c"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("7297dc26-0268-4d58-af2e-3048e11fb473"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("8fd13349-ee75-43b8-9c34-999cbafc2d8a"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9be7d241-b13b-4f2f-b565-9de69329a63a"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9ca081c2-2be9-491b-9db0-973005b505a8"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9d61dd61-bf35-486a-9c47-3d6c849985b8"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9e349f66-9bd8-4ce4-bcd4-21213ce71dc6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("a1f86a62-c15f-408a-b4fa-5336d86c779f"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("a249ce29-a842-469e-bea6-63fc400d5897"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("a4c95cf6-33db-4db9-b108-de76a0b5dce1"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("b4731181-eaf0-4c25-a0fb-e346979f8b13"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e4838b46-c1f6-4c77-be4e-de7fe01675e6"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("e9c119f5-7cba-4c32-9326-478fccd7d90d"));

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f12d6c3a-cdd5-4dd4-ab71-daeb74163107"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49ba864d-5963-493f-8254-217192dfe74b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56522a96-07e6-4331-afea-b3c4fedc4039");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62029255-19a6-4583-bb55-1bd251999ff1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 0, "7efeeb26-f714-42fd-8fd7-3104f06209a8", "user2@example.com", false, "Keren", "David", false, null, null, null, null, null, false, "2ce29d3d-4c97-4757-9a37-ddb9cfc6f36e", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 0, "0ac17b48-ac62-4928-8881-857670d87e70", "user3@example.com", false, "Sholomo", "Daniel", false, null, null, null, null, null, false, "de3050fe-bad0-463d-b1ef-5cf3fa39131d", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2a921ab-53fb-4edd-8547-3e7140528286", 0, "0b3aff09-b386-4d40-807d-dd2f9f73ded9", "user1@example.com", false, "Moshe", "Cohen", false, null, null, null, null, null, false, "0c07bdb6-2303-4851-8db8-b77c30e2646f", false, null });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Ability", "ApplicationUserId", "CurrentPower", "Name", "StartedTrainingAt", "StartingPower" },
                values: new object[,]
                {
                    { new Guid("12674aed-ccde-42f7-954c-83ee5290d667"), "Defender", "f2a921ab-53fb-4edd-8547-3e7140528286", 45m, "Iron-Man", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2110), 45m },
                    { new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917"), "Defender", "f2a921ab-53fb-4edd-8547-3e7140528286", 42m, "Scarlet Witch", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2204), 42m },
                    { new Guid("25157dc8-253d-451e-bb11-fa00d9999179"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 42m, "Bane", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2358), 42m },
                    { new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 49m, "Captain America", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2119), 49m },
                    { new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 36m, "Bat-Girl", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2413), 36m },
                    { new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 37m, "Pheonix", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2224), 37m },
                    { new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 47m, "Hela", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2388), 47m },
                    { new Guid("433c50ca-85bc-4f99-bab1-923df245ed77"), "Defender", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 47m, "Wonder Woman", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2365), 47m },
                    { new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 38m, "Black Panther", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2275), 38m },
                    { new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 31m, "The Hulk", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2250), 31m },
                    { new Guid("58a17f0a-164a-45f1-8920-20c90243c608"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 31m, "Super-Girl", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2420), 31m },
                    { new Guid("5e11211f-242a-4054-a4e2-8328da34f96d"), "Attacker", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 48m, "The Punisher", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2242), 48m },
                    { new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421"), "Defender", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 43m, "The Joker", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2350), 43m },
                    { new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970"), "Attacker", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 45m, "Wolverine", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2257), 45m },
                    { new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 43m, "Deadpool", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2092), 43m },
                    { new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c"), "Defender", "f2a921ab-53fb-4edd-8547-3e7140528286", 37m, "Thanos", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2103), 37m },
                    { new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 50m, "Thor", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2127), 50m },
                    { new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f"), "Attacker", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 49m, "Star Lord", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2292), 49m },
                    { new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 48m, "Loki", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2380), 48m },
                    { new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 35m, "Captain Marvel", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2215), 35m },
                    { new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 50m, "Dr. Strange", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2079), 50m },
                    { new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4"), "Defender", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 41m, "She-Hulk", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2397), 41m },
                    { new Guid("8a7b794c-2df4-46df-b012-cca500e35941"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 42m, "Adam Warlock", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2373), 42m },
                    { new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb"), "Attacker", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 31m, "Spider-Man", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2232), 31m },
                    { new Guid("94b37666-bb39-4866-9bff-14225015d938"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 42m, "Venom", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2283), 42m },
                    { new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 35m, "Super-Man", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2300), 35m },
                    { new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24"), "Attacker", "f2a921ab-53fb-4edd-8547-3e7140528286", 44m, "Black Widow", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2196), 44m },
                    { new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 40m, "Ant-Man", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2267), 40m },
                    { new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c"), "Defender", "a1cbc061-d0be-4c9d-ae4e-82ae28e99550", 46m, "Bat-Man", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2339), 46m },
                    { new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8"), "Attacker", "db2c544f-d1f4-4ffb-8485-3cfcd3c965c2", 36m, "Dr. Doom", new DateTime(2022, 3, 8, 18, 57, 6, 838, DateTimeKind.Utc).AddTicks(2405), 36m }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Green", new Guid("12674aed-ccde-42f7-954c-83ee5290d667") },
                    { "Yellow", new Guid("12674aed-ccde-42f7-954c-83ee5290d667") },
                    { "Black", new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917") },
                    { "Purple", new Guid("225a5e38-aee1-4e19-a4b1-2826f2b14917") },
                    { "Brown", new Guid("25157dc8-253d-451e-bb11-fa00d9999179") },
                    { "Green", new Guid("25157dc8-253d-451e-bb11-fa00d9999179") },
                    { "Black", new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b") },
                    { "Silver", new Guid("2d01b8b9-35d6-4a19-8bbd-6b7e2e9d5e4b") },
                    { "Pink", new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e") },
                    { "Silver", new Guid("36f3509f-89bc-482f-b832-b0b9422ee57e") },
                    { "Pink", new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d") },
                    { "Yellow", new Guid("38c5da9d-a54b-4cdd-96af-7bf80262e98d") },
                    { "Black", new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b") },
                    { "Blue", new Guid("3d82afcb-c73c-4023-b9c5-7e5d8c00374b") },
                    { "Brown", new Guid("433c50ca-85bc-4f99-bab1-923df245ed77") },
                    { "Yellow", new Guid("433c50ca-85bc-4f99-bab1-923df245ed77") },
                    { "Blue", new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65") },
                    { "Purple", new Guid("4d30221f-89e6-42f8-ae30-934ae7ed8f65") },
                    { "Red", new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940") },
                    { "Yellow", new Guid("4dc2421b-c061-47b5-9ed8-e1885d580940") },
                    { "Purple", new Guid("58a17f0a-164a-45f1-8920-20c90243c608") },
                    { "Red", new Guid("58a17f0a-164a-45f1-8920-20c90243c608") },
                    { "Blue", new Guid("5e11211f-242a-4054-a4e2-8328da34f96d") },
                    { "Gold", new Guid("5e11211f-242a-4054-a4e2-8328da34f96d") },
                    { "Orange", new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421") },
                    { "Silver", new Guid("5e149ff0-e6a6-4841-bbb7-eccb47f09421") },
                    { "Gold", new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970") },
                    { "Green", new Guid("61c4f1eb-0b87-405e-ad30-260fb36e5970") },
                    { "Silver", new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e") },
                    { "Yellow", new Guid("626d8d07-3fda-42a1-92e7-bea8d1b3152e") },
                    { "Green", new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c") },
                    { "Orange", new Guid("660dc6f9-00ac-46a4-9932-0ec011a4b44c") },
                    { "Black", new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33") },
                    { "Orange", new Guid("6fd5a4c6-2f52-4648-95ab-3b9da1aedc33") },
                    { "Green", new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f") },
                    { "Pink", new Guid("790d4eb5-2df9-46b0-87f9-32591e07c49f") },
                    { "Blue", new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c") },
                    { "Silver", new Guid("7ab7c0fb-c3ce-4658-95e0-643cf2371d4c") },
                    { "Silver", new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae") },
                    { "Yellow", new Guid("7eefefb6-b8f7-43bc-990e-abcef623c2ae") },
                    { "Gold", new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5") },
                    { "Green", new Guid("7f7fca1a-7ac2-40ec-b9d1-f6f976f7b0f5") }
                });

            migrationBuilder.InsertData(
                table: "HeroSuitColors",
                columns: new[] { "ColorName", "HeroId" },
                values: new object[,]
                {
                    { "Black", new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4") },
                    { "White", new Guid("84e8dcb6-8f36-4ceb-9ff4-7042aff512a4") },
                    { "Green", new Guid("8a7b794c-2df4-46df-b012-cca500e35941") },
                    { "Yellow", new Guid("8a7b794c-2df4-46df-b012-cca500e35941") },
                    { "Pink", new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb") },
                    { "Purple", new Guid("94a5057b-4900-4269-8c93-6ed6b864a1cb") },
                    { "Black", new Guid("94b37666-bb39-4866-9bff-14225015d938") },
                    { "Gold", new Guid("94b37666-bb39-4866-9bff-14225015d938") },
                    { "Pink", new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b") },
                    { "Silver", new Guid("c5a6f213-df48-49d5-ad16-d4004d1bb22b") },
                    { "Gold", new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24") },
                    { "Silver", new Guid("cbbbc9cf-a282-4489-bfa3-d69a33e5aa24") },
                    { "Black", new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7") },
                    { "Pink", new Guid("e3d0e6e2-5a4c-46e8-99cf-fec65de9b1d7") },
                    { "Brown", new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c") },
                    { "Silver", new Guid("e46a85c1-1956-4e50-9c58-91636f09b67c") },
                    { "Gold", new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8") },
                    { "Orange", new Guid("f7ccec86-3774-4083-aea6-7dc82b5c63c8") }
                });
        }
    }
}
