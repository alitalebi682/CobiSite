using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cobiWebSite.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupNews",
                columns: table => new
                {
                    GroupNewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupNewsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureGroupNews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupNews", x => x.GroupNewsID);
                });

            migrationBuilder.CreateTable(
                name: "NewsBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsBases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typeprojects",
                columns: table => new
                {
                    TypeprojectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupNewsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureGroupNews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typeprojects", x => x.TypeprojectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupNews");

            migrationBuilder.DropTable(
                name: "NewsBases");

            migrationBuilder.DropTable(
                name: "Typeprojects");
        }
    }
}
