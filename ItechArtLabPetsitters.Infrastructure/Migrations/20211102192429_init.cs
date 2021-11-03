using Microsoft.EntityFrameworkCore.Migrations;

namespace ItechArtLabPetsitters.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    _ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x._ID);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    _ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _PetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _PetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Age = table.Column<byte>(type: "tinyint", nullable: false),
                    _Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x._ID);
                });

            migrationBuilder.CreateTable(
                name: "Petsitters",
                columns: table => new
                {
                    _ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petsitters", x => x._ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    _ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x._ID);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    _ReviewID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _PetsitterID = table.Column<long>(type: "bigint", nullable: false),
                    _ClientID = table.Column<long>(type: "bigint", nullable: false),
                    _Mark = table.Column<byte>(type: "tinyint", nullable: false),
                    _Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x._ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Clients__ClientID",
                        column: x => x._ClientID,
                        principalTable: "Clients",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Petsitters__PetsitterID",
                        column: x => x._PetsitterID,
                        principalTable: "Petsitters",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    _ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _ServiceID = table.Column<long>(type: "bigint", nullable: false),
                    _PetID = table.Column<long>(type: "bigint", nullable: false),
                    _PetsitterID = table.Column<long>(type: "bigint", nullable: false),
                    _ClientID = table.Column<long>(type: "bigint", nullable: false),
                    _Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x._ID);
                    table.ForeignKey(
                        name: "FK_Orders_Clients__ClientID",
                        column: x => x._ClientID,
                        principalTable: "Clients",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Pets__PetID",
                        column: x => x._PetID,
                        principalTable: "Pets",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Petsitters__PetsitterID",
                        column: x => x._PetsitterID,
                        principalTable: "Petsitters",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Services__ServiceID",
                        column: x => x._ServiceID,
                        principalTable: "Services",
                        principalColumn: "_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders__ClientID",
                table: "Orders",
                column: "_ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders__PetID",
                table: "Orders",
                column: "_PetID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders__PetsitterID",
                table: "Orders",
                column: "_PetsitterID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders__ServiceID",
                table: "Orders",
                column: "_ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews__ClientID",
                table: "Reviews",
                column: "_ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews__PetsitterID",
                table: "Reviews",
                column: "_PetsitterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Petsitters");
        }
    }
}
