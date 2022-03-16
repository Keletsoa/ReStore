using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class IdentityAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36b569f6-ab5a-4c9c-9da5-4b751754cdae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6df0a094-a0af-4cae-934f-0fc5c7eba841");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0253fe0d-46ec-45ac-aecb-14d560c883d7", "1500d9e8-cb20-4247-940e-28ee2b302751", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7fa0118-665d-491d-bb55-8fd87eb7f3f7", "e261b7ce-17ba-41fc-b6a2-c4b5655fac7a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0253fe0d-46ec-45ac-aecb-14d560c883d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7fa0118-665d-491d-bb55-8fd87eb7f3f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6df0a094-a0af-4cae-934f-0fc5c7eba841", "a9c178ac-2c22-45f8-ac2b-d21522febb49", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36b569f6-ab5a-4c9c-9da5-4b751754cdae", "e1b26183-4a59-4e32-a229-abcdb01eb6a3", "Admin", "ADMIN" });
        }
    }
}
