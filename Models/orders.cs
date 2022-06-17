using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedidosApi_Web.Models
{
    public class orders
    {
   
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int OrderDate { get; set; }
        public int RequiredDate { get; set; }
        public int ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public int Freight { get; set; }
        public int ShipName { get; set; }
        public int ShipAddress { get; set; }
        public int ShipCity { get; set; }
        public int ShipRegion { get; set; }
        public int ShipPostalCode { get; set; }
        public int ShipCountry { get; set; }
        
    }
}