using Microsoft.EntityFrameworkCore.Migrations;

namespace CyberTravels.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roundtrip = table.Column<string>(nullable: true),
                    Onway = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    Depatures = table.Column<string>(nullable: true),
                    Return = table.Column<string>(nullable: true),
                    Adults = table.Column<string>(nullable: true),
                    Childs = table.Column<string>(nullable: true),
                    To = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouDestination = table.Column<string>(nullable: true),
                    LocDestination = table.Column<string>(nullable: true),
                    Checkin = table.Column<string>(nullable: true),
                    Checkout = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Members = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouDestination = table.Column<string>(nullable: true),
                    LocDestination = table.Column<string>(nullable: true),
                    Checkin = table.Column<string>(nullable: true),
                    Checkout = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Members = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
