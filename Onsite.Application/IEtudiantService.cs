using Onsite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Application
{
    public interface IEtudiantService
    {
        Task<IEnumerable<EtudiantEntity>> GetAll();
    }
}
