using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace Pay_Tips.Data
{
    public interface IRepository<TEntity, TKey, TContext>
        where TEntity : class, IEntity<TKey>
        where TContext : DbContext
    {

        TEntity GetById(TKey id);
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TKey id);
        Task<TEntity> GetByIdAsync(TKey id);
        Task RemoveAsync(TEntity entityToDelete);
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<IList<TEntity>> GetAllAsync();
        
        Task<(IList<TEntity> data, int total, int totalDisplay)> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
    }
}
