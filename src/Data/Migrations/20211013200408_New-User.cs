using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class NewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Password = table.Column<string>(type: "varchar(200)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserInsertedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAdInsertedId = table.Column<string>(type: "varchar(200)", nullable: true),
                    UserUpdatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserAdUpdatedId = table.Column<string>(type: "varchar(200)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDeletedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserAdDeletedId = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
