﻿using StartMVCAngularJS.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Core.DataContext
{
    namespace Repository.Pattern.DataContext
    {
        public interface IDataContextAsync : IDataContext
        {
            Task<int> SaveChangesAsync(CancellationToken cancellationToken);
            Task<int> SaveChangesAsync();
            DbSet<IObjectState> Set<T>();
        }
    }
}
