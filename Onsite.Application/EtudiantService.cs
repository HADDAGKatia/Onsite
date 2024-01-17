using Onsite.Application.Contracts;
using Onsite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Application
{
    public class EtudiantService : IEtudiantService
    {
        private readonly IEtudiantRepository etudiantRepository;

        public EtudiantService(IEtudiantRepository etudiantRepository)
        {
            this.etudiantRepository = etudiantRepository;
        }

        public async Task<IEnumerable<EtudiantEntity>> GetAll()
        {
            
            return await this.etudiantRepository.GetAllAsync();
        }
    }
}
