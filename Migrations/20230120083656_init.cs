using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerstaTestWeb.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sendercity = table.Column<string>(name: "sender_city", type: "nvarchar(max)", nullable: false),
                    sendercountry = table.Column<string>(name: "sender_country", type: "nvarchar(max)", nullable: false),
                    recipientcity = table.Column<string>(name: "recipient_city", type: "nvarchar(max)", nullable: false),
                    recipientcountry = table.Column<string>(name: "recipient_country", type: "nvarchar(max)", nullable: false),
                    cargoweight = table.Column<string>(name: "cargo_weight", type: "nvarchar(max)", nullable: false),
                    pickupDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
