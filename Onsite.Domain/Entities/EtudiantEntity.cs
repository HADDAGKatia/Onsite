using Onsite.Domain.Common;

namespace Onsite.Domain.Entities
{
    public class EtudiantEntity : BaseEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}