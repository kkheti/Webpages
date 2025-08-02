using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trading_App.Migrations
{
    /// <inheritdoc />
    public partial class intialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aveg_pricePerShare = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    linkToFilingDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num_shares_own = table.Column<long>(type: "bigint", nullable: false),
                    reportingOwnerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sum_transactionShares = table.Column<long>(type: "bigint", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tot_value = table.Column<double>(type: "float", nullable: false),
                    transactionCode = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
