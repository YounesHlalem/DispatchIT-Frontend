using IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto;
using IT.Netic.DispatchIt.Web.Portal.Helper;
using IT.Netic.DispatchIt.Web.Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IT.Netic.DispatchIt.Web.Portal.Controllers
{
    public class CompanyController : Controller
    {
        private static List<CompanyBaseDto> companies;
        private static CompanyBaseDto activeCompany;

        private readonly IApiHelper _apiHelper;

        public CompanyController(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<IActionResult> CompanyIndex()
        {
            string obj = @User.Identity.Name;

            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"GetCompaniesByOwner?owner={obj}");
            string content = await response.Content.ReadAsStringAsync();

            if(content != "[]")
            {
                companies = JsonConvert.DeserializeObject<List<CompanyBaseDto>>(content);
                return View(companies);
            }

            return View();
        }

        public IActionResult AddCompany()
        {
            return View();
        }

        public IActionResult ShowCompany(int CompanyId)
        {
            activeCompany = companies.Find(x => x.CompanyId == CompanyId);
            return View(activeCompany);
        }

        public async Task<IActionResult> EditDelivery(int DeliveryId)
        {
            MultiEntitiesModel multiModel = new MultiEntitiesModel();
            multiModel.ListItems = GetSelectListItems(activeCompany.addresses);

            HttpResponseMessage response = await _apiHelper.GetAsync($"{_apiHelper.GetUrl()}GetDelivery/{DeliveryId}");
            string content = await response.Content.ReadAsStringAsync();

            if (content != null)
            {
                DeliveryrequestBaseDto deliveryrequest = JsonConvert.DeserializeObject<DeliveryrequestBaseDto>(content);
                multiModel.Deliveryrequest = deliveryrequest;
                multiModel.DeliveryAddress = deliveryrequest.deliveryAddress;
                return View(multiModel);
            }

            return View();
        }

        public IActionResult EditCompany()
        {
            return View(activeCompany);
        }

        public IActionResult AddAddress(int CompanyId)
        {
            AddressBaseDto addr = new AddressBaseDto();
            addr.CompanyId = CompanyId;
            return View(addr);
        }

        public async Task<IActionResult> ShowDeliveries(int CompanyId)
        {
            HttpResponseMessage response = await _apiHelper.GetAsync($"{_apiHelper.GetUrl()}GetDeliveriesForCompany/{CompanyId}");
            string content = await response.Content.ReadAsStringAsync();

            activeCompany = companies.Find(x => x.CompanyId == CompanyId);

            if (content != "No data found!")
            {
                List<DeliveryrequestBaseDto> deliveryrequests = JsonConvert.DeserializeObject<List<DeliveryrequestBaseDto>>(content);
                return View(deliveryrequests);
            }

            return View();
        }

        public async Task<IActionResult> ShowDelivery(int DeliveryId)
        {
            HttpResponseMessage response = await _apiHelper.GetAsync($"{_apiHelper.GetUrl()}GetDelivery/{DeliveryId}");
            string content = await response.Content.ReadAsStringAsync();

            if (content != null)
            {
                DeliveryrequestBaseDto deliveryrequest = JsonConvert.DeserializeObject<DeliveryrequestBaseDto>(content);
                return View(deliveryrequest);
            }

            return View();
        }

        public IActionResult AddDeliveryreq()
        {
            MultiEntitiesModel multiModel = new MultiEntitiesModel();
            multiModel.ListItems = GetSelectListItems(activeCompany.addresses);

            return View(multiModel);
        }

        public async Task<IActionResult> DeleteDelivery(int DeliveryId)
        {
            HttpResponseMessage response = await _apiHelper.DeleteAsync($"{_apiHelper.GetUrl()}DeleteDelivery/{ DeliveryId }");
            string content = await response.Content.ReadAsStringAsync();
            return RedirectToAction("CompanyIndex");
        }

        public async Task<IActionResult> DeleteCompany(int CompanyId)
        {
            HttpResponseMessage response = await _apiHelper.DeleteAsync($"{_apiHelper.GetUrl()}DeleteCompany/{ CompanyId }");
            string content = await response.Content.ReadAsStringAsync();
            return RedirectToAction("CompanyIndex");
        }

        [HttpPost]
        public ActionResult PutDelivery(MultiEntitiesModel multiModel)
        {
            DeliveryrequestBaseDto delreq = multiModel.Deliveryrequest;
            DeliveryAddressBaseDto addr = multiModel.DeliveryAddress;

            delreq.deliveryAddress = addr;

            _ = OnPutDeliveryAsync(delreq);
            return RedirectToAction("CompanyIndex");
        }

        [HttpPost]
        public ActionResult PutCompany(CompanyBaseDto company)
        {
            _ = OnPutCompanyAsync(company);
            return RedirectToAction("CompanyIndex");
        }

        [HttpPost]
        public ActionResult CreateDelivery(MultiEntitiesModel multiModel)
        {
            DeliveryrequestBaseDto delreq = multiModel.Deliveryrequest;
            DeliveryAddressBaseDto addr = multiModel.DeliveryAddress;

            delreq.status = "Open";
            delreq.companyId = activeCompany.CompanyId;
            delreq.creationDatetime = DateTime.Now;
            delreq.companyVat = activeCompany.VatNr;

            delreq.deliveryAddress = addr;

            _ = OnPostDeliveryAsync(delreq);
            return RedirectToAction("CompanyIndex");
        }

        [HttpPost]
        public ActionResult CreateCompany(MultiEntitiesModel multiModel)
        {
            CompanyBaseDto comp = multiModel.Company;
            AddressBaseDto addr = multiModel.Address;

            comp.Owner = @User.Identity.Name;
            comp.addresses = new List<AddressBaseDto>();
            comp.addresses.Add(addr);

            var run = OnPostCompanyAsync(comp);
            while (!(run.IsCompleted)){}
            if (run.IsCompletedSuccessfully)
            {
                companies.Add(comp);
                return RedirectToAction("ShowCompany", new { CompanyId = comp.CompanyId });
            }
            else
            {
                return RedirectToAction("CompanyIndex");
            };
        }

        [HttpPost]
        public async Task<ActionResult> CreateAddress(AddressBaseDto Address)
        {
            string obj = JsonConvert.SerializeObject(Address);
            StringContent content = new StringContent(obj, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _apiHelper.PostAsync(_apiHelper.GetUrl() + "AddAddressToComp", content);

            return RedirectToAction("CompanyIndex");
        }

        public async Task<IActionResult> OnPostCompanyAsync(CompanyBaseDto company)
        {
            string obj = JsonConvert.SerializeObject(company);
            StringContent content = new StringContent(obj, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _apiHelper.PostAsync(_apiHelper.GetUrl() + "AddCompany", content);

            return (IActionResult)response.Content;
        }

        public async Task<IActionResult> OnPostDeliveryAsync(DeliveryrequestBaseDto delr)
        {
            string obj = JsonConvert.SerializeObject(delr);
            StringContent content = new StringContent(obj, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _apiHelper.PostAsync(_apiHelper.GetUrl() + "AddDeliveryrequest", content);

            return (IActionResult)response.Content;
        }

        public async Task<IActionResult> OnPutDeliveryAsync(DeliveryrequestBaseDto delr)
        {
            string obj = JsonConvert.SerializeObject(delr);
            StringContent content = new StringContent(obj, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _apiHelper.PutAsync(_apiHelper.GetUrl() + "EditDeliveryrequest", content);

            return (IActionResult)response.Content;
        }

        public async Task<IActionResult> OnPutCompanyAsync(CompanyBaseDto company)
        {
            string obj = JsonConvert.SerializeObject(company);
            StringContent content = new StringContent(obj, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _apiHelper.PutAsync(_apiHelper.GetUrl() + "EditCompany", content);

            return (IActionResult)response.Content;
        }

        private List<SelectListItem> GetSelectListItems(List<AddressBaseDto> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.AddressId.ToString(),
                    Text = element.ToString()
                });
            }
            return selectList;
        }
    }
}