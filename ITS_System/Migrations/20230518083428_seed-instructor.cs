using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class seedinstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d1d4bfd-f13b-4788-83e7-83db0166319b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498d56c6-d929-4ed9-804b-aceb111537a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87b977ce-a03b-4814-b7ed-ebf0ebbbb3d3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ccc4383-ed3b-4da4-8961-1685b6427dc7", "de407ef4-b738-487d-814a-554bd2ea7465" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ccc4383-ed3b-4da4-8961-1685b6427dc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de407ef4-b738-487d-814a-554bd2ea7465");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "498aa265-1729-4b9e-a5f5-b46d75810326", "27fb3f66-6a82-4b66-8357-a77635079cd2", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abf58359-d5b1-4387-ac20-5ae3e2622d8b", "2e147996-596f-4da7-afe7-b72f50e5e564", "Instructor", "INSTRUCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf4a50e3-4f7f-4d08-a939-362aecd8d272", "4394338f-90f5-44e0-9e5c-6eac5b7f67ad", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2957547-f2ce-4c1f-8876-b6cb4545c6ec", "0f35c434-8d4b-4f59-b4ef-d929398af09d", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa786df3-77a0-4912-a360-d7d533630db5", "14a377b0-1d0b-4cc3-bda3-63e947a6ce29", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2b4aa4a3-e642-4ff6-901c-da1dc886f3a3", 0, "6381d11d-ee29-472d-8f3c-815c1c41fa59", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELa1HMDh0w3305k82CAZARAkWyg+7/oY97XGCtIkSm2g1KSQLq8sqUgH/TfkiVu8BA==", null, false, "5a6b71fa-b1eb-423b-8ed5-f6950f7858e0", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa786df3-77a0-4912-a360-d7d533630db5", "2b4aa4a3-e642-4ff6-901c-da1dc886f3a3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498aa265-1729-4b9e-a5f5-b46d75810326");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abf58359-d5b1-4387-ac20-5ae3e2622d8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf4a50e3-4f7f-4d08-a939-362aecd8d272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2957547-f2ce-4c1f-8876-b6cb4545c6ec");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa786df3-77a0-4912-a360-d7d533630db5", "2b4aa4a3-e642-4ff6-901c-da1dc886f3a3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa786df3-77a0-4912-a360-d7d533630db5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b4aa4a3-e642-4ff6-901c-da1dc886f3a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d1d4bfd-f13b-4788-83e7-83db0166319b", "5e7ead43-c686-4196-bf73-ad8fa2a2419f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "498d56c6-d929-4ed9-804b-aceb111537a5", "25e680d0-3632-4a23-8b7d-2093df0ffdb3", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ccc4383-ed3b-4da4-8961-1685b6427dc7", "dd8be265-984f-432b-abd4-fdf88f03f1c8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87b977ce-a03b-4814-b7ed-ebf0ebbbb3d3", "c01ebe63-87e1-4947-9952-2f966860a4e9", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "de407ef4-b738-487d-814a-554bd2ea7465", 0, "577086b0-ee1c-449f-a2bb-23a4f70e8a2d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKBH+MCgaXaSKhQIGsr9wIrL0AWuAOpDMsTfszTpO7vURf1+jUOBUE0eHdVYwnNE6w==", null, false, "21e851d2-02f3-41a5-9025-fa73950e3778", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ccc4383-ed3b-4da4-8961-1685b6427dc7", "de407ef4-b738-487d-814a-554bd2ea7465" });
        }
    }
}
