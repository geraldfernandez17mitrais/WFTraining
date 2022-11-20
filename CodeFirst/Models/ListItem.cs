﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class ListItem
    {
        [Key]
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public double Harga { get; set; }
        public string Lokasi { get; set; }
//        public byte[] GambarItem { get; set; }
    }
}
