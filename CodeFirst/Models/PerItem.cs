using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class PerItem
    {
        [Key]
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public double Harga { get; set; }
        public double SubTotal { get; set; }
        public int JumlahProduk { get; set; }
        public int StokProduk { get; set; }
        public int Rating { get; set; }
        public string DetailProduk { get; set; }
        public string NamaToko { get; set;  } //atau ambil username dari penjuall (?)
        public string Lokasi { get; set; }
//        public byte[] GambarItem { get; set; }
        
    }
}
