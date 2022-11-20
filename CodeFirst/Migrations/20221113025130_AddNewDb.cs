using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddNewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<int>(type: "integer", nullable: false),
                    StokProduk = table.Column<int>(type: "integer", nullable: false),
                    DetailProduk = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: false),
                    SubTotal = table.Column<double>(type: "double precision", nullable: false),
                    HargaOngkir = table.Column<double>(type: "double precision", nullable: false),
                    TotalTagihan = table.Column<double>(type: "double precision", nullable: false),
                    JumlahProduk = table.Column<int>(type: "integer", nullable: false),
                    NamaToko = table.Column<string>(type: "text", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Buah = table.Column<bool>(type: "boolean", nullable: false),
                    Sayur = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keranjang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: false),
                    SubTotal = table.Column<double>(type: "double precision", nullable: false),
                    TotalJumlah = table.Column<double>(type: "double precision", nullable: false),
                    NamaToko = table.Column<string>(type: "text", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keranjang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListItemPenjual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<int>(type: "integer", nullable: false),
                    StokProduk = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItemPenjual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lokasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DIY = table.Column<bool>(type: "boolean", nullable: false),
                    Sleman = table.Column<bool>(type: "boolean", nullable: false),
                    Bantul = table.Column<bool>(type: "boolean", nullable: false),
                    GunungKidul = table.Column<bool>(type: "boolean", nullable: false),
                    KulonProgo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pembayaran",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BankTransfer = table.Column<bool>(type: "boolean", nullable: false),
                    COD = table.Column<bool>(type: "boolean", nullable: false),
                    Mitra = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembayaran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pengiriman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Grab = table.Column<bool>(type: "boolean", nullable: false),
                    Gosend = table.Column<bool>(type: "boolean", nullable: false),
                    JNE = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengiriman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: false),
                    SubTotal = table.Column<double>(type: "double precision", nullable: false),
                    JumlahProduk = table.Column<int>(type: "integer", nullable: false),
                    StokProduk = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    DetailProduk = table.Column<string>(type: "text", nullable: false),
                    NamaToko = table.Column<string>(type: "text", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaftarTransaksi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StatusTransaksi = table.Column<string>(type: "text", nullable: false),
                    TotalTagihan = table.Column<double>(type: "double precision", nullable: false),
                    PenggunaId = table.Column<int>(type: "integer", nullable: false),
                    ProdukId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaftarTransaksi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaftarTransaksi_ListItem_ProdukId",
                        column: x => x.ProdukId,
                        principalTable: "ListItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DaftarTransaksi_pengguna_PenggunaId",
                        column: x => x.PenggunaId,
                        principalTable: "pengguna",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaProduk = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<double>(type: "double precision", nullable: false),
                    Lokasi = table.Column<string>(type: "text", nullable: false),
                    PenjualId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produk_ListItem_PenjualId",
                        column: x => x.PenjualId,
                        principalTable: "ListItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddItem",
                columns: new[] { "Id", "DetailProduk", "Harga", "NamaProduk", "StokProduk" },
                values: new object[,]
                {
                    { 1, "Detail1", 1000, "produk1", 1 },
                    { 2, "Detail2", 2000, "produk2", 2 },
                    { 3, "Detail3", 3000, "produk3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Checkout",
                columns: new[] { "Id", "Alamat", "Harga", "HargaOngkir", "JumlahProduk", "Lokasi", "NamaProduk", "NamaToko", "SubTotal", "TotalTagihan" },
                values: new object[,]
                {
                    { 1, "alamat1", 1000.0, 9000.0, 1, "lokasi1", "produk1", "toko1", 1000.0, 10000.0 },
                    { 2, "alamat2", 2000.0, 9000.0, 2, "lokasi2", "produk2", "toko2", 4000.0, 13000.0 },
                    { 3, "alamat3", 3000.0, 9000.0, 3, "lokasi3", "produk3", "toko3", 9000.0, 18000.0 }
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "Buah", "Sayur" },
                values: new object[,]
                {
                    { 1, true, false },
                    { 2, false, true },
                    { 3, true, false }
                });

            migrationBuilder.InsertData(
                table: "Keranjang",
                columns: new[] { "Id", "Harga", "Lokasi", "NamaProduk", "NamaToko", "SubTotal", "TotalJumlah" },
                values: new object[,]
                {
                    { 1, 1000.0, "lokasi1", "produk1", "toko1", 1000.0, 1.0 },
                    { 2, 2000.0, "lokasi2", "produk2", "toko2", 4000.0, 2.0 },
                    { 3, 3000.0, "lokasi3", "produk3", "toko3", 9000.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "ListItem",
                columns: new[] { "Id", "Harga", "Lokasi", "NamaProduk" },
                values: new object[,]
                {
                    { 1, 1000.0, "lokasi1", "produk1" },
                    { 2, 2000.0, "lokasi2", "produk2" },
                    { 3, 3000.0, "lokasi3", "produk3" }
                });

            migrationBuilder.InsertData(
                table: "ListItemPenjual",
                columns: new[] { "Id", "Harga", "NamaProduk", "StokProduk" },
                values: new object[,]
                {
                    { 1, 1000, "produk1", 1 },
                    { 2, 2000, "produk2", 2 },
                    { 3, 3000, "produk3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Lokasi",
                columns: new[] { "Id", "Bantul", "DIY", "GunungKidul", "KulonProgo", "Sleman" },
                values: new object[,]
                {
                    { 1, false, true, false, false, false },
                    { 2, false, false, false, false, true },
                    { 3, true, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "Pembayaran",
                columns: new[] { "Id", "BankTransfer", "COD", "Mitra" },
                values: new object[,]
                {
                    { 1, true, false, false },
                    { 2, false, true, true },
                    { 3, false, false, true }
                });

            migrationBuilder.InsertData(
                table: "Pengiriman",
                columns: new[] { "Id", "Gosend", "Grab", "JNE" },
                values: new object[,]
                {
                    { 1, false, true, false },
                    { 2, true, false, false },
                    { 3, false, false, true }
                });

            migrationBuilder.InsertData(
                table: "PerItem",
                columns: new[] { "Id", "DetailProduk", "Harga", "JumlahProduk", "Lokasi", "NamaProduk", "NamaToko", "Rating", "StokProduk", "SubTotal" },
                values: new object[,]
                {
                    { 1, "DetailProduk1", 1000.0, 1, "lokasi1", "produk1", "toko1", 1, 1, 1000.0 },
                    { 2, "DetailProduk2", 2000.0, 2, "lokasi2", "produk2", "toko2", 2, 2, 4000.0 },
                    { 3, "DetailProduk3", 3000.0, 3, "lokasi3", "produk3", "toko3", 3, 3, 9000.0 }
                });

            migrationBuilder.InsertData(
                table: "DaftarTransaksi",
                columns: new[] { "Id", "PenggunaId", "ProdukId", "StatusTransaksi", "TotalTagihan" },
                values: new object[,]
                {
                    { 1, 1, 1, "berhasil", 10000.0 },
                    { 2, 2, 2, "gagal", 13000.0 },
                    { 3, 3, 3, "berhasil", 19000.0 }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "Id", "Harga", "Lokasi", "NamaProduk", "PenjualId" },
                values: new object[,]
                {
                    { 1, 1000.0, "lokasi1", "produk1", 1 },
                    { 2, 2000.0, "lokasi2", "produk2", 2 },
                    { 3, 3000.0, "lokasi3", "produk3", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaftarTransaksi_PenggunaId",
                table: "DaftarTransaksi",
                column: "PenggunaId");

            migrationBuilder.CreateIndex(
                name: "IX_DaftarTransaksi_ProdukId",
                table: "DaftarTransaksi",
                column: "ProdukId");

            migrationBuilder.CreateIndex(
                name: "IX_Produk_PenjualId",
                table: "Produk",
                column: "PenjualId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddItem");

            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "DaftarTransaksi");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Keranjang");

            migrationBuilder.DropTable(
                name: "ListItemPenjual");

            migrationBuilder.DropTable(
                name: "Lokasi");

            migrationBuilder.DropTable(
                name: "Pembayaran");

            migrationBuilder.DropTable(
                name: "Pengiriman");

            migrationBuilder.DropTable(
                name: "PerItem");

            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "ListItem");
        }
    }
}
