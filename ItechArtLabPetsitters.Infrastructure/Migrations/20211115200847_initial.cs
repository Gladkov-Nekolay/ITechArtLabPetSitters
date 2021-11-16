    using Microsoft.EntityFrameworkCore.Migrations;

namespace ItechArtLabPetsitters.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKOrders_Clients__ClientID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Pets__PetID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Petsitters__PetsitterID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Services__ServiceID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKReviews_Clients__ClientID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FKReviews_Petsitters__PetsitterID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "_ServiceName",
                table: "Services",
                newName: "ServiceName");

            migrationBuilder.RenameColumn(
                name: "_Price",
                table: "Services",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "_Description",
                table: "Services",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "_ID",
                table: "Services",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "_PetsitterID",
                table: "Reviews",
                newName: "PetsitterID");

            migrationBuilder.RenameColumn(
                name: "_Mark",
                table: "Reviews",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "_Comment",
                table: "Reviews",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "_ClientID",
                table: "Reviews",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "_ReviewID",
                table: "Reviews",
                newName: "ReviewID");

            migrationBuilder.RenameIndex(
                name: "IXReviews__PetsitterID",
                table: "Reviews",
                newName: "IXReviews_PetsitterID");

            migrationBuilder.RenameIndex(
                name: "IXReviews__ClientID",
                table: "Reviews",
                newName: "IXReviews_ClientID");

            migrationBuilder.RenameColumn(
                name: "_PetType",
                table: "Pets",
                newName: "PetType");

            migrationBuilder.RenameColumn(
                name: "_PetName",
                table: "Pets",
                newName: "PetName");

            migrationBuilder.RenameColumn(
                name: "_Description",
                table: "Pets",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "_Age",
                table: "Pets",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "_ID",
                table: "Pets",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "_ServiceID",
                table: "Orders",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "_PetsitterID",
                table: "Orders",
                newName: "PetsitterID");

            migrationBuilder.RenameColumn(
                name: "_PetID",
                table: "Orders",
                newName: "PetID");

            migrationBuilder.RenameColumn(
                name: "_Comment",
                table: "Orders",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "_ClientID",
                table: "Orders",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "_ID",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IXOrders__ServiceID",
                table: "Orders",
                newName: "IXOrders_ServiceID");

            migrationBuilder.RenameIndex(
                name: "IXOrders__PetsitterID",
                table: "Orders",
                newName: "IXOrders_PetsitterID");

            migrationBuilder.RenameIndex(
                name: "IXOrders__PetID",
                table: "Orders",
                newName: "IXOrders_PetID");

            migrationBuilder.RenameIndex(
                name: "IXOrders__ClientID",
                table: "Orders",
                newName: "IXOrders_ClientID");

            migrationBuilder.RenameColumn(
                name: "_PhoneNumber",
                table: "Clients",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "_Name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "_ID",
                table: "Clients",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Clients_ClientID",
                table: "Orders",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Pets_PetID",
                table: "Orders",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Petsitters_PetsitterID",
                table: "Orders",
                column: "PetsitterID",
                principalTable: "Petsitters",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Services_ServiceID",
                table: "Orders",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKReviews_Clients_ClientID",
                table: "Reviews",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKReviews_Petsitters_PetsitterID",
                table: "Reviews",
                column: "PetsitterID",
                principalTable: "Petsitters",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKOrders_Clients_ClientID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Pets_PetID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Petsitters_PetsitterID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKOrders_Services_ServiceID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FKReviews_Clients_ClientID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FKReviews_Petsitters_PetsitterID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ServiceName",
                table: "Services",
                newName: "_ServiceName");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Services",
                newName: "_Price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "_Description");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Services",
                newName: "_ID");

            migrationBuilder.RenameColumn(
                name: "PetsitterID",
                table: "Reviews",
                newName: "_PetsitterID");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "Reviews",
                newName: "_Mark");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Reviews",
                newName: "_Comment");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Reviews",
                newName: "_ClientID");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "Reviews",
                newName: "_ReviewID");

            migrationBuilder.RenameIndex(
                name: "IXReviews_PetsitterID",
                table: "Reviews",
                newName: "IXReviews__PetsitterID");

            migrationBuilder.RenameIndex(
                name: "IXReviews_ClientID",
                table: "Reviews",
                newName: "IXReviews__ClientID");

            migrationBuilder.RenameColumn(
                name: "PetType",
                table: "Pets",
                newName: "_PetType");

            migrationBuilder.RenameColumn(
                name: "PetName",
                table: "Pets",
                newName: "_PetName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Pets",
                newName: "_Description");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Pets",
                newName: "_Age");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pets",
                newName: "_ID");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "Orders",
                newName: "_ServiceID");

            migrationBuilder.RenameColumn(
                name: "PetsitterID",
                table: "Orders",
                newName: "_PetsitterID");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Orders",
                newName: "_PetID");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Orders",
                newName: "_Comment");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Orders",
                newName: "_ClientID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "_ID");

            migrationBuilder.RenameIndex(
                name: "IXOrders_ServiceID",
                table: "Orders",
                newName: "IXOrders__ServiceID");

            migrationBuilder.RenameIndex(
                name: "IXOrders_PetsitterID",
                table: "Orders",
                newName: "IXOrders__PetsitterID");

            migrationBuilder.RenameIndex(
                name: "IXOrders_PetID",
                table: "Orders",
                newName: "IXOrders__PetID");

            migrationBuilder.RenameIndex(
                name: "IXOrders_ClientID",
                table: "Orders",
                newName: "IXOrders__ClientID");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Clients",
                newName: "_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "_Name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clients",
                newName: "_ID");

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Clients__ClientID",
                table: "Orders",
                column: "_ClientID",
                principalTable: "Clients",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Pets__PetID",
                table: "Orders",
                column: "_PetID",
                principalTable: "Pets",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Petsitters__PetsitterID",
                table: "Orders",
                column: "_PetsitterID",
                principalTable: "Petsitters",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKOrders_Services__ServiceID",
                table: "Orders",
                column: "_ServiceID",
                principalTable: "Services",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKReviews_Clients__ClientID",
                table: "Reviews",
                column: "_ClientID",
                principalTable: "Clients",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKReviews_Petsitters__PetsitterID",
                table: "Reviews",
                column: "_PetsitterID",
                principalTable: "Petsitters",
                principalColumn: "_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
