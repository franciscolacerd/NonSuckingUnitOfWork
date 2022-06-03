﻿using Microsoft.EntityFrameworkCore;
using NSUOW.Domain.Common;
using System.Linq.Expressions;

namespace NSUOW.Persistence.Repositories
{
    public class BaseRepository<TEntity, TContext>
           where TEntity : BaseDomainEntity
           where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public BaseRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Skip(int page, int pageSize) { return (page - 1) * pageSize; }

        public IQueryable<TEntity> SetFiltersToQuery(
             Expression<Func<TEntity, bool>>? predicate,
             Expression<Func<TEntity, object>>[]? includes)
        {
            var dbSet = _dbContext.Set<TEntity>();

            var _query = dbSet.AsNoTracking();

            if (predicate != null)
                _query = _query.Where(predicate);

            if (includes != null)
                _query = includes.Aggregate(_query, (current, include) => current.Include(include));

            return _query;
        }
    }
}
