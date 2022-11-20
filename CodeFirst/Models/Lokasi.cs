using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Lokasi
    {
        [Key]
        public int Id { get; set; }
        public bool DIY { get; set; }
        public bool Sleman { get; set; }
        public bool Bantul { get; set; }
        public bool GunungKidul { get; set; }
        public bool KulonProgo { get; set; }
    }
}
