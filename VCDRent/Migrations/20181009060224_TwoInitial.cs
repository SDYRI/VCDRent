using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCDRent.Migrations
{
    public partial class TwoInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TConfirmContact",
                columns: table => new
                {
                    confirmcontactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nameConfirmContact = table.Column<string>(nullable: false),
                    phonenumberConfirmContact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TConfirmContact", x => x.confirmcontactID);
                });

            migrationBuilder.CreateTable(
                name: "TKnowThis",
                columns: table => new
                {
                    knowthisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    informationKnowthis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKnowThis", x => x.knowthisID);
                });

            migrationBuilder.CreateTable(
                name: "TPackage",
                columns: table => new
                {
                    packageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    namePackage = table.Column<string>(nullable: false),
                    maxPackage = table.Column<int>(nullable: false),
                    costPackage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPackage", x => x.packageID);
                });

            migrationBuilder.CreateTable(
                name: "TMember",
                columns: table => new
                {
                    memberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    registraiondateMember = table.Column<DateTime>(nullable: false),
                    fullnameMember = table.Column<string>(nullable: false),
                    ageMember = table.Column<int>(nullable: false),
                    phonenumberMember = table.Column<string>(nullable: true),
                    addressMember = table.Column<string>(nullable: true),
                    anotherRentalMember = table.Column<bool>(nullable: false),
                    statusMember = table.Column<bool>(nullable: false),
                    packageID = table.Column<int>(nullable: false),
                    knowthisID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMember", x => x.memberID);
                    table.ForeignKey(
                        name: "FK_TMember_TKnowThis_knowthisID",
                        column: x => x.knowthisID,
                        principalTable: "TKnowThis",
                        principalColumn: "knowthisID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TMember_TPackage_packageID",
                        column: x => x.packageID,
                        principalTable: "TPackage",
                        principalColumn: "packageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TMemberConfirmContact",
                columns: table => new
                {
                    confirmcontactID = table.Column<int>(nullable: false),
                    memberID = table.Column<int>(nullable: false),
                    verificationMemberConfirmContact = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMemberConfirmContact", x => new { x.confirmcontactID, x.memberID });
                    table.ForeignKey(
                        name: "FK_TMemberConfirmContact_TConfirmContact_confirmcontactID",
                        column: x => x.confirmcontactID,
                        principalTable: "TConfirmContact",
                        principalColumn: "confirmcontactID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TMemberConfirmContact_TMember_memberID",
                        column: x => x.memberID,
                        principalTable: "TMember",
                        principalColumn: "memberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TMember_knowthisID",
                table: "TMember",
                column: "knowthisID");

            migrationBuilder.CreateIndex(
                name: "IX_TMember_packageID",
                table: "TMember",
                column: "packageID");

            migrationBuilder.CreateIndex(
                name: "IX_TMemberConfirmContact_memberID",
                table: "TMemberConfirmContact",
                column: "memberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TMemberConfirmContact");

            migrationBuilder.DropTable(
                name: "TConfirmContact");

            migrationBuilder.DropTable(
                name: "TMember");

            migrationBuilder.DropTable(
                name: "TKnowThis");

            migrationBuilder.DropTable(
                name: "TPackage");
        }
    }
}
