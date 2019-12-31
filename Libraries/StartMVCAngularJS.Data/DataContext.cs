using Microsoft.AspNet.Identity.EntityFramework;
using StartMVCAngularJS.Core.DataContext;
using StartMVCAngularJS.Core.DataObject;
using StartMVCAngularJS.Core.DataObject.People;
using StartMVCAngularJS.Core.DataObject.Tasks;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>, IDataContext
    {
        private readonly Guid _instanceId;

        public DataContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            _instanceId = Guid.NewGuid();
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public Guid InstanceId => _instanceId;

        public DbSet<PersonDto> People { get; set; }
        public DbSet<TaskDto> Tasks { get; set; }
        public override int SaveChanges()
        {
            var changes = base.SaveChanges();
            return changes;
        }

        public static DataContext Create()
        {
            return new DataContext();
        }

        public override async Task<int> SaveChangesAsync()
        {
            return await SaveChangesAsync(CancellationToken.None);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var changesAsync = await base.SaveChangesAsync(cancellationToken);
            return changesAsync;
        }

        void IDataContext.SyncObjectState<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SyncObjectsStatePostCommit()
        {
            throw new NotImplementedException();
        }
    }
}
