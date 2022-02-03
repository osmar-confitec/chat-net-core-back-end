using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DateRegister = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    UserInsertedId = table.Column<Guid>(nullable: false),
                    UserAdInsertedId = table.Column<string>(type: "varchar(200)", nullable: true),
                    UserUpdatedId = table.Column<Guid>(nullable: true),
                    UserAdUpdatedId = table.Column<string>(type: "varchar(200)", nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    UserDeletedId = table.Column<Guid>(nullable: true),
                    UserAdDeletedId = table.Column<string>(type: "varchar(200)", nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
