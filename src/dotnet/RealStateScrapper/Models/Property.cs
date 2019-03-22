using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateScrapper.Models
{
    public class Property
    {
        public int ListingId { get; set; }
        public string PropertyType { get; set; }
        public double Price { get; set; }
        public double Beds { get; set; }
        public double Baths { get; set; }
        public string Location { get; set; }
        public double SquareMeters { get; set; }
        public double LotSize { get; set; }
        public int YearBuilt { get; set; }
        public int DaysOnMarket { get; set; }
        public double PricePerFeet { get; set; }
        public double AdminPerMonth { get; set; }
        public string ListingUrl { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
