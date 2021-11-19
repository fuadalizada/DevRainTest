using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevRainTest.DAL.Migrations
{
    public partial class InitMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    SURNAME = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USER_LOGIN_ATTEMPT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Attempt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISSUCCESS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USER_LOGIN_ATTEMPT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_USER_LOGIN_ATTEMPT_TBL_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TBL_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USER_LOGIN_ATTEMPT_USER_ID",
                table: "TBL_USER_LOGIN_ATTEMPT",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_USER_LOGIN_ATTEMPT");

            migrationBuilder.DropTable(
                name: "TBL_USER");
        }
    }
}
