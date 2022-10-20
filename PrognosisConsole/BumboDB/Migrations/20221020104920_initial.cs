using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboDB.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afdeling",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afdeling", x => x.Naam);
                });

            migrationBuilder.CreateTable(
                name: "Eenheid",
                columns: table => new
                {
                    EenheidType = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eenheid", x => x.EenheidType);
                });

            migrationBuilder.CreateTable(
                name: "Functie",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functie", x => x.Naam);
                });

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Huisnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaats = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.LocatieId);
                });

            migrationBuilder.CreateTable(
                name: "Filiaal",
                columns: table => new
                {
                    FiliaalId = table.Column<int>(type: "int", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocatieID = table.Column<int>(type: "int", nullable: false),
                    MeterSchappen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiaal", x => x.FiliaalId);
                    table.ForeignKey(
                        name: "FK_Filiaal_Locatie_FiliaalId",
                        column: x => x.FiliaalId,
                        principalTable: "Locatie",
                        principalColumn: "LocatieId");
                });

            migrationBuilder.CreateTable(
                name: "PrognoseInput",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FiliaalID = table.Column<int>(type: "int", nullable: false),
                    EenheidType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Waarde = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrognoseInput", x => new { x.Datum, x.FiliaalID, x.EenheidType });
                    table.ForeignKey(
                        name: "FK_PrognoseInput_Eenheid_EenheidType",
                        column: x => x.EenheidType,
                        principalTable: "Eenheid",
                        principalColumn: "EenheidType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrognoseInput_Filiaal_FiliaalID",
                        column: x => x.FiliaalID,
                        principalTable: "Filiaal",
                        principalColumn: "FiliaalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrognoseOutput",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FiliaalId = table.Column<int>(type: "int", nullable: false),
                    AfdelingNaam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AantalMedewerkers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrognoseOutput", x => new { x.Datum, x.FiliaalId, x.AfdelingNaam });
                    table.ForeignKey(
                        name: "FK_PrognoseOutput_Afdeling_AfdelingNaam",
                        column: x => x.AfdelingNaam,
                        principalTable: "Afdeling",
                        principalColumn: "Naam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrognoseOutput_Filiaal_FiliaalId",
                        column: x => x.FiliaalId,
                        principalTable: "Filiaal",
                        principalColumn: "FiliaalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Werknemer",
                columns: table => new
                {
                    BID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tussenvoegsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InDienstSinds = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Loonschaal = table.Column<int>(type: "int", nullable: false),
                    FunctieNaam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FiliaalId = table.Column<int>(type: "int", nullable: false),
                    LocatieID = table.Column<int>(type: "int", nullable: false),
                    AfdelingNaam = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werknemer", x => x.BID);
                    table.ForeignKey(
                        name: "FK_Werknemer_Afdeling_AfdelingNaam",
                        column: x => x.AfdelingNaam,
                        principalTable: "Afdeling",
                        principalColumn: "Naam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Werknemer_Filiaal_FiliaalId",
                        column: x => x.FiliaalId,
                        principalTable: "Filiaal",
                        principalColumn: "FiliaalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Werknemer_Functie_FunctieNaam",
                        column: x => x.FunctieNaam,
                        principalTable: "Functie",
                        principalColumn: "Naam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Werknemer_Locatie_LocatieID",
                        column: x => x.LocatieID,
                        principalTable: "Locatie",
                        principalColumn: "LocatieId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrognoseInput_EenheidType",
                table: "PrognoseInput",
                column: "EenheidType");

            migrationBuilder.CreateIndex(
                name: "IX_PrognoseInput_FiliaalID",
                table: "PrognoseInput",
                column: "FiliaalID");

            migrationBuilder.CreateIndex(
                name: "IX_PrognoseOutput_AfdelingNaam",
                table: "PrognoseOutput",
                column: "AfdelingNaam");

            migrationBuilder.CreateIndex(
                name: "IX_PrognoseOutput_FiliaalId",
                table: "PrognoseOutput",
                column: "FiliaalId");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_AfdelingNaam",
                table: "Werknemer",
                column: "AfdelingNaam");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_FiliaalId",
                table: "Werknemer",
                column: "FiliaalId");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_FunctieNaam",
                table: "Werknemer",
                column: "FunctieNaam");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_LocatieID",
                table: "Werknemer",
                column: "LocatieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrognoseInput");

            migrationBuilder.DropTable(
                name: "PrognoseOutput");

            migrationBuilder.DropTable(
                name: "Werknemer");

            migrationBuilder.DropTable(
                name: "Eenheid");

            migrationBuilder.DropTable(
                name: "Afdeling");

            migrationBuilder.DropTable(
                name: "Filiaal");

            migrationBuilder.DropTable(
                name: "Functie");

            migrationBuilder.DropTable(
                name: "Locatie");
        }
    }
}
