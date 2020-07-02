using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covidcan.Models
{
    public class SummaryResponse
    {
        public SummaryCountryStatics Global { get; set; }
        public List<SummaryCountryStatics> Countries { get; set; }
    }
}