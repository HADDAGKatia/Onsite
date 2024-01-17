using Onsite.Application.Contracts;
using Onsite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Application
{
    public class MatiereService : IMatiereService
    {

        private readonly IMatiereRepository matiereRepository;

        public MatiereService(IMatiereRepository matiereRepository)
        {
            this.matiereRepository = matiereRepository;
        }

        public async Task<IEnumerable<MatiereEntity>> GetAll()
        {
            return await this.matiereRepository.GetAllAsync();
        }
    }
}
