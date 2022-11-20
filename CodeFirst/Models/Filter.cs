using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Filter
    {
        public bool KategoriProduk { get; set; }
        public int Harga1  { get; set; }
        public int Harga2 { get; set; }
        public bool Lokasi { get; set; }
    }
}
