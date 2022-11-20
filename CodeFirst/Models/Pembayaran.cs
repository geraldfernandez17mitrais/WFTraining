using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Pembayaran
    {
        [Key]
        public int Id { get; set; }
        public bool BankTransfer { get; set; }
        public bool COD { get; set; }
        public bool Mitra { get; set; }
    }
}
