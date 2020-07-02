using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covidcan.Models
{
    public class DailyCountryStatics
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public long Confirmed { get; set; }
        public long Deaths { get; set; }
        public long Recovered { get; set; }
        public long Active { get; set; }
        public DateTime Date { get; set; }
    }
}