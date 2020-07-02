using Covidcan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Text;

namespace Covidcan.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            RestRequest request = new RestRequest("/dayone/country/turkey", Method.GET);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            IRestResponse response = new RestClient("https://api.covid19api.com/").Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<DailyCountryStatics> countryStats = JsonConvert.DeserializeObject<List<DailyCountryStatics>>(Encoding.UTF8.GetString(response.RawBytes));
                return View(countryStats);
            }
            else
            {
                return View("Error");
            }
        }
        public IActionResult List()
        {
            RestRequest request = new RestRequest("/dayone/country/turkey", Method.GET);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            IRestResponse response = new RestClient("https://api.covid19api.com/").Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<DailyCountryStatics> countryStats = JsonConvert.DeserializeObject<List<DailyCountryStatics>>(Encoding.UTF8.GetString(response.RawBytes));
                return View(countryStats);
            }
            else
            {
                return View("Error");
            }
        }
        public IActionResult ListAll()
        {
            RestRequest request = new RestRequest("/summary", Method.GET);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            IRestResponse response = new RestClient("https://api.covid19api.com/").Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                SummaryResponse countryStats = JsonConvert.DeserializeObject<SummaryResponse>(Encoding.UTF8.GetString(response.RawBytes));
                return View(countryStats);
            }
            else
            {
                return View("Error");
            }
        }
    }
}