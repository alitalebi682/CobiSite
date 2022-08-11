using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cobiWebSite.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupNewsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PictureGroupNewsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsRelateds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsRelatedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsRelateds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SingleUploadFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleUploadFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeNewsBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeNewsBaseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeNewsBases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rowtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rowmainnews = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Showpriority = table.Column<int>(type: "int", nullable: true),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachpicturemainUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachpicturesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Showprofile = table.Column<bool>(type: "bit", nullable: false),
                    Slectnews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mainnews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Keywordnews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GroupNewsId = table.Column<int>(type: "int", nullable: false),
                    NewseRelatedId = table.Column<int>(type: "int", nullable: false),
                    TypeNewsBaseId = table.Column<int>(type: "int", nullable: false),
                    CreatingBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsBases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsBases_GroupNews_GroupNewsId",
                        column: x => x.GroupNewsId,
                        principalTable: "GroupNews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsBases_NewsRelateds_NewseRelatedId",
                        column: x => x.NewseRelatedId,
                        principalTable: "NewsRelateds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsBases_TypeNewsBases_TypeNewsBaseId",
                        column: x => x.TypeNewsBaseId,
                        principalTable: "TypeNewsBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsBases_GroupNewsId",
                table: "NewsBases",
                column: "GroupNewsId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsBases_NewseRelatedId",
                table: "NewsBases",
                column: "NewseRelatedId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsBases_TypeNewsBaseId",
                table: "NewsBases",
                column: "TypeNewsBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsBases");

            migrationBuilder.DropTable(
                name: "SingleUploadFiles");

            migrationBuilder.DropTable(
                name: "GroupNews");

            migrationBuilder.DropTable(
                name: "NewsRelateds");

            migrationBuilder.DropTable(
                name: "TypeNewsBases");
        }
    }
}
