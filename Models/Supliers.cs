using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PedidosApi_Web.Models
{
    public class Categories
    {
        
            [Key]
        public int MyProperty { get; set; }
        public int CompanyName { get; set; }
        public int ContactName { get; set; }
        public int ContactTitle { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public int Region { get; set; }
        public int PostalCode { get; set; }
        public int Country { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public int HomePage { get; set; }
        


    }
}