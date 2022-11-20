using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    public class CodeFirstDBContext : DbContext
    {
        public DbSet<Role> role { get; set; }
        public DbSet<Pengguna> pengguna { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=postgres;Port=5432;Database=FruitTest2;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Pembeli"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "Penjual"
                    }
                );

            modelBuilder.Entity<Pengguna>()
                .HasData(
                    new Pengguna
                    {
                        Id = 1,
                        Username = "user1",
                        Password = "pass1",
                        Email = "user1@gmail.com",
                        RoleId = 1
                    },
                    new Pengguna
                    {
                        Id = 2,
                        Username = "user2",
                        Password = "pass2",
                        Email = "user2@gmail.com",
                        RoleId = 1
                    },
                    new Pengguna
                    {
                        Id = 3,
                        Username = "user3",
                        Password = "pass3",
                        Email = "user3@gmail.com",
                        RoleId = 2
                    }
                );

            modelBuilder.Entity<AddItem>()
                .HasData(
                    new AddItem
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        StokProduk = 1,
                        DetailProduk = "Detail1"
                    },
                   new AddItem
                   {
                       Id = 2,
                       NamaProduk = "produk2",
                       Harga = 2000,
                       StokProduk = 2,
                       DetailProduk = "Detail2"
                   },
                    new AddItem
                    {
                        Id = 3,
                        NamaProduk = "produk3",
                        Harga = 3000,
                        StokProduk = 3,
                        DetailProduk = "Detail3"
                    }
                );

            modelBuilder.Entity<Checkout>()
                .HasData(
                    new Checkout
                    {
                        Id = 1,
                        Alamat = "alamat1",
                        NamaProduk = "produk1",
                        Harga = 1000,
                        SubTotal = 1000,
                        HargaOngkir = 9000,
                        TotalTagihan = 10000,
                        JumlahProduk = 1,
                        NamaToko = "toko1",
                        Lokasi = "lokasi1",
                    },
                   new Checkout
                   {
                       Id = 2,
                       Alamat = "alamat2",
                       NamaProduk = "produk2",
                       Harga = 2000,
                       SubTotal = 4000,
                       HargaOngkir = 9000,
                       TotalTagihan = 13000,
                       JumlahProduk = 2,
                       NamaToko = "toko2",
                       Lokasi = "lokasi2",
                   },
                    new Checkout
                    {
                        Id = 3,
                        Alamat = "alamat3",
                        NamaProduk = "produk3",
                        Harga = 3000,
                        SubTotal = 9000,
                        HargaOngkir = 9000,
                        TotalTagihan = 18000,
                        JumlahProduk = 3,
                        NamaToko = "toko3",
                        Lokasi = "lokasi3",
                    }
                );

            modelBuilder.Entity<DaftarTransaksi>()
                .HasData(
                    new DaftarTransaksi
                    {
                        Id = 1,
                        StatusTransaksi = "berhasil",
                        TotalTagihan = 10000,
                        PenggunaId = 1,
                        ProdukId = 1
                    },
                   new DaftarTransaksi
                   {
                       Id = 2,
                       StatusTransaksi = "gagal",
                       TotalTagihan = 13000,
                       PenggunaId = 2,
                       ProdukId = 2
                   },
                    new DaftarTransaksi
                    {
                        Id = 3,
                        StatusTransaksi = "berhasil",
                        TotalTagihan = 19000,
                        PenggunaId = 3,
                        ProdukId = 3
                    }
                );

            modelBuilder.Entity<Kategori>()
                .HasData(
                    new Kategori
                    {
                        Id = 1,
                        Buah = true,
                        Sayur = false
                    },
                   new Kategori
                   {
                       Id = 2,
                       Buah = false,
                       Sayur = true
                   },
                    new Kategori
                    {
                        Id = 3,
                        Buah = true,
                        Sayur = false
                    }
                );

            modelBuilder.Entity<Keranjang>()
                .HasData(
                    new Keranjang
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        SubTotal = 1000,
                        TotalJumlah = 1,
                        NamaToko = "toko1",
                        Lokasi = "lokasi1"
                    },
                   new Keranjang
                   {
                       Id = 2,
                       NamaProduk = "produk2",
                       Harga = 2000,
                       SubTotal = 4000,
                       TotalJumlah = 2,
                       NamaToko = "toko2",
                       Lokasi = "lokasi2"
                   },
                    new Keranjang
                    {
                        Id = 3,
                        NamaProduk = "produk3",
                        Harga = 3000,
                        SubTotal = 9000,
                        TotalJumlah = 3,
                        NamaToko = "toko3",
                        Lokasi = "lokasi3",
                    }
                );

            modelBuilder.Entity<ListItem>()
                .HasData(
                    new ListItem
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        Lokasi = "lokasi1"
                    },
                   new ListItem
                   {
                       Id = 2,
                       NamaProduk = "produk2",
                       Harga = 2000,
                       Lokasi = "lokasi2"
                   },
                    new ListItem
                    {
                        Id = 3,
                        NamaProduk = "produk3",
                        Harga = 3000,
                        Lokasi = "lokasi3"
                    }
                );

            modelBuilder.Entity<ListItemPenjual>()
                .HasData(
                    new ListItemPenjual
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        StokProduk = 1
                    },
                   new ListItemPenjual
                   {
                       Id = 2,
                       NamaProduk = "produk2",
                       Harga = 2000,
                       StokProduk = 2
                   },
                    new ListItemPenjual
                    {
                        Id = 3,
                        NamaProduk = "produk3",
                        Harga = 3000,
                        StokProduk = 3
                    }
                );

            modelBuilder.Entity<Lokasi>()
                .HasData(
                    new Lokasi
                    {
                        Id = 1,
                        DIY = true,
                        Sleman = false,
                        Bantul = false,
                        GunungKidul = false,
                        KulonProgo = false
                    },
                   new Lokasi
                   {
                       Id = 2,
                       DIY = false,
                       Sleman = true,
                       Bantul = false,
                       GunungKidul = false,
                       KulonProgo = false
                   },
                    new Lokasi
                    {
                        Id = 3,
                        DIY = false,
                        Sleman = false,
                        Bantul = true,
                        GunungKidul = false,
                        KulonProgo = false
                    }
                );

            modelBuilder.Entity<Pembayaran>()
                .HasData(
                    new Pembayaran
                    {
                        Id = 1,
                        BankTransfer = true,
                        COD = false,
                        Mitra = false
                    },
                   new Pembayaran
                   {
                       Id = 2,
                       BankTransfer = false,
                       COD = true,
                       Mitra = true
                   },
                    new Pembayaran
                    {
                        Id = 3,
                        BankTransfer = false,
                        COD = false,
                        Mitra = true
                    }
                );

            modelBuilder.Entity<Pengiriman>()
                .HasData(
                    new Pengiriman
                    {
                        Id = 1,
                        Grab = true,
                        Gosend = false,
                        JNE = false
                    },
                   new Pengiriman
                   {
                       Id = 2,
                       Grab = false,
                       Gosend = true,
                       JNE = false
                   },
                    new Pengiriman
                    {
                        Id = 3,
                        Grab = false,
                        Gosend = false,
                        JNE = true
                    }
                );

            modelBuilder.Entity<PerItem>()
                .HasData(
                    new PerItem
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        SubTotal = 1000,
                        JumlahProduk = 1,
                        StokProduk = 1,
                        Rating = 1,
                        DetailProduk = "DetailProduk1",
                        NamaToko = "toko1",
                        Lokasi = "lokasi1"
                    },
                    new PerItem
                    {
                        Id = 2,
                        NamaProduk = "produk2",
                        Harga = 2000,
                        SubTotal = 4000,
                        JumlahProduk = 2,
                        StokProduk = 2,
                        Rating = 2,
                        DetailProduk = "DetailProduk2",
                        NamaToko = "toko2",
                        Lokasi = "lokasi2"
                    },
                     new PerItem
                     {
                         Id = 3,
                         NamaProduk = "produk3",
                         Harga = 3000,
                         SubTotal = 9000,
                         JumlahProduk = 3,
                         StokProduk = 3,
                         Rating = 3,
                         DetailProduk = "DetailProduk3",
                         NamaToko = "toko3",
                         Lokasi = "lokasi3"
                     }
                );

            modelBuilder.Entity<Produk>()
                .HasData(
                    new Produk
                    {
                        Id = 1,
                        NamaProduk = "produk1",
                        Harga = 1000,
                        Lokasi = "lokasi1",
                        PenjualId = 1
                    },
                    new Produk
                    {
                        Id = 2,
                        NamaProduk = "produk2",
                        Harga = 2000,
                        Lokasi = "lokasi2",
                        PenjualId = 2
                    },
                    new Produk
                    {
                        Id = 3,
                        NamaProduk = "produk3",
                        Harga = 3000,
                        Lokasi = "lokasi3",
                        PenjualId = 3
                    }
                );
        }
    }
}