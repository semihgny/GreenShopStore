using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class sedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adres",
                table: "contacts",
                newName: "name");

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "mesaj",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "mesaj",
                table: "contacts");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "contacts",
                newName: "adres");
        }
    }
}
