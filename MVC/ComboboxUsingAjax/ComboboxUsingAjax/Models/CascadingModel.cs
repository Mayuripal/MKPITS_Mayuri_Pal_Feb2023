using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComboboxUsingAjax.Models
{
    public class CascadingModel
    {
        public List<SelectListItem>Country { get; set; }
        public List<SelectListItem>State { get; set; }
        public List <SelectListItem>City { get; set;}

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        public CascadingModel() 
        { 
            this.Country=new List<SelectListItem>();
            this.State=new List<SelectListItem>();
            this.City=new List<SelectListItem>();
        }
    }
}