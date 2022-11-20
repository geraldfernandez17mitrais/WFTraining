using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Pengiriman
    {
        [Key]
        public int Id { get; set; }
        public bool Grab { get; set; }
        public bool Gosend { get; set; }
        public bool JNE { get; set; }
    }
}
