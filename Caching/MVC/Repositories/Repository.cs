using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MVC.Repositories
{
    public class Repository<TEntity> where TEntity : class
    {
        private DbContext dbContext;
        private DbSet<TEntity> dbSet;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get<TKey>(Expression<Func<TEntity, bool>> [] predicates = null, Expression<Func<TEntity,TKey>> keySelector = null)
        {
            IQueryable<TEntity> query = dbSet;

            foreach (var predicate in predicates)
            {
                query.Where(predicate);
            }

            query.OrderBy(keySelector);

            return query.ToList();
        }
    }
}