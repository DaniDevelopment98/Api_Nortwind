using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedidosApi_Web.Models
{
    public class Customers
    {
        
        [Key]
        public int CompanyName { get; set; }
        public int MyProperty { get; set; }
        public int ContactName { get; set; }
        public int ContactTitle { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public int region { get; set; }
        public int PostalCode { get; set; }
        public int Country { get; set; }
        public int phone { get; set; }
        public int Fax { get; set; }
    }
}