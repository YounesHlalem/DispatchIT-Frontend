using IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto;
using IT.Netic.DispatchIt.Web.Portal.Helper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IT.Netic.DispatchIt.Web.Portal.Controllers
{
    public class MessageController : Controller
    {
        private static List<MessageDto> messages;
        private static MessageDto activeMessage;

        private readonly IApiHelper _apiHelper;

        public MessageController(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<IActionResult> MessageIndex()
        {
            string obj = @User.Identity.Name;

            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"GetMessages/{obj}");
            string content = await response.Content.ReadAsStringAsync();

            if (content != "No data found!")
            {
                messages = JsonConvert.DeserializeObject<List<MessageDto>>(content);
                return View(messages);
            }

            return View();
        }

        public IActionResult ShowMessage(int MessageId)
        {
            activeMessage = messages.Find(x => x.MessageId == MessageId);
            return View(activeMessage);
        }
    }
}
