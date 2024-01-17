using Onsite.Domain.Entities;

namespace Onsite.Application.Contracts
{
    public interface IEtudiantRepository : IAsyncRepository<EtudiantEntity>
    {
        Task<IEnumerable<EtudiantEntity>> GetAllAsync();
    }
}