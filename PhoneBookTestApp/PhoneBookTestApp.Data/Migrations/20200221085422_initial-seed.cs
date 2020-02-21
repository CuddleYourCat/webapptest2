using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookTestApp.Data.Migrations
{
    public partial class initialseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "HouseNumber", "LastName", "PhoneNumber", "State", "StreetName", "Suburb" },
                values: new object[] { 1, "Chris", 452, "Johnson", "(321) 231-7876", "MI", "Freeman Drive", "Algonac" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "HouseNumber", "LastName", "PhoneNumber", "State", "StreetName", "Suburb" },
                values: new object[] { 2, "Dave", 285, "Williams", "(231) 502-1236", "MI", "Huron Street", "Port Austin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
