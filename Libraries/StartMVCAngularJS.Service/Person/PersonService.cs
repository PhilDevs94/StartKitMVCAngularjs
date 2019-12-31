using StartMVCAngularJS.Core.DataObject.People;
using StartMVCAngularJS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StartMVCAngularJS.Service.Person.PersonService;

namespace StartMVCAngularJS.Service.Person
{
    public class PersonService : Service<PersonDto>, IPersonService
    {
        public interface IPersonService : IService<PersonDto>
        {
            IQueryable<PersonDto> GetAllPeople();
            Task<IQueryable<PersonDto>> GetAllPeopleAsync();
        }
        private readonly IRepositoryAsync<PersonDto> _repository;

        public PersonService(IRepositoryAsync<PersonDto> repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<IQueryable<PersonDto>> GetAllPeopleAsync()
        {
            return Task.Run(() => GetAllPeople());
        }
        public IQueryable<PersonDto> GetAllPeople()
        {
            // add business logic here
            return _repository.Queryable();
        }
        public override void Insert(PersonDto entity)
        {
            // e.g. add business logic here before inserting
            base.Insert(entity);
        }
    }
}
