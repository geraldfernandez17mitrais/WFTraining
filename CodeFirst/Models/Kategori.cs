using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public bool Buah { get; set; }
        public bool Sayur { get; set; }
    }
}
