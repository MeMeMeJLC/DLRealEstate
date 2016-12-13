using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dlrealestate3.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string Description { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int Price { get; set; }
        public string SaleStatus { get; set; }
        public int LandSize { get; set; }
        public int HouseSize { get; set; }
        public int GarageSpace { get; set; }
        public string Insurance { get; set; }
        public DateTime DateListed { get; set; }
        public int AgentId { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }


        public virtual Agent Agent { get; set; }
    }
}