using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class reIdentityAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ead58520-348c-4edc-85f3-36a157fc1bc3", "2a2cc39d-a540-49c3-beb6-d168e3919319", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77efb9c5-0aea-4984-8529-2fc7963c42ab", "8eac189c-e148-4c4f-8fb3-5476262bc973", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77efb9c5-0aea-4984-8529-2fc7963c42ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ead58520-348c-4edc-85f3-36a157fc1bc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0253fe0d-46ec-45ac-aecb-14d560c883d7", "1500d9e8-cb20-4247-940e-28ee2b302751", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7fa0118-665d-491d-bb55-8fd87eb7f3f7", "e261b7ce-17ba-41fc-b6a2-c4b5655fac7a", "Admin", "ADMIN" });
        }
    }
}
