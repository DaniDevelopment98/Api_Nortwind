using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedidosApi_Web.Models
{
    public class Shippers
    {
        [Key]
        public int ShiperID { get; set; }
        public int CompanyName { get; set; }
        public int Phone { get; set; } 

    }
}