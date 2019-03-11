using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Licz
    {
        [Display(Name = "Liczba")]
        public int liczba { get; set; }
        public string wynik;
    }
}