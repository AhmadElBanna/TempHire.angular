using Breeze.ContextProvider;
using Breeze.WebApi2;
using DomainModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TempHire.Services;

namespace HotTowel.Angular.Controllers
{
    [BreezeController]
    [Authorize]
    public class ResourceMgtController : ApiController
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();

        // ~/breeze/resourcemgt/StaffingResources
        [HttpGet]
        public IQueryable<StaffingResource> StaffingResources()
        {
            return _unitOfWork.StaffingResources.All();
        }

        [HttpGet]
        public IQueryable<object> StaffingResourceListItems()
        {
            return _unitOfWork.StaffingResourceListItems.All();
        }

        [HttpGet]
        public IQueryable<Address> Addresses()
        {
            return _unitOfWork.Addresses.All();
        }

        [HttpGet]
        public IQueryable<PhoneNumber> PhoneNumbers()
        {
            return _unitOfWork.PhoneNumbers.All();
        }

        [HttpGet]
        public IQueryable<Rate> Rates()
        {
            return _unitOfWork.Rates.All();
        }

        [HttpGet]
        public IQueryable<Skill> Skills()
        {
            return _unitOfWork.Skills.All();
        }

        [HttpGet]
        public IQueryable<WorkExperienceItem> WorkExperienceItems()
        {
            return _unitOfWork.WorkExperienceItems.All();
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _unitOfWork.Commit(saveBundle);
        }

        // ~/breeze/resourcemgt/Lookups
        [HttpGet]
        public LookupBundle Lookups()
        {
            return new LookupBundle
            {
                AddressTypes = _unitOfWork.AddressTypes.All().ToList(),
                PhoneNumberTypes = _unitOfWork.PhoneNumberTypes.All().ToList(),
                RateTypes = _unitOfWork.RateTypes.All().ToList(),
                States = _unitOfWork.States.All().ToList()
            };
        }
    }
}