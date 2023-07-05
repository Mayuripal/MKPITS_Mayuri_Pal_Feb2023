using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcConnection.Models
{
    public class ItemModel
    {
        public int ID { get; set; } 
        public string ProdName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}