using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using StartMVCAngularJS.Core.DataContext;
using StartMVCAngularJS.Core.DataContext.Repository.Pattern.DataContext;
using StartMVCAngularJS.Core.DataObject;
using StartMVCAngularJS.Core.Repositories;
using StartMVCAngularJS.Core.UnitOfWork;
using StartMVCAngularJS.Data;
using StartMVCAngularJS.Service.Person;
using StartMVCAngularJS.Service.Tasks;
using StartMVCAngularJS.Web.Controllers;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;
using static StartMVCAngularJS.Service.Person.PersonService;
using static StartMVCAngularJS.Service.Tasks.TaskService;

namespace StartMVCAngularJS.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container
                    .RegisterType(typeof(IRepository<>), typeof(Repository<>))
                    .RegisterType(typeof(IRepositoryAsync<>), typeof(Repository<>))
                    .RegisterType<DbContext, DataContext>(new HierarchicalLifetimeManager())
                    .RegisterType<IDataContext, DataContext>(new HierarchicalLifetimeManager())
                    .RegisterType<IDataContextAsync, DataContext>(new HierarchicalLifetimeManager())
                    .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new HierarchicalLifetimeManager())
                    .RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager())
                    .RegisterType<ApplicationUserManager>(new HierarchicalLifetimeManager())
                    .RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager())
                    .RegisterType<IPersonService, PersonService>()
                    .RegisterType<ITaskService, TaskService>()
                    .RegisterType<AccountController>(new InjectionConstructor())
                    .RegisterType<ManageController>(new InjectionConstructor());
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}