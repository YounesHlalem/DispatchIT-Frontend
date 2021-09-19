using IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace IT.Netic.DispatchIt.Web.Portal.Models
{
    public class MultiEntitiesModel
    {
        public CompanyBaseDto Company { get; set; }
        public AddressBaseDto Address { get; set; }
        public DeliveryrequestBaseDto Deliveryrequest { get; set; }
        public DeliveryAddressBaseDto DeliveryAddress { get; set; }
        public ProgressBaseDto Progress { get; set; }
        public List<SelectListItem> ListItems { get; set; }
    }
}
