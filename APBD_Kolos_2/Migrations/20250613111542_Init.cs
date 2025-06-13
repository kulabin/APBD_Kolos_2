using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Kolos_2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Artwork",
                columns: table => new
                {
                    ArtworkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artwork", x => x.ArtworkId);
                });

            migrationBuilder.CreateTable(
                name: "Exhibition",
                columns: table => new
                {
                    ExhibitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfArtworks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibition", x => x.ExhibitionId);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    GalleryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstablishedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.GalleryID);
                });

            migrationBuilder.CreateTable(
                name: "Exhibition_Artwork",
                columns: table => new
                {
                    ExhibitionId = table.Column<int>(type: "int", nullable: false),
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    InsuranceValue = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibition_Artwork", x => new { x.ExhibitionId, x.ArtworkId });
                    table.ForeignKey(
                        name: "FK_Exhibition_Artwork_Artwork_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artwork",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exhibition_Artwork_Exhibition_ExhibitionId",
                        column: x => x.ExhibitionId,
                        principalTable: "Exhibition",
                        principalColumn: "ExhibitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", "B" },
                    { 2, new DateTime(2000, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B", "C" },
                    { 3, new DateTime(2000, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "C", "D" },
                    { 4, new DateTime(2000, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "D", "E" },
                    { 5, new DateTime(2000, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "E", "F" }
                });

            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "ArtworkId", "ArtistId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, "ASADASDAd", 2012 },
                    { 2, 2, "ASADA", 2013 },
                    { 3, 3, "ASSDAd", 2014 },
                    { 4, 4, "ADASDAd", 2015 },
                    { 5, 5, "ASADqweqwdsad", 2016 }
                });

            migrationBuilder.InsertData(
                table: "Exhibition",
                columns: new[] { "ExhibitionId", "EndDate", "GalleryId", "NumberOfArtworks", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AA" },
                    { 2, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AAB" },
                    { 3, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AAC" },
                    { 4, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AAD" },
                    { 5, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AAE" },
                    { 6, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AAF" }
                });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "GalleryID", "EstablishedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A" },
                    { 2, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B" },
                    { 3, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C" }
                });

            migrationBuilder.InsertData(
                table: "Exhibition_Artwork",
                columns: new[] { "ArtworkId", "ExhibitionId", "InsuranceValue" },
                values: new object[,]
                {
                    { 1, 1, 1200.33m },
                    { 2, 2, 1040.24m },
                    { 3, 3, 1030.64m },
                    { 4, 4, 1110.65m },
                    { 5, 5, 10055.92m },
                    { 1, 6, 101120.46m },
                    { 2, 7, 1012310.57m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_Artwork_ArtworkId",
                table: "Exhibition_Artwork",
                column: "ArtworkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Exhibition_Artwork");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "Artwork");

            migrationBuilder.DropTable(
                name: "Exhibition");
        }
    }
}
