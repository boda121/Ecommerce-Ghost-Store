using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ghost_T.Migrations
{
    /// <inheritdoc />
    public partial class fu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Customers_CustomerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Deliveryes_DeliveryId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_ProductId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categorias_CategorieId",
                table: "products");

            migrationBuilder.DropTable(
                name: "Deliveryes");

            migrationBuilder.DropTable(
                name: "OrderOrders_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategorieId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_DeliveryId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_ProductId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders_Products",
                table: "orders_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Customer_Id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Delivery_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "orders_Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "orders_Products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "orders_Products",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "Products",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "ProductImage",
                table: "Products",
                newName: "PicturePath");

            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "Products",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Products",
                newName: "UnitInStock");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "DeliveryId",
                table: "Orders",
                newName: "Taxes");

            migrationBuilder.RenameIndex(
                name: "IX_orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Region_Customer",
                table: "Customers",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Phone_Customer",
                table: "Customers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name_Customer",
                table: "Customers",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Email_Customer",
                table: "Customers",
                newName: "PicturePath");

            migrationBuilder.RenameColumn(
                name: "City_Customer",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Address_Customer",
                table: "Customers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "RecordId",
                table: "Cart",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderDetails",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Categorie_id",
                table: "OrderDetails",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategorieType",
                table: "Categories",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ProductAvailable",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CancelOrder",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DIspatched",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deliver",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DispatchedDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShippingDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Categories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "RecentlyViews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ViewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyViews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RecentlyViews_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecentlyViews_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Wishlists_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlists_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryID",
                table: "Products",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyViews_CustomerID",
                table: "RecentlyViews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyViews_ProductID",
                table: "RecentlyViews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerID",
                table: "Reviews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductID",
                table: "Reviews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_CustomerID",
                table: "Wishlists",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ProductID",
                table: "Wishlists",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                table: "OrderDetails",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryID",
                table: "Products",
                column: "SubCategoryID",
                principalTable: "SubCategories",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "RecentlyViews");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubCategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductAvailable",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CancelOrder",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DIspatched",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Deliver",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DispatchedDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isCompleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orders_Products");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categorias");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "products",
                newName: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "UnitInStock",
                table: "products",
                newName: "CategorieId");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "PicturePath",
                table: "products",
                newName: "ProductImage");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "products",
                newName: "ProductDescription");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "orders",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "orders",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Taxes",
                table: "orders",
                newName: "DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerID",
                table: "orders",
                newName: "IX_orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Customers",
                newName: "Region_Customer");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Customers",
                newName: "Phone_Customer");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Customers",
                newName: "Name_Customer");

            migrationBuilder.RenameColumn(
                name: "PicturePath",
                table: "Customers",
                newName: "Email_Customer");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "City_Customer");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customers",
                newName: "Address_Customer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cart",
                newName: "RecordId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "orders_Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "orders_Products",
                newName: "Categorie_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categorias",
                newName: "CategorieType");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Customer_Id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Delivery_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "orders_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "orders_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders_Products",
                table: "orders_Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Deliveryes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Type_Delivery = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveryes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderOrders_Product",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOrders_Product", x => new { x.orderId, x.productId });
                    table.ForeignKey(
                        name: "FK_OrderOrders_Product_orders_Products_productId",
                        column: x => x.productId,
                        principalTable: "orders_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderOrders_Product_orders_orderId",
                        column: x => x.orderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategorieId",
                table: "products",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_DeliveryId",
                table: "orders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ProductId",
                table: "orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOrders_Product_productId",
                table: "OrderOrders_Product",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Customers_CustomerId",
                table: "orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Deliveryes_DeliveryId",
                table: "orders",
                column: "DeliveryId",
                principalTable: "Deliveryes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_ProductId",
                table: "orders",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categorias_CategorieId",
                table: "products",
                column: "CategorieId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
