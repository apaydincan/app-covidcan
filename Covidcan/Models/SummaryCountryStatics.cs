using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covidcan.Models
{
    public class SummaryCountryStatics
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public long NewConfirmed { get; set; }
        public long TotalConfirmed { get; set; }
        public long NewDeaths { get; set; }
        public long TotalDeaths { get; set; }
        public long NewRecovered { get; set; }
        public long TotalRecovered { get; set; }
        public DateTime Date { get; set; }
    }
}
