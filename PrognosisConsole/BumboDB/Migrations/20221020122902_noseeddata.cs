using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboDB.Migrations
{
    public partial class noseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filiaal_Locatie_FiliaalId",
                table: "Filiaal");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseInput_Eenheid_EenheidType",
                table: "PrognoseInput");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseInput_Filiaal_FiliaalID",
                table: "PrognoseInput");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseOutput_Afdeling_AfdelingNaam",
                table: "PrognoseOutput");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseOutput_Filiaal_FiliaalId",
                table: "PrognoseOutput");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemer_Afdeling_AfdelingNaam",
                table: "Werknemer");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemer_Filiaal_FiliaalId",
                table: "Werknemer");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemer_Functie_FunctieNaam",
                table: "Werknemer");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemer_Locatie_LocatieID",
                table: "Werknemer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Werknemer",
                table: "Werknemer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrognoseOutput",
                table: "PrognoseOutput");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrognoseInput",
                table: "PrognoseInput");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functie",
                table: "Functie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filiaal",
                table: "Filiaal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eenheid",
                table: "Eenheid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afdeling",
                table: "Afdeling");

            migrationBuilder.RenameTable(
                name: "Werknemer",
                newName: "Werknemers");

            migrationBuilder.RenameTable(
                name: "PrognoseOutput",
                newName: "PrognoseOutputs");

            migrationBuilder.RenameTable(
                name: "PrognoseInput",
                newName: "PrognoseInputs");

            migrationBuilder.RenameTable(
                name: "Locatie",
                newName: "Locaties");

            migrationBuilder.RenameTable(
                name: "Functie",
                newName: "Functies");

            migrationBuilder.RenameTable(
                name: "Filiaal",
                newName: "Filialen");

            migrationBuilder.RenameTable(
                name: "Eenheid",
                newName: "Eenheden");

            migrationBuilder.RenameTable(
                name: "Afdeling",
                newName: "Afdelingen");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemer_LocatieID",
                table: "Werknemers",
                newName: "IX_Werknemers_LocatieID");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemer_FunctieNaam",
                table: "Werknemers",
                newName: "IX_Werknemers_FunctieNaam");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemer_FiliaalId",
                table: "Werknemers",
                newName: "IX_Werknemers_FiliaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemer_AfdelingNaam",
                table: "Werknemers",
                newName: "IX_Werknemers_AfdelingNaam");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseOutput_FiliaalId",
                table: "PrognoseOutputs",
                newName: "IX_PrognoseOutputs_FiliaalId");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseOutput_AfdelingNaam",
                table: "PrognoseOutputs",
                newName: "IX_PrognoseOutputs_AfdelingNaam");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseInput_FiliaalID",
                table: "PrognoseInputs",
                newName: "IX_PrognoseInputs_FiliaalID");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseInput_EenheidType",
                table: "PrognoseInputs",
                newName: "IX_PrognoseInputs_EenheidType");

            migrationBuilder.AlterColumn<string>(
                name: "AfdelingNaam",
                table: "Werknemers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Werknemers",
                table: "Werknemers",
                column: "BID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrognoseOutputs",
                table: "PrognoseOutputs",
                columns: new[] { "Datum", "FiliaalId", "AfdelingNaam" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrognoseInputs",
                table: "PrognoseInputs",
                columns: new[] { "Datum", "FiliaalID", "EenheidType" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties",
                column: "LocatieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functies",
                table: "Functies",
                column: "Naam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filialen",
                table: "Filialen",
                column: "FiliaalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eenheden",
                table: "Eenheden",
                column: "EenheidType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afdelingen",
                table: "Afdelingen",
                column: "Naam");

            migrationBuilder.CreateTable(
                name: "Activiteiten",
                columns: table => new
                {
                    Beschrijving = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AfdelingNaam = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activiteiten", x => x.Beschrijving);
                    table.ForeignKey(
                        name: "FK_Activiteiten_Afdelingen_AfdelingNaam",
                        column: x => x.AfdelingNaam,
                        principalTable: "Afdelingen",
                        principalColumn: "Naam");
                });

            migrationBuilder.CreateTable(
                name: "GewerkteUren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WerknemerBID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AfdelingNaam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FiliaalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GewerkteUren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GewerkteUren_Afdelingen_AfdelingNaam",
                        column: x => x.AfdelingNaam,
                        principalTable: "Afdelingen",
                        principalColumn: "Naam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GewerkteUren_Filialen_FiliaalId",
                        column: x => x.FiliaalId,
                        principalTable: "Filialen",
                        principalColumn: "FiliaalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GewerkteUren_Werknemers_WerknemerBID",
                        column: x => x.WerknemerBID,
                        principalTable: "Werknemers",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roosterpunten",
                columns: table => new
                {
                    RoosterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WerknemerBID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AfdelingNaam = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roosterpunten", x => x.RoosterId);
                    table.ForeignKey(
                        name: "FK_Roosterpunten_Afdelingen_AfdelingNaam",
                        column: x => x.AfdelingNaam,
                        principalTable: "Afdelingen",
                        principalColumn: "Naam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roosterpunten_Werknemers_WerknemerBID",
                        column: x => x.WerknemerBID,
                        principalTable: "Werknemers",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Normeringen",
                columns: table => new
                {
                    NormeringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EenheidType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActiviteitBeschrijving = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FiliaalId = table.Column<int>(type: "int", nullable: false),
                    AantalPerUur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Normeringen", x => x.NormeringId);
                    table.ForeignKey(
                        name: "FK_Normeringen_Activiteiten_ActiviteitBeschrijving",
                        column: x => x.ActiviteitBeschrijving,
                        principalTable: "Activiteiten",
                        principalColumn: "Beschrijving",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Normeringen_Eenheden_EenheidType",
                        column: x => x.EenheidType,
                        principalTable: "Eenheden",
                        principalColumn: "EenheidType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Normeringen_Filialen_FiliaalId",
                        column: x => x.FiliaalId,
                        principalTable: "Filialen",
                        principalColumn: "FiliaalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activiteiten_AfdelingNaam",
                table: "Activiteiten",
                column: "AfdelingNaam");

            migrationBuilder.CreateIndex(
                name: "IX_GewerkteUren_AfdelingNaam",
                table: "GewerkteUren",
                column: "AfdelingNaam");

            migrationBuilder.CreateIndex(
                name: "IX_GewerkteUren_FiliaalId",
                table: "GewerkteUren",
                column: "FiliaalId");

            migrationBuilder.CreateIndex(
                name: "IX_GewerkteUren_WerknemerBID",
                table: "GewerkteUren",
                column: "WerknemerBID");

            migrationBuilder.CreateIndex(
                name: "IX_Normeringen_ActiviteitBeschrijving",
                table: "Normeringen",
                column: "ActiviteitBeschrijving");

            migrationBuilder.CreateIndex(
                name: "IX_Normeringen_EenheidType",
                table: "Normeringen",
                column: "EenheidType");

            migrationBuilder.CreateIndex(
                name: "IX_Normeringen_FiliaalId",
                table: "Normeringen",
                column: "FiliaalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roosterpunten_AfdelingNaam",
                table: "Roosterpunten",
                column: "AfdelingNaam");

            migrationBuilder.CreateIndex(
                name: "IX_Roosterpunten_WerknemerBID",
                table: "Roosterpunten",
                column: "WerknemerBID");

            migrationBuilder.AddForeignKey(
                name: "FK_Filialen_Locaties_FiliaalId",
                table: "Filialen",
                column: "FiliaalId",
                principalTable: "Locaties",
                principalColumn: "LocatieId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseInputs_Eenheden_EenheidType",
                table: "PrognoseInputs",
                column: "EenheidType",
                principalTable: "Eenheden",
                principalColumn: "EenheidType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseInputs_Filialen_FiliaalID",
                table: "PrognoseInputs",
                column: "FiliaalID",
                principalTable: "Filialen",
                principalColumn: "FiliaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseOutputs_Afdelingen_AfdelingNaam",
                table: "PrognoseOutputs",
                column: "AfdelingNaam",
                principalTable: "Afdelingen",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseOutputs_Filialen_FiliaalId",
                table: "PrognoseOutputs",
                column: "FiliaalId",
                principalTable: "Filialen",
                principalColumn: "FiliaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Afdelingen_AfdelingNaam",
                table: "Werknemers",
                column: "AfdelingNaam",
                principalTable: "Afdelingen",
                principalColumn: "Naam");

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Filialen_FiliaalId",
                table: "Werknemers",
                column: "FiliaalId",
                principalTable: "Filialen",
                principalColumn: "FiliaalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Functies_FunctieNaam",
                table: "Werknemers",
                column: "FunctieNaam",
                principalTable: "Functies",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Locaties_LocatieID",
                table: "Werknemers",
                column: "LocatieID",
                principalTable: "Locaties",
                principalColumn: "LocatieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filialen_Locaties_FiliaalId",
                table: "Filialen");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseInputs_Eenheden_EenheidType",
                table: "PrognoseInputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseInputs_Filialen_FiliaalID",
                table: "PrognoseInputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseOutputs_Afdelingen_AfdelingNaam",
                table: "PrognoseOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_PrognoseOutputs_Filialen_FiliaalId",
                table: "PrognoseOutputs");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Afdelingen_AfdelingNaam",
                table: "Werknemers");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Filialen_FiliaalId",
                table: "Werknemers");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Functies_FunctieNaam",
                table: "Werknemers");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Locaties_LocatieID",
                table: "Werknemers");

            migrationBuilder.DropTable(
                name: "GewerkteUren");

            migrationBuilder.DropTable(
                name: "Normeringen");

            migrationBuilder.DropTable(
                name: "Roosterpunten");

            migrationBuilder.DropTable(
                name: "Activiteiten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Werknemers",
                table: "Werknemers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrognoseOutputs",
                table: "PrognoseOutputs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrognoseInputs",
                table: "PrognoseInputs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functies",
                table: "Functies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filialen",
                table: "Filialen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eenheden",
                table: "Eenheden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Afdelingen",
                table: "Afdelingen");

            migrationBuilder.RenameTable(
                name: "Werknemers",
                newName: "Werknemer");

            migrationBuilder.RenameTable(
                name: "PrognoseOutputs",
                newName: "PrognoseOutput");

            migrationBuilder.RenameTable(
                name: "PrognoseInputs",
                newName: "PrognoseInput");

            migrationBuilder.RenameTable(
                name: "Locaties",
                newName: "Locatie");

            migrationBuilder.RenameTable(
                name: "Functies",
                newName: "Functie");

            migrationBuilder.RenameTable(
                name: "Filialen",
                newName: "Filiaal");

            migrationBuilder.RenameTable(
                name: "Eenheden",
                newName: "Eenheid");

            migrationBuilder.RenameTable(
                name: "Afdelingen",
                newName: "Afdeling");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemers_LocatieID",
                table: "Werknemer",
                newName: "IX_Werknemer_LocatieID");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemers_FunctieNaam",
                table: "Werknemer",
                newName: "IX_Werknemer_FunctieNaam");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemers_FiliaalId",
                table: "Werknemer",
                newName: "IX_Werknemer_FiliaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Werknemers_AfdelingNaam",
                table: "Werknemer",
                newName: "IX_Werknemer_AfdelingNaam");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseOutputs_FiliaalId",
                table: "PrognoseOutput",
                newName: "IX_PrognoseOutput_FiliaalId");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseOutputs_AfdelingNaam",
                table: "PrognoseOutput",
                newName: "IX_PrognoseOutput_AfdelingNaam");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseInputs_FiliaalID",
                table: "PrognoseInput",
                newName: "IX_PrognoseInput_FiliaalID");

            migrationBuilder.RenameIndex(
                name: "IX_PrognoseInputs_EenheidType",
                table: "PrognoseInput",
                newName: "IX_PrognoseInput_EenheidType");

            migrationBuilder.AlterColumn<string>(
                name: "AfdelingNaam",
                table: "Werknemer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Werknemer",
                table: "Werknemer",
                column: "BID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrognoseOutput",
                table: "PrognoseOutput",
                columns: new[] { "Datum", "FiliaalId", "AfdelingNaam" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrognoseInput",
                table: "PrognoseInput",
                columns: new[] { "Datum", "FiliaalID", "EenheidType" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie",
                column: "LocatieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functie",
                table: "Functie",
                column: "Naam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filiaal",
                table: "Filiaal",
                column: "FiliaalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eenheid",
                table: "Eenheid",
                column: "EenheidType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Afdeling",
                table: "Afdeling",
                column: "Naam");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiaal_Locatie_FiliaalId",
                table: "Filiaal",
                column: "FiliaalId",
                principalTable: "Locatie",
                principalColumn: "LocatieId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseInput_Eenheid_EenheidType",
                table: "PrognoseInput",
                column: "EenheidType",
                principalTable: "Eenheid",
                principalColumn: "EenheidType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseInput_Filiaal_FiliaalID",
                table: "PrognoseInput",
                column: "FiliaalID",
                principalTable: "Filiaal",
                principalColumn: "FiliaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseOutput_Afdeling_AfdelingNaam",
                table: "PrognoseOutput",
                column: "AfdelingNaam",
                principalTable: "Afdeling",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrognoseOutput_Filiaal_FiliaalId",
                table: "PrognoseOutput",
                column: "FiliaalId",
                principalTable: "Filiaal",
                principalColumn: "FiliaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemer_Afdeling_AfdelingNaam",
                table: "Werknemer",
                column: "AfdelingNaam",
                principalTable: "Afdeling",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemer_Filiaal_FiliaalId",
                table: "Werknemer",
                column: "FiliaalId",
                principalTable: "Filiaal",
                principalColumn: "FiliaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemer_Functie_FunctieNaam",
                table: "Werknemer",
                column: "FunctieNaam",
                principalTable: "Functie",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemer_Locatie_LocatieID",
                table: "Werknemer",
                column: "LocatieID",
                principalTable: "Locatie",
                principalColumn: "LocatieId");
        }
    }
}
