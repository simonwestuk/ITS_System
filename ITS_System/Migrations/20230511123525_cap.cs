using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class cap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c96c172-420b-4a4e-a5b0-351bf00099d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f15f2e5-ceb5-4804-ae55-846ffa48e2e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbcc350c-a27a-4f5f-ae92-6d06d434294a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2c54444-0fd1-4285-ae5b-d8bbebcc196d", "5b7c1bc0-c5fc-4754-865c-dd5526f0c66e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2c54444-0fd1-4285-ae5b-d8bbebcc196d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b7c1bc0-c5fc-4754-865c-dd5526f0c66e");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "c74d4460-c3ed-4f24-a0ce-a9c9c548e09e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "551960b0-a037-4315-a2cd-c44248e59ca0", "a582059d-23f3-4844-be51-62b2eab0bad2", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c396a4c-3a2e-48e9-8077-61796e208ebe", "bfa7d29e-95b9-455b-a541-6bb356859cff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8b8ecb9-5a56-4c9a-ace4-0b5225fb6575", "6b1098e0-99bf-4e81-b841-ab1fe80d0afc", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9bdd798-7adf-4a73-ab48-955b5b6e169d", 0, "adeff7e9-9696-470b-afc5-007ab5d75c2f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH8vyYGdnz/rhgXDVc7MrHztKQOVJqfmgRfDSgD3RzWzJzInyJ/3BWAeYAwi3iFKTA==", null, false, "d3d76c67-3991-4162-9a04-a96b7733d05a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "e9bdd798-7adf-4a73-ab48-955b5b6e169d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "551960b0-a037-4315-a2cd-c44248e59ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c396a4c-3a2e-48e9-8077-61796e208ebe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8b8ecb9-5a56-4c9a-ace4-0b5225fb6575");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "e9bdd798-7adf-4a73-ab48-955b5b6e169d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d75b1b0-f968-4487-add8-aa33ea1f4ede");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9bdd798-7adf-4a73-ab48-955b5b6e169d");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c96c172-420b-4a4e-a5b0-351bf00099d3", "a3a2f91f-9a82-46e1-9a0a-3d4753d8a248", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f15f2e5-ceb5-4804-ae55-846ffa48e2e6", "42ff3c41-2490-4000-aab2-24ed38086d91", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2c54444-0fd1-4285-ae5b-d8bbebcc196d", "358be380-b39f-4d95-bb74-103608309ae2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbcc350c-a27a-4f5f-ae92-6d06d434294a", "623d7504-cd96-40ad-83a9-2364c2b969d7", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b7c1bc0-c5fc-4754-865c-dd5526f0c66e", 0, "06a0a617-7336-434a-9fba-b0b0c64c086f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAkQu7j9qAUr3Hrj4PDbKhv9IUdh9Ce1XUD3tS1UHEiVQYmFmgz2h+h4TsSIMteBuA==", null, false, "e6111010-d9ed-40f8-8d40-de91c6fa4f38", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d2c54444-0fd1-4285-ae5b-d8bbebcc196d", "5b7c1bc0-c5fc-4754-865c-dd5526f0c66e" });
        }
    }
}
