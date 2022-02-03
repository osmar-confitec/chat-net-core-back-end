using CrossCutting;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Data.Migrations
{
    public partial class AddUserAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(table: "User", columns: new[]
          {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Password",
                "Email"
            },
          values: new object[]
          {
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            true,
            DateTime.Now,
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            "Priscila",
            Security.CalculaHash("123456os"),
            "osmargv99@gmail.com"
          });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Customer", "Id", "0407db73-fc73-11eb-8a38-0c29effdff40");
        }
    }
}
