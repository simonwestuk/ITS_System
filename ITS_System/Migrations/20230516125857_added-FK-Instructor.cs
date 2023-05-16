using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class addedFKInstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44354962-7942-4c2e-9b42-a2a3ee6aabce", "5f7b5742-af0c-467c-ac1c-8524009a3a67", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56041f58-794b-48f1-94ce-8ceb1c8cdb14", "acf5c716-362f-40aa-a9d5-577fe2872828", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96c5ac16-a9dc-433a-bdba-cbf89378af2f", "91c9b718-d2bb-40c1-99cf-c3ecee83c513", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46d7b3f-5410-494a-b6a1-f8c2b448fa6e", "a7d583c0-6a44-4a65-b800-202e822551cc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "926db05a-2a5a-44b0-b985-9eaf9bdfb6fa", 0, "4a9fadb1-f26f-4c17-953e-29944b2d79f6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO73Qw46Wn4VM6C0Ko7FzNj1xzJxnmhTs5I58UPwIdVVWn1UaLpjviqV9TniKd+FmA==", null, false, "8c128b45-8606-43eb-a202-6c600aeddc48", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e46d7b3f-5410-494a-b6a1-f8c2b448fa6e", "926db05a-2a5a-44b0-b985-9eaf9bdfb6fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44354962-7942-4c2e-9b42-a2a3ee6aabce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56041f58-794b-48f1-94ce-8ceb1c8cdb14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96c5ac16-a9dc-433a-bdba-cbf89378af2f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e46d7b3f-5410-494a-b6a1-f8c2b448fa6e", "926db05a-2a5a-44b0-b985-9eaf9bdfb6fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46d7b3f-5410-494a-b6a1-f8c2b448fa6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "926db05a-2a5a-44b0-b985-9eaf9bdfb6fa");

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
    }
}
