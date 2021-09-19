using IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto;
using IT.Netic.DispatchIt.Web.Portal.Helper;
using IT.Netic.DispatchIt.Web.Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IT.Netic.DispatchIt.Web.Portal.Controllers
{
    public class HomeController : Controller
    {
        private static List<CompanyBaseDto> companies;
        private static List<DeliveryrequestBaseDto> deliveryrequests;

        private readonly ILogger<HomeController> _logger;

        private readonly IApiHelper _apiHelper;

        public HomeController(ILogger<HomeController> logger, IApiHelper apiHelper)
        {
            _logger = logger;
            _apiHelper = apiHelper;
        }

        public async Task<IActionResult> Index()
        {
            deliveryrequests = new List<DeliveryrequestBaseDto>();

            string obj = @User.Identity.Name;
            HttpResponseMessage companyresponse = await _apiHelper.GetAsync($"GetCompaniesByOwner?owner={obj}");
            string companycontent = await companyresponse.Content.ReadAsStringAsync();

            if (companycontent != "[]")
            {
                companies = JsonConvert.DeserializeObject<List<CompanyBaseDto>>(companycontent);

                foreach(CompanyBaseDto c in companies)
                {
                    HttpResponseMessage response = await _apiHelper.GetAsync($"{_apiHelper.GetUrl()}GetDeliveriesForCompany/{c.CompanyId}");
                    string content = await response.Content.ReadAsStringAsync();
                    
                    if (content != "No data found!")
                    {
                        deliveryrequests.AddRange(JsonConvert.DeserializeObject<List<DeliveryrequestBaseDto>>(content));
                    }
                }
                if(deliveryrequests.Count > 0)
                {
                    return View(deliveryrequests);
                }
                
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
