using Microsoft.EntityFrameworkCore;
using Onsite.Application.Contracts;
using Onsite.Domain.Common;
using Onsite.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly OnsiteDBDbContext _dbContext;

        public RepositoryBase(OnsiteDBDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task<IReadOnlyList<T>> GetAllAsync()
        //{
        //    return await _dbContext.Set<T>().ToListAsync();
        //}
    }
}
