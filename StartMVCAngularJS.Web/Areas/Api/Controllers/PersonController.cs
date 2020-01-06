using Microsoft.AspNet.OData;
using StartMVCAngularJS.Core.DataObject.People;
using StartMVCAngularJS.Core.UnitOfWork;
using StartMVCAngularJS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static StartMVCAngularJS.Service.Person.PersonService;

namespace StartMVCAngularJS.Web.Areas.Api.Controllers
{
    public class PersonController : BaseController
    {
        private readonly IPersonService _personService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public PersonController(IPersonService personService, IUnitOfWorkAsync unitOfWorkAsync)
        {
            _personService = personService;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IQueryable<PersonViewModel>> Get()
        {
            return await _personService.GetAllPeopleAsync();
        }
    }
}