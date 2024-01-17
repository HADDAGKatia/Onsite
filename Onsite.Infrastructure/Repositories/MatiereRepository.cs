using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Onsite.Application.Contracts;
using Onsite.Domain.Entities;
using Onsite.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Infrastructure.Repositories
{
    public class MatiereRepository : RepositoryBase<MatiereEntity>, IMatiereRepository
    {
        private readonly IMapper _mapper;

        public MatiereRepository(OnsiteDBDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MatiereEntity>> GetAllAsync()
        {
            var matiereList = await _dbContext.Matieres.ToListAsync();

            var matiereEntityList = _mapper.Map<List<MatiereEntity>>(matiereList);

            return matiereEntityList;
        }
    }
}
