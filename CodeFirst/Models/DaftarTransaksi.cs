using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class DaftarTransaksi
    {
        [Key]
        public int Id { get; set; }
        public string StatusTransaksi { get; set; }
        public double TotalTagihan { get; set; }
  //      public DateOnly Tanggal { get; set; }

        public int PenggunaId { get; set; }
        [ForeignKey(nameof(PenggunaId))]
        public Pengguna Pengguna { get; set; }
        public int ProdukId { get; set; }
        [ForeignKey(nameof(ProdukId))]
        public ListItem ListItem { get; set; }

    }
}
