using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class ListItemPenjual
    {
        [Key]
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int StokProduk { get; set; }
//        public byte[] GambarItem { get; set; }
    }
}
