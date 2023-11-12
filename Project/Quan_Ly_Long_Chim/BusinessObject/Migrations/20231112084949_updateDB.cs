using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObject.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    createAt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    dateWork = table.Column<DateTime>(type: "date", nullable: true),
                    salary = table.Column<double>(type: "float", nullable: true),
                    dateBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Product",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    dateBuy = table.Column<DateTime>(type: "date", nullable: true),
                    total = table.Column<double>(type: "float", nullable: true),
                    idCustomer = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    idStaff = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK__Orders__idCustom__2D27B809",
                        column: x => x.idCustomer,
                        principalTable: "Customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Orders__idStaff__2E1BDC42",
                        column: x => x.idStaff,
                        principalTable: "Staff",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idStaff = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.id);
                    table.ForeignKey(
                        name: "FK__Report__idStaff__33D4B598",
                        column: x => x.idStaff,
                        principalTable: "Staff",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_import = table.Column<double>(type: "float", nullable: true),
                    price_export = table.Column<double>(type: "float", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTypeProduct = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                    table.ForeignKey(
                        name: "FK__Product__idTypeP__267ABA7A",
                        column: x => x.idTypeProduct,
                        principalTable: "Type_Product",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Order_Product",
                columns: table => new
                {
                    idProduct = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    idOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    discount = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Order_Pro__idOrd__30F848ED",
                        column: x => x.idOrder,
                        principalTable: "Orders",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Order_Pro__idPro__300424B4",
                        column: x => x.idProduct,
                        principalTable: "Product",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Product_idOrder",
                table: "Order_Product",
                column: "idOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Product_idProduct",
                table: "Order_Product",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_idCustomer",
                table: "Orders",
                column: "idCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_idStaff",
                table: "Orders",
                column: "idStaff");

            migrationBuilder.CreateIndex(
                name: "IX_Product_idTypeProduct",
                table: "Product",
                column: "idTypeProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Report_idStaff",
                table: "Report",
                column: "idStaff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_Product");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Type_Product");
        }
    }
}
