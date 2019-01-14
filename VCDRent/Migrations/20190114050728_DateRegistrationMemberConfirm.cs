using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCDRent.Migrations
{
    public partial class DateRegistrationMemberConfirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "registraiondateMemberConfirm",
                table: "TMemberConfirmContact",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "registraiondateMemberConfirm",
                table: "TMemberConfirmContact");
        }
    }
}
