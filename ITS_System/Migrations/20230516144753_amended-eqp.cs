using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class amendedeqp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.DropIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments");

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

            migrationBuilder.DropColumn(
                name: "ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.CreateTable(
                name: "EquipmentListEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentListEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Equpiments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equpiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Schedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_ClassScheduleId",
                table: "EquipmentListEntry",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_EquipmentId",
                table: "EquipmentListEntry",
                column: "EquipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentListEntry");

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

            migrationBuilder.AddColumn<int>(
                name: "ClassScheduleId",
                table: "Equpiments",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
