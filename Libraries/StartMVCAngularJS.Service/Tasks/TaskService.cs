using StartMVCAngularJS.Core.DataObject.Tasks;
using StartMVCAngularJS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StartMVCAngularJS.Service.Tasks.TaskService;

namespace StartMVCAngularJS.Service.Tasks
{
    public class TaskService : Service<TaskDto>, ITaskService
    {
        public interface ITaskService : IService<TaskDto>
        {
            IQueryable<TaskDto> GetAllTask();
            Task<IQueryable<TaskDto>> GetAllTaskAsync();
        }
        private readonly IRepositoryAsync<TaskDto> _repository;

        public TaskService(IRepositoryAsync<TaskDto> repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<IQueryable<TaskDto>> GetAllTaskAsync()
        {
            return Task.Run(() => GetAllTask());
        }
        public IQueryable<TaskDto> GetAllTask()
        {
            // add business logic here
            return _repository.Queryable();
        }
        public override void Insert(TaskDto entity)
        {
            // e.g. add business logic here before inserting
            base.Insert(entity);
        }
    }
}
