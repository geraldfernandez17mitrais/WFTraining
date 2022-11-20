using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Keranjang
    {
        [Key]
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public double Harga { get; set; }
        public double SubTotal { get; set; } //harga barang X qty 
        public double TotalJumlah { get; set; }
        public string NamaToko { get; set; } //atau ambil username dari penjuall (?)
        public string Lokasi { get; set; }
 //       public byte[] GambarItem { get; set; }

    }
}
