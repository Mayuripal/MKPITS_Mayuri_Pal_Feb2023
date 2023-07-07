using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace ProductDropdown.Models
{
    public class Search
    {
        [Required(ErrorMessage ="Enter Category")]
        public string Category { get; set; }
        
        [Required(ErrorMessage ="Enter Product")]
        public string Product { get; set; }

    }
}