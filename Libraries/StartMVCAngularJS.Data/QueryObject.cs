using StartMVCAngularJS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StartMVCAngularJS.Data
{
    public abstract class QueryObject<TEntity> : IQueryObject<TEntity>
    {
        private Expression<Func<TEntity, bool>> _query;

        public Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> query)
        {
            throw new NotImplementedException();
        }

        public Expression<Func<TEntity, bool>> And(IQueryObject<TEntity> queryObject)
        {
            throw new NotImplementedException();
        }

        public Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> query)
        {
            throw new NotImplementedException();
        }

        public Expression<Func<TEntity, bool>> Or(IQueryObject<TEntity> queryObject)
        {
            throw new NotImplementedException();
        }

        public virtual Expression<Func<TEntity, bool>> Query()
        {
            return _query;
        }
    }
}
