using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Data.Migrations
{
    public partial class InitialCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.InsertData(table: "Customer", columns: new[]
            {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Age"
            },
            values: new object[]
            {
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            true,
            DateTime.Now,
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            "0407db73-fc73-11eb-8a38-0c29effdff40",
            "Priscila",
            29
            });


            migrationBuilder.InsertData(table: "Customer", columns: new[]
            {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Age"
            },
             values: new object[]
             {
                    "DAE6E90C-64C9-4E75-9E6C-70AFF25193AE",
                    true,
                    DateTime.Now,
                    "0407db73-fc73-11eb-8a38-0c29effdff40",
                    "0407db73-fc73-11eb-8a38-0c29effdff40",
                    "Marcos",
                    30
             });

            migrationBuilder.InsertData(table: "Customer", columns: new[]
            {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Age"
            },
             values: new object[]
             {
                                "A16D6145-7DCD-4A71-AA6E-3F6FA17A70FF",
                                true,
                                DateTime.Now,
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "Patrick",
                                30
             });

            migrationBuilder.InsertData(table: "Customer", columns: new[]
         {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Age"
            },
          values: new object[]
          {
                                "BF9D8708-6103-46FC-B5FC-6036F38282BD",
                                true,
                                DateTime.Now,
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "Venancio",
                                30
          });


            migrationBuilder.InsertData(table: "Customer", columns: new[]
         {

                "Id",
                "Active",
                "DateRegister",
                "UserInsertedId",
                "UserAdInsertedId",
                "Name",
                "Age"
            },
          values: new object[]
          {
                                "EAD0FAD1-05B5-4923-A867-9A26A16CA530",
                                true,
                                DateTime.Now,
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "0407db73-fc73-11eb-8a38-0c29effdff40",
                                "Fabricio",
                                35
          });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(table: "Customer", "Id", "0407db73-fc73-11eb-8a38-0c29effdff40");
            migrationBuilder.DeleteData(table: "Customer", "Id", "DAE6E90C-64C9-4E75-9E6C-70AFF25193AE");
            migrationBuilder.DeleteData(table: "Customer", "Id", "A16D6145-7DCD-4A71-AA6E-3F6FA17A70FF");
            migrationBuilder.DeleteData(table: "Customer", "Id", "BF9D8708-6103-46FC-B5FC-6036F38282BD");
            migrationBuilder.DeleteData(table: "Customer", "Id", "EAD0FAD1-05B5-4923-A867-9A26A16CA530");

        }
    }
}
