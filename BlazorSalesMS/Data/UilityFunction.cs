using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorSalesMS.Data
{
    public class UilityFunction
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;

        public UilityFunction(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<bool> CheckDuplicateAsync<TEntity>(
         Func<ApplicationDbContext, DbSet<TEntity>> dbSetSelector,
         Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            using var context = _dbFactory.CreateDbContext();

            var exists = await dbSetSelector(context).AnyAsync(predicate);
            return !exists; // true = no duplicate, false = duplicate found
        }
    }
}
