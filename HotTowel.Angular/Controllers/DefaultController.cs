using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainModel;
using Breeze.WebApi2;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;

namespace HotTowel.Angular.Controllers
{
    public class LookupBundle
    {
        public IEnumerable<AddressType> AddressTypes { get; set; }
        public IEnumerable<PhoneNumberType> PhoneNumberTypes { get; set; }
        public IEnumerable<RateType> RateTypes { get; set; }
        public IEnumerable<State> States { get; set; }
    }

    [BreezeController]
    [Authorize]
    public class DefaultController : ApiController
    {
        // ~/breeze/Metadata
        [HttpGet]
        public string Metadata()
        {
            return new EFContextProvider<TempHireDbContext>().Metadata();
        } 
    }
}