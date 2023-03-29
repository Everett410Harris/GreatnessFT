using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreatnessFT.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BUser = table.Column<string>(type: "TEXT", nullable: false),
                    BCustFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    BCustLastName = table.Column<string>(type: "TEXT", nullable: false),
                    BCustPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    BVehicle = table.Column<string>(type: "TEXT", nullable: false),
                    BDriver = table.Column<string>(type: "TEXT", nullable: false),
                    PickUpDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    DropOffDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    CustLastName = table.Column<string>(type: "TEXT", nullable: false),
                    CustPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    CustAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CustEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CustJoinDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriversId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DriversFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    DriversLastName = table.Column<string>(type: "TEXT", nullable: false),
                    DriversDOB = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    DriversGender = table.Column<string>(type: "TEXT", nullable: false),
                    DriversPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    DriversAddress = table.Column<string>(type: "TEXT", nullable: false),
                    DriversJoinDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriversId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsersFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    UsersLastName = table.Column<string>(type: "TEXT", nullable: false),
                    UsersDOB = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    UsersGender = table.Column<string>(type: "TEXT", nullable: false),
                    UsersPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersAddress = table.Column<string>(type: "TEXT", nullable: false),
                    UsersPassword = table.Column<string>(type: "TEXT", nullable: false),
                    UsersJoinDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UsersId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VLicensePlate = table.Column<string>(type: "TEXT", nullable: false),
                    VModel = table.Column<string>(type: "TEXT", nullable: false),
                    VYear = table.Column<int>(type: "INTEGER", nullable: false),
                    VEngType = table.Column<string>(type: "TEXT", nullable: false),
                    VColor = table.Column<string>(type: "TEXT", nullable: false),
                    VMileage = table.Column<int>(type: "INTEGER", nullable: false),
                    VMake = table.Column<string>(type: "TEXT", nullable: false),
                    VType = table.Column<string>(type: "TEXT", nullable: false),
                    VBooked = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
