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
    public class EtudiantRepository : RepositoryBase<EtudiantEntity>, IEtudiantRepository
    {
        private readonly IMapper _mapper;

        public EtudiantRepository(OnsiteDBDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<EtudiantEntity>> GetAllAsync()
        {
            var etudiantList = await _dbContext.Etudiants.ToListAsync();

            var etudiantEntityList = _mapper.Map<List<EtudiantEntity>>(etudiantList);

            return etudiantEntityList;
        }
    }
}
